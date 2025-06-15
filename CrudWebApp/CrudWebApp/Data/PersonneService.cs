using CrudWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrudWebApp.Data
{
    public class PersonneService
    {
        private static List<Personne> personnes = new List<Personne>();
        private static int nextId = 1;

        public List<Personne> GetAll() => personnes;

        public void Add(Personne p)
        {
            p.Id = nextId++;
            personnes.Add(p);
        }

        public void Update(Personne p)
        {
            var existing = personnes.FirstOrDefault(x => x.Id == p.Id);
            if (existing != null)
            {
                existing.Nom = p.Nom;
                existing.Prenom = p.Prenom;
            }
        }

        public void Delete(int id)
        {
            var p = personnes.FirstOrDefault(x => x.Id == id);
            if (p != null) personnes.Remove(p);
        }
    }
}
