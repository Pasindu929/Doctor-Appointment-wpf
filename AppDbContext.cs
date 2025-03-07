using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment
{
    public class AppDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; } // Represents the Admins table

        // Configure SQLite as the database provider
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use the absolute path to the Doctors.db file
            string dbPath = @"C:\Users\MSI\source\repos\Doctor-Appointment\Doctors.db";
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }

    public class Admin
    {
    }
}
