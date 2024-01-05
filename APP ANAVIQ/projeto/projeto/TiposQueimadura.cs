using System;
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
    public partial class TiposQueimadura : Form
    {
        public TiposQueimadura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiposQueimadura tiposQueimadura = new();
            tiposQueimadura.Closed += (s, args) => this.Close();
            QueimaduraFisica queimaduraFisica = new QueimaduraFisica();
            queimaduraFisica.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiposQueimadura tiposQueimadura = new ();
            tiposQueimadura.Closed += (s, args) => this.Close();
            QueimadurasBiologicas queimadurasBiologicas = new QueimadurasBiologicas();
            queimadurasBiologicas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiposQueimadura tiposQueimadura = new();
            tiposQueimadura.Closed += (s, args) => this.Close();
            QueimaduraQuimicas queimaduraQuimicas = new QueimaduraQuimicas();
            queimaduraQuimicas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiposQueimadura tiposQueimadura = new TiposQueimadura();
            tiposQueimadura.Closed += (s, args) => this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
