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
    public partial class CentroOeste : Form
    {
        public CentroOeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CentroOeste centroOeste = new();
            centroOeste.Closed += (s, args) => this.Close();
            Hospitais hospitais = new Hospitais();
            hospitais.Show();
        }

        private void CentroOeste_Load(object sender, EventArgs e)
        {

        }
    }
}
