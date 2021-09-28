using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Core.Entites
{
    //    • Nome     -> string
    //• Cognome   -> string
    //• AnnoDiNascita ->int
    //• Immatricolazione  -> definita di un' altra classe
    //• Esami   ->   List<Corsi>
    //• RichiestaLaurea  -> bool

    public class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita { get; set; }
        public Immatricolazione _Immatricolazione { get; set; }
        public bool LaureaRichiesta { get; set; }
        public int IdImmatricolazione { get; set; }
        public List<Esame> Esami { get; set; }

        public Studente()
        {

        }

        public Studente(string nome, string cognome, int annoNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoNascita;
        }
    }
}
