﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class PrimeirosSocorros : Form
    {
        public PrimeirosSocorros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            PrimeirosSocorros primeirosSocorross = new PrimeirosSocorros();
            primeirosSocorross.Closed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
