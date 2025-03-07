using System.Windows;

namespace DoctorAppointment
{
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to MainWindow (Login Screen)
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Close HomePage
        }

        private void AddDoctors_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to AddDoctor Page
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Show();
            this.Close();
        }

        private void EditDoctors_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to EditDoctor Page
            EditDoctor editDoctor = new EditDoctor();
            editDoctor.Show();
            this.Close();
        }

        private void RemoveDoctors_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to RemoveDoctor Page
            RemoveDoctor removeDoctor = new RemoveDoctor();
            removeDoctor.Show();
            this.Close();
        }
    }
}
