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
    public partial class QueimadurasBiologicas : Form
    {
        public QueimadurasBiologicas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QueimadurasBiologicas queimadurasBiologicas = new();
            queimadurasBiologicas.Closed += (s, args) => this.Close();
            TiposQueimadura tiposQueimadura = new TiposQueimadura();
            tiposQueimadura.Show();

        }

        private void QueimadurasBiologicas_Load(object sender, EventArgs e)
        {

        }
    }
}
