using System;
using System.Windows;

namespace DoctorAppointment
{
    public partial class RemoveDoctor : Window
    {
        public RemoveDoctor()
        {
            InitializeComponent();
        }

        private void RemoveDoctor_Click(object sender, RoutedEventArgs e)
        {
            string doctorName = txtDoctorName.Text;

            MessageBox.Show($"Doctor Removed:\nName: {doctorName}", "Removed");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
