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
    public partial class Sudeste : Form
    {
        public Sudeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sudeste sudeste = new();
            sudeste.Closed += (s, args) => this.Close();
            Hospitais hospitais = new Hospitais();
            hospitais.Show();
        }
    }
}
