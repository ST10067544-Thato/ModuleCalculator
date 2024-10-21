using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CustomLibrary;

namespace ModuleCalculator.MVVM.View
{
    /// <summary>
    /// Interaction logic for ModuleHoursView.xaml
    /// </summary>
    public partial class ModuleHoursView : UserControl
    {
        public ModuleHoursView()
        {
            InitializeComponent();
            DisplayUserModules();
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int loggedInUserID = UserSession.LoggedInUserID; 

            if (!(PROGcheckBox.IsChecked == true) && !(ADDBcheckBox.IsChecked == true) && !(SOENcheckBox.IsChecked == true) && !(CLDVcheckBox.IsChecked == true))
            {
                //Display error message
                string messageBoxText = "Please select a module to update!";
                string caption = "Error!";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.OK);
            }
        }
    }
}
