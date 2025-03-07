using System;
using System.Windows;

namespace DoctorAppointment
{
    public partial class AddDoctor : Window
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Click(object sender, RoutedEventArgs e)
        {
            string doctorName = txtDoctorName.Text;
            string specialistArea = txtSpecialistArea.Text;
            string timePeriod = txtTimePeriod.Text;

            MessageBox.Show($"Doctor Added:\nName: {doctorName}\nSpecialist: {specialistArea}\nTime: {timePeriod}", "Success");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
