using System.Text;
using System.Security.Cryptography;
using _12_AutentificationAvtorization.Models;

namespace _12_AutentificationAvtorization.Services
{
    public static class ServiceForPassword
    {
        public static string HashPassword(string password)
        {
            byte[] byted = Encoding.UTF8.GetBytes(password);
            var passwordHashed = SHA1CryptoServiceProvider.Create();
            byte[] hashedBytes = passwordHashed.ComputeHash(byted);

            return Encoding.UTF8.GetString(hashedBytes);
        }

        //public static bool IsCorrectPassword(User user, string password)
        //{
        //    var passwordHash = HashPassword(password);
        //    return passwordHash == user.PasswordHash;
        //}

        public static bool IsPasswordCorrect(UsersViewModel user, string password)
        {
            var passwordHashed = HashPassword(password);
            return passwordHashed ==user.PasswordHash;
        }
    }
}
