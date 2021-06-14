﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLFILM
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            var myContext = new Context();
            myContext.Database.CreateIfNotExists();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fFilm f = new fFilm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fCategory f = new fCategory();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fDirector f = new fDirector();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fActor f = new fActor();
            f.Show();
        }
    }
}
