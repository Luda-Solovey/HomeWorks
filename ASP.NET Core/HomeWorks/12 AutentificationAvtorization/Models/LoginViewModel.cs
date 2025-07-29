using System.ComponentModel.DataAnnotations;

namespace _12_AutentificationAvtorization.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логін")]
        public string Login { get; set; } = string.Empty;

        [Required]
        [UIHint("Password")]
        [MinLength(5)]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = string.Empty;
    }
}
