using System.ComponentModel.DataAnnotations;

namespace _12_AutentificationAvtorization.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Логін")]
        public string Login { get; set; } = string.Empty;

        [Required]
        [UIHint("Password")]
        [MinLength(5)]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [UIHint("Password")]
        [MinLength(5)]
        [Display(Name = "Підтвердження паролю")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
