﻿using AcademyIWeek2.GestioneEsami.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyIWeek2.GestioneEsami.Core.Repositories
{
    public interface IRepositoryImmatricolazione : IRepository<Immatricolazione>
    {
        Immatricolazione GetByDate(Immatricolazione imm);
    }
}
