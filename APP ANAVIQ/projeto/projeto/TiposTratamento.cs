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
    public partial class TiposTratamento : Form
    {
        public TiposTratamento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiposTratamento tiposTratamento = new TiposTratamento();
            tiposTratamento.Closed += (s, args) => this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void TiposTratamento_Load(object sender, EventArgs e)
        {

        }
    }
}
