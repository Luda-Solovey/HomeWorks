using _08FormsAndValidation.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace _08FormsAndValidation.Models
{
    public class Client
    {
        //як використовувати Id?
        //public string? Id { get; set; }

        [StringLength(maximumLength:40, MinimumLength =3, ErrorMessage = "Довжина повинна бути від 3 до 40")]
        [Display(Name="Ім'я")]
        [Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(40,MinimumLength =3)]
        [Display(Name = "Прізвище")]
        [Required]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Email")]
        [UIHint("EmailAddress")]
        [Required]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Дата консультації")]
        [UIHint("Date")]
        [Required]

        //[DateValidate(ErrorMessage = "error")] реалізувала цю перевірку в контроллері через виклик статичного методу ValidateDate
        //[RegularExpression(@"\b(?:Saturday|Sunday)\b", ErrorMessage = "Ви обрали вихідний день. Будь ласка, оберіть будь-який робочий день.")]
        public DateTime Date { get; set; }

    }
}
