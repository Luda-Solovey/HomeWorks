using _12_AutentificationAvtorization.Models;

namespace _12_AutentificationAvtorization.DataBase
{
    public static class DataBaseNotes
    {
        public static List<NoteViewModel> Notes { get; set; } = new List<NoteViewModel>()
        {
            new NoteViewModel()
            {
                Id = Guid.NewGuid(),
                Theme = "Test Theme",
                Body = "Test Body"
            }
        };
    }
}
