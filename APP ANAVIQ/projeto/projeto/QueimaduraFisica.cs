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
    public partial class QueimaduraFisica : Form
    {
        public QueimaduraFisica()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueimaduraFisica queimaduraFisica = new();
            queimaduraFisica.Closed += (s, args) => this.Close();
            TiposQueimadura tiposQueimadura = new TiposQueimadura();
            tiposQueimadura.Show();
        }
    }
}
