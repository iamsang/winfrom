﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLFILM.DAO
{
    class DAODirector
    {
        Context db;
        public DAODirector()
        {
            db = new Context();
        }
        public dynamic GetDirector()
        {
            return db.Directors.Select(s => new {
                s.DID,
                s.DirectorName
            }).ToList();
        }
    }
}
