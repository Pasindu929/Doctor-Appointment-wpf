using System;
using System.Windows;

namespace DoctorAppointment
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Password.Trim();

            // Simple validation (Replace with real authentication)
            if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password == "1234")
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Navigate to HomePage
                HomePage homePage = new HomePage();
                homePage.Show();

                // Close the Login window
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials! Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            // Close the current Login window
            this.Close();
        }
    }
}
