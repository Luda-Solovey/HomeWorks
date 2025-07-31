namespace _12_AutentificationAvtorization.Models
{
    public class NoteViewModel
    {
        public Guid Id { get; set; }
        public string Theme { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty ;
        public string UserName { get; set; } = string.Empty;

        //public UsersViewModel Users { get; set; } розкоментувати, щоб юзер бачив тільки свої нотатки

    }
}
