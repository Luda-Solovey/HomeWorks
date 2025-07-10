using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace _08FormsAndValidation.Infrastructure
{

    //цей клас-атрибут не використовувала, прописала перевірку через статичний клас ValidateHelper
    //якщо таки треба буде створити атрибут, то крім кода нижче ще треба буде дізнатись, як передавати через атрибут повідомлення про помилку

    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter,
    //   AllowMultiple = false)]
    //public class DateValidateAttribute : ValidationAttribute
    //{
    //    public DateValidateAttribute()
    //    {
    //    }

    //    //public DateValidateAttribute(string errorMessage) : base(errorMessage)
    //    //{
    //    //}

    //    public DateValidateAttribute([StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string error)
    //        : base()
    //    {
    //    }
    //    public override bool IsValid(object? value)
    //    {
    //        DateTime dateTime = (DateTime)value;

    //        return (dateTime.Date < DateTime.Today ||
    //                 dateTime.Date.DayOfWeek == DayOfWeek.Sunday ||
    //                 dateTime.Date.DayOfWeek == DayOfWeek.Saturday);
    //    }
    //}
}
