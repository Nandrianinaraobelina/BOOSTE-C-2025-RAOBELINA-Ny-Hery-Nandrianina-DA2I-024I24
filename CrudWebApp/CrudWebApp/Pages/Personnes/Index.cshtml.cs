using Microsoft.AspNetCore.Mvc.RazorPages;
using CrudWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrudWebApp.Pages.Personnes
{
    public class IndexModel : PageModel
    {
        public static List<Personne> _personnes = new List<Personne>();
        public List<Personne> Personnes => _personnes;

        public void OnGet()
        {
        }
    }
}
