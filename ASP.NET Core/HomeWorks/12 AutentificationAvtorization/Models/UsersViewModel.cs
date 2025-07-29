namespace _12_AutentificationAvtorization.Models
{
    public class UsersViewModel
    {
        public Guid Id { get; set; }

        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

    }
}
