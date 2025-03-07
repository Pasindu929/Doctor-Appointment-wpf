using System.Windows;

namespace DoctorAppointment
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AdminSignIn_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the SignIn page
            SignIn signInPage = new SignIn();
            signInPage.Show();
            this.Close(); // Close MainWindow
        }

        private void AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Login page
            Login loginPage = new Login();
            loginPage.Show();
            this.Close(); // Close MainWindow
        }
    }
}
