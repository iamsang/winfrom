﻿using QLFILM.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLFILM.BUS
{
    class BUSActor
    {
        DAOActor daoActor;
        public BUSActor()
        {
            daoActor = new DAOActor();
        }
        public void ShowActor(DataGridView dg)
        {
            dg.DataSource = daoActor.GetActor();
        }
    }
}
