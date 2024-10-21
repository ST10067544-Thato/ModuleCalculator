using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CustomLibrary;

namespace ModuleCalculator.MVVM.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            DisplayUserModules();
        }

        //Method to register for the modules
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int loggedInUserID = UserSession.LoggedInUserID;

            if (!(PROGcheckBox.IsChecked == true) && !(ADDBcheckBox.IsChecked == true) && !(SOENcheckBox.IsChecked == true) && !(CLDVcheckBox.IsChecked == true))
            {
                // Display error message
                string messageBoxText = "Please select a module!";
                string caption = "Error!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection("Data Source=lab000000\\SQLEXPRESS; Initial Catalog=ModuleCalculatorDB; Integrated Security=True"))
                {
                    connection.Open();

                    int iVal;
                    if (int.TryParse(WeeksTextBox2.Text, out iVal))
                    {
                        try
                        {
                            if (PROGcheckBox.IsChecked == true)
                            {
                                int selfStudyHours = SelfStudyHours.getTotalStudyHours(15, iVal, 5);
                                InsertModuleData(connection, loggedInUserID, "Programming 2B", "PROG6212", 15, 5, WeeksDatePicker.SelectedDate.Value.Date, iVal, selfStudyHours);
                            }

                            if (ADDBcheckBox.IsChecked == true)
                            {
                                int selfStudyHours = SelfStudyHours.getTotalStudyHours(15, iVal, 5);
                                InsertModuleData(connection, loggedInUserID, "Advanced Databases", "ADDB7311", 15, 5, WeeksDatePicker.SelectedDate.Value.Date, iVal, selfStudyHours);
                            }

                            if (SOENcheckBox.IsChecked == true)
                            {
                                int selfStudyHours = SelfStudyHours.getTotalStudyHours(15, iVal, 5);
                                InsertModuleData(connection, loggedInUserID, "Software Engineering", "SOEN6222", 15, 5, WeeksDatePicker.SelectedDate.Value.Date, iVal, selfStudyHours);
                            }

                            if (CLDVcheckBox.IsChecked == true)
                            {
                                int selfStudyHours = SelfStudyHours.getTotalStudyHours(15, iVal, 5);
                                InsertModuleData(connection, loggedInUserID, "Cloud Development 2B", "CLDV6212", 15, 5, WeeksDatePicker.SelectedDate.Value.Date, iVal, selfStudyHours);
                            }
                            MessageBox.Show("Module(s) saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        catch (SqlException ex) //Error handling so that 1 student cannot register for the same module twice.
                        {
                            if (ex.Number == 2627) // Error number for duplicate key violation
                            {
                                MessageBox.Show("You're already registered for this module. Please choose a different one!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else
                            {
                                MessageBox.Show("An error occurred while registering: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }
                }
            }
            
        }

        // Method to insert data into the database/table Modules
        private void InsertModuleData(SqlConnection connection, int userID, string moduleName, string moduleCode, int moduleCredits, int classHours, DateTime semesterStartDate, int semesterWeeks, int selfStudyHours)
        {
            string insertQuery = "INSERT INTO Modules (UserID, ModuleName, ModuleCode, ModuleCredits, ClassHours, SemesterStartDate, SemesterWeeks, selfStudyHours) " +
                                 "VALUES (@UserID, @ModuleName, @ModuleCode, @ModuleCredits, @ClassHours, @SemesterStartDate, @SemesterWeeks, @SelfStudyHours)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@ModuleName", moduleName);
                cmd.Parameters.AddWithValue("@ModuleCode", moduleCode);
                cmd.Parameters.AddWithValue("@ModuleCredits", moduleCredits);
                cmd.Parameters.AddWithValue("@ClassHours", classHours);
                cmd.Parameters.AddWithValue("@SemesterStartDate", semesterStartDate);
                cmd.Parameters.AddWithValue("@SemesterWeeks", semesterWeeks);
                cmd.Parameters.AddWithValue("@SelfStudyHours", selfStudyHours);

                cmd.ExecuteNonQuery();
            }
        }

        //Method to Display the tale details for specific logged in user ONLY.
        private void DisplayUserModules()
        {
            int loggedInUserID = UserSession.LoggedInUserID;

            using (SqlConnection connection = new SqlConnection("Data Source=lab000000\\SQLEXPRESS; Initial Catalog=ModuleCalculatorDB; Integrated Security=True"))
            {
                connection.Open();

                string query = "SELECT * FROM Modules WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", loggedInUserID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Bind the DataTable to the DataGrid
                    userModulesDataGrid.ItemsSource = dt.DefaultView;
                }
            }
        }
    }
}

