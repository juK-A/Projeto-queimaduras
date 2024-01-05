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
    public partial class EviteQueimaduras : Form
    {
        public EviteQueimaduras()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            EviteQueimaduras eviteQueimaduras = new EviteQueimaduras();
            eviteQueimaduras.Closed += (s, args) => this.Close();
            menu.Show();
        }

        private void EviteQueimaduras_Load(object sender, EventArgs e)
        {

        }
    }
}
