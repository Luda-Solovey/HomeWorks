using _12_AutentificationAvtorization.Models;
using _12_AutentificationAvtorization.Services;
using Microsoft.AspNetCore.Identity;

namespace _12_AutentificationAvtorization.DataBase
{
    public static class DataBaseUsers
    {
        public static List<UsersViewModel> Users { get; set; } = new List<UsersViewModel>()
        {
            new UsersViewModel()
            {
                Id = Guid.NewGuid(),
                Login = "test1",
                PasswordHash = ServiceForPassword.HashPassword("qwerty")
            }
        };
    }
}
