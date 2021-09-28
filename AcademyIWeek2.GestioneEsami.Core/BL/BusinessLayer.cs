using AcademyIWeek2.GestioneEsami.Core.Entites;
using AcademyIWeek2.GestioneEsami.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyIWeek2.GestioneEsami.Core
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryCorsi corsiRepo;
        private readonly IRepositoryCorsiDiLaurea corsiDiLaureaRepo;
        private readonly IRepositoryImmatricolazione immatricolazioneRepo;
        private readonly IRepositoryStudente studenteRepo;
        private readonly IRepositoryEsami esamiRepo;
        
        public BusinessLayer(IRepositoryCorsi corsi, IRepositoryCorsiDiLaurea corsiDiLaurea,
            IRepositoryImmatricolazione immatricolazione, IRepositoryStudente studente, IRepositoryEsami esami)
        {
            corsiRepo = corsi;
            corsiDiLaureaRepo = corsiDiLaurea;
            immatricolazioneRepo = immatricolazione;
            studenteRepo = studente;
            esamiRepo = esami;
        }

        public Esame AggiungiEsame(Esame esameDaSostenere)
        {
            esamiRepo.AddExam(esameDaSostenere);
            return esameDaSostenere;
        }

        public Studente CreaImmatricolazione(Studente s, CorsoDiLaurea cdl)
        {
            Immatricolazione imm = new Immatricolazione();
            imm.DataInizio = DateTime.Now;
            imm._CorsoDiLaurea = GetCorsi(cdl);

            int ore = imm.DataInizio.Hour;
            int minuti = imm.DataInizio.Minute;
            var secondi = imm.DataInizio.Second;
            var matricola = String.Concat(ore, minuti, secondi);

            imm.Matricola = Convert.ToInt32(matricola);

            immatricolazioneRepo.Insert(imm);
            imm = immatricolazioneRepo.GetByDate(imm);

            s.IdImmatricolazione = imm.Id;
            s._Immatricolazione = imm;

            studenteRepo.Insert(s);

            return s;
        }

        public List<CorsoDiLaurea> FetchCorsiDiLaurea()
        {
            return corsiDiLaureaRepo.Fetch();
        }

        public CorsoDiLaurea GetCorsi(CorsoDiLaurea cdl)
        {
            List<Corso> corsi = corsiRepo.GetCorsiByCorsoDiLaurea(cdl);
            cdl.Corsi = corsi;
            var cfuTotali = corsi.Sum(c => c.CreditiFormativi);
            cdl.Cfu = cfuTotali;
            return cdl;
        }

        public bool RandomEsamePassato(Esame esameDaSostenere)
        {
            Random random = new Random();
            bool passato = Convert.ToBoolean(random.Next(0, 1));

            return passato;
        }

        public Studente StudentLogin(int matr)
        {
            var studenteEsistente = studenteRepo.GetByMatricola(matr);
            if(studenteEsistente == null)
            {
                return null;
            }
            studenteEsistente.Esami = esamiRepo.GetEsamiStudente(studenteEsistente.Id);

            return studenteEsistente;
        }

        public void UpdateEsamePassato()
        {
            throw new NotImplementedException();
        }

        public bool VerificaCfuPerIscrizioneEsame(Corso corsoScelto, Studente s)
        {
            var cfuOk = s._Immatricolazione.CfuAccumulati + corsoScelto.CreditiFormativi <= s._Immatricolazione._CorsoDiLaurea.Cfu;
            if (cfuOk && !s.LaureaRichiesta)
                return true;
            else
                return false;
        }
    }
}
