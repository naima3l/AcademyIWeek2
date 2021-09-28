using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Core.Entites
{
    public class Corso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CreditiFormativi { get; set; }
        public int IdCorsoDiLaurea { get; set; }

        public string Print()
        {
            return $"{Nome} per {CreditiFormativi} cfu";
        }
    }

    // CdL -> Matematica
    // AnniC -> 3
    // CFU -> Somma dei corsi 30 + 40 +30 = 100

    // Corsi
    // Nome -> Geometria        - Analisi matematica             - Logica
    // Cfu -> 30                -  40                            - 30

    // Cdl -> lettere
    // Anni C -> 3
    // CFU -> 25 + 10 + 32

    // Corsi
    // Nome -> Storia Greca     - Storia Latina                - Grammatica
    // Cfu -> 25                -  10                           - 32
}
