using System;
using System.Data.SqlClient;
using System.Windows;

namespace DoctorAppointment
{
    public partial class SignIn : Window
    {
        // Connection string to your database
        private string connectionString = "Your_Connection_String_Here";

        public SignIn()
        {
            InitializeComponent();
        }

        // Event handler for the Sign In button
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (ValidateAdmin(username, password))
            {
                // Store admin data in the database
                StoreAdminData(username);

                // Redirect to the home page
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event handler for the Back button
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to the previous window or close the current window
            this.Close();
        }

        // Method to validate admin credentials
        private bool ValidateAdmin(string username, string password)
        {
            // Query to check if the admin exists in the database
            string query = "SELECT COUNT(*) FROM AdminTable WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        // Method to store admin data in the database
        private void StoreAdminData(string username)
        {
            // Query to insert admin data into the database
            string query = "INSERT INTO AdminTable (Username, SignInTime) VALUES (@Username, @SignInTime)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@SignInTime", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}