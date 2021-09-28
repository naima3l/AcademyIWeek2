using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Core.Entites
{
    //    Nome,   -> enum
    //AnniDiCorso,  -> int
    //i cfu per ottenere la laurea e -> int
    //una lista di corsi associati.- un altra classe

    public class CorsoDiLaurea
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnniDiCorso { get; set; }
        public int? Cfu { get; set; }
        public List<Corso> Corsi { get; set; }

        public string Print()
        {
            return $"{Nome} dura {AnniDiCorso} anni";
        }
    }
}
