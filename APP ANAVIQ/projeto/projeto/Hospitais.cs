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
    public partial class Hospitais : Form
    {
        public Hospitais()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospitais hospitais = new Hospitais();
            hospitais.Closed += (s, args) => this.Close();
            Sudeste sudeste = new Sudeste();
            sudeste.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospitais hospitais = new Hospitais();
            hospitais.Closed += (s, args) => this.Close();
            CentroOeste centroOeste = new CentroOeste();
            centroOeste.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospitais hospitais = new Hospitais();
            hospitais.Closed += (s, args) => this.Close();
            Nordeste nordeste = new Nordeste();
            nordeste.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospitais hospitais = new Hospitais();
            hospitais.Closed += (s, args) => this.Close();
            Sul sul = new Sul();
            sul.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospitais hospitais = new Hospitais();
            hospitais.Closed += (s, args) => this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Hospitais_Load(object sender, EventArgs e)
        {

        }
    }
}
