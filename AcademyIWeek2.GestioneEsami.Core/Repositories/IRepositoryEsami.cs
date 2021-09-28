using AcademyIWeek2.GestioneEsami.Core.Entites;
using AcademyIWeek2.GestioneEsami.Core.Repositories;
using System.Collections.Generic;

namespace AcademyIWeek2.GestioneEsami.Core
{
    public interface IRepositoryEsami : IRepository<Esame>
    {
        Esame CheckExam(string nome);
        void AddExam(Esame esameDaSostenere);
        List<Esame> GetEsamiStudente(int id);
    }
}