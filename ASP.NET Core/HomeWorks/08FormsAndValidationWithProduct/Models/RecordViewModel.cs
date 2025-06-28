using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _08FormsAndValidation.Models
{
   

    public class RecordViewModel
    {
        //як використовувати Id?
      //  public string? Id { get; set; }

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
        public DateTime Date { get; set; }

        [Display(Name = "Предмет консультації: ")]
        public Products SelectedProduct { get; set; } //якщо тут вказати якесь значення, воно не вплине на відображення у в'ю
        //це значення треба вказати в обробнику контроллера (якщо не вказати, то в'ю відобразить перше значення з переліку
    }
}
