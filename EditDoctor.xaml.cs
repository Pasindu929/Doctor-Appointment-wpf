﻿using System;
using System.Windows;

namespace DoctorAppointment
{
    public partial class EditDoctor : Window
    {
        public EditDoctor()
        {
            InitializeComponent();
        }

        private void EditDoctor_Click(object sender, RoutedEventArgs e)
        {
            string doctorName = txtDoctorName.Text;
            string specialistArea = txtSpecialistArea.Text;
            string timePeriod = txtTimePeriod.Text;

            MessageBox.Show($"Doctor Updated:\nName: {doctorName}\nSpecialist: {specialistArea}\nTime: {timePeriod}", "Updated");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
