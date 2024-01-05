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
    public partial class Nordeste1 : Form
    {
        public Nordeste1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nordeste1 nordeste1 = new();
            nordeste1.Closed += (s, args) => this.Close();
            Nordeste nordeste = new Nordeste();
            nordeste.Show();
        }

        private void Nordeste1_Load(object sender, EventArgs e)
        {

        }
    }
}
