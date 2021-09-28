using AcademyIWeek2.GestioneEsami.Core;
using AcademyIWeek2.GestioneEsami.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Mock
{
    public class RepositoryEsami : IRepositoryEsami
    {
        public static List<Esame> esami = new List<Esame>();

        public void AddExam(Esame esameDaSostenere)
        {
            esami.Add(esameDaSostenere);
        }

        public Esame CheckExam(string nome)
        {
            var esameEsistente = esami.FirstOrDefault(e => e.Nome == nome);
            if(esameEsistente == null)
            {
                return null;
            }
            return esameEsistente;
        }

        public List<Esame> Fetch()
        {
            throw new NotImplementedException();
        }

        public List<Esame> GetEsamiStudente(int id)
        {
            return esami.Where(e=> e.IdStudente == id).ToList();
        }

        public void Insert(Esame Item)
        {
            throw new NotImplementedException();
        }
    }
}
