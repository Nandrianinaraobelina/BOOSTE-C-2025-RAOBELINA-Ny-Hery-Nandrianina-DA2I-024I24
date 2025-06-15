using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrudWebApp.Models;
using System.Linq;

namespace CrudWebApp.Pages.Personnes
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Personne Personne { get; set; }

        public IActionResult OnGet(int id)
        {
            var personnes = IndexModel._personnes;
            Personne = personnes.FirstOrDefault(p => p.Id == id);
            if (Personne == null)
                return RedirectToPage("Index");
            return Page();
        }

        public IActionResult OnPost()
        {
            var personnes = IndexModel._personnes;
            var p = personnes.FirstOrDefault(x => x.Id == Personne.Id);
            if (p != null)
                personnes.Remove(p);
            return RedirectToPage("Index");
        }
    }
}
