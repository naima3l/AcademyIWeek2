using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Core.Repositories
{
    public interface IRepository<T>
    {
        public List<T> Fetch();
        public void Insert(T Item);
    }
}
