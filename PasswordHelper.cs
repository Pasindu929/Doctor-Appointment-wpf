using System;
using System.Security.Cryptography;
using System.Text;

namespace DoctorAppointment
{
    public static class PasswordHelper
    {
        // Hash a password using SHA-256
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        // Verify if the input password matches the hashed password
        public static bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            return HashPassword(inputPassword) == hashedPassword;
        }
    }
}