using AcademyIWeek2.GestioneEsami.Core.Entites;
using AcademyIWeek2.GestioneEsami.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Mock
{
    public class RepositoryStudente : IRepositoryStudente
    {
        public static List<Studente> studenti = new List<Studente>();

        public List<Studente> Fetch()
        {
            throw new NotImplementedException();
        }

        public Studente GetByMatricola(int matricola)
        {
            return studenti.FirstOrDefault(s => s._Immatricolazione.Matricola == matricola);
        }

        public void Insert(Studente item)
        {
            if (studenti.Count == 0)
                item.Id = 1;
            else
                item.Id = studenti.Max(s => s.Id) + 1;

            studenti.Add(item);
        }
    }
}
