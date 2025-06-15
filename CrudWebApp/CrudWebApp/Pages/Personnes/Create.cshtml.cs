using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrudWebApp.Models;

namespace CrudWebApp.Pages.Personnes
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Personne Personne { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var personnes = IndexModel._personnes;
            Personne.Id = personnes.Count > 0 ? personnes[^1].Id + 1 : 1;
            personnes.Add(Personne);
            TempData["Notification"] = "Personne ajoutée avec succès !";
            return RedirectToPage("Index");
        }
    }
}
