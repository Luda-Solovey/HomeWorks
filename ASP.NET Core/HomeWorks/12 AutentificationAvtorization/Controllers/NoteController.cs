using _12_AutentificationAvtorization.DataBase;
using _12_AutentificationAvtorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _12_AutentificationAvtorization.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "User") ]
        public IActionResult AddNote(NoteViewModel model)
        {

            var newNote = new NoteViewModel()
            {
                Id = Guid.NewGuid(),
                Theme = model.Theme,
                Body = model.Body,
                UserName = User.Identity!.Name!

            };
            DataBaseNotes.Notes.Add(newNote);

            //перевіряємо, чи збереглась записка в базі
            if (DataBaseNotes.Notes.Contains(newNote))
            {
                return View("SuccessfulySaved", model);
            }

            return View();//вивести повідомлення, що записка не зберіглася
        }

        [Authorize(Roles = "User")]
        public IActionResult ShowNotes()
        {

            var notes = DataBaseNotes.Notes.Where(n => n.UserName == User.Identity!.Name).ToList();

            return View("ShowNotes", notes);

        }
    }
}
