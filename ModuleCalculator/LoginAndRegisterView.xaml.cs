using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BCrypt.Net;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Diagnostics;
using CustomLibrary;

namespace ModuleCalculator.MVVM.View
{
    /// <summary>
    /// Interaction logic for LoginAndRegisterView.xaml
    /// </summary>
    public partial class LoginAndRegisterView : Window
    {
        public LoginAndRegisterView()
        {
            InitializeComponent();
        }

        //Method for the registration button 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Generate a salt and hash the password using BCrypt
            //Author: Claudio Bernasconi
            //Source: YouTube
            //Link: https://youtu.be/UNLl4kCpwGo
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(userPassword.Password, salt);

            // Convert the hashed password to a byte array to ensure that the @Password parameter receives the binary representation of the hashed password
            byte[] hashedPasswordBytes = System.Text.Encoding.UTF8.GetBytes(hashedPassword);

            // Insert the data into the SQL Server database
            string connectionString = "Data Source=lab000000\\SQLEXPRESS; Initial Catalog=ModuleCalculatorDB; Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password) VALUES (@Username, @Password)", connection))
                {
                    cmd.Parameters.AddWithValue("@Username", newUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", hashedPasswordBytes);

                    //try catch method to prevent duplicate usernames being captured
                    //Author: Niloofar
                    //Source: StackOverflow
                    //Link: https://stackoverflow.com/questions/12581230/which-error-code-is-return-in-sql-server-when-inserting-duplicate-value-in-prima
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registration successful! \nWelcome to Varsity College's Module Calculator.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) // Error number for duplicate key violation
                        {
                            MessageBox.Show("Username already exists. Please choose a different username!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while registering: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }

        //Method for the login button 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string storedHashedPassword = GetHashedPasswordFromDatabase(newUsername.Text);

            if (BCrypt.Net.BCrypt.Verify(userPassword.Password, storedHashedPassword))
            {
                int loggedInUserID = GetUserIDFromDatabase(newUsername.Text);

                // Store the UserID in the UserSession class
                UserSession.SetLoggedInUserID(loggedInUserID);

                MessageBox.Show($"Login successful! Welcome back {newUsername.Text} :)", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                MainWindow dashboard = new MainWindow();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login unsuccessful. Please check your username and password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        //Method to get the hashed password from the database
        public string GetHashedPasswordFromDatabase(string username)
        {
            string connectionString = "Data Source=lab000000\\SQLEXPRESS; Initial Catalog=ModuleCalculatorDB; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Encoding.Default.GetString((byte[])result);
                    }
                }
            }
            return null; // Return null if the user doesn't exist in the database.
        }

        // Method to get the UserID from the database based on the username
        public int GetUserIDFromDatabase(string username)
        {
            string connectionString = "Data Source=lab000000\\SQLEXPRESS; Initial Catalog=ModuleCalculatorDB; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                }
            }
            return 0; // Return a default value (0) if the user doesn't exist in the database.
        }

        //Method for the Exit icon/button
        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
