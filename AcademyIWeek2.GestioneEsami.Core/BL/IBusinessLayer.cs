using AcademyIWeek2.GestioneEsami.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Core
{
    public interface IBusinessLayer
    {
        List<CorsoDiLaurea> FetchCorsiDiLaurea();
        CorsoDiLaurea GetCorsi(CorsoDiLaurea cdl);
        Studente CreaImmatricolazione(Studente s, CorsoDiLaurea cdl);
        bool VerificaCfuPerIscrizioneEsame(Corso corsoScelto, Studente s);
        Studente StudentLogin(int matr);
        Esame AggiungiEsame(Esame esameDaSostenere);
        bool RandomEsamePassato(Esame esameDaSostenere);
        void UpdateEsamePassato();
    }
}
