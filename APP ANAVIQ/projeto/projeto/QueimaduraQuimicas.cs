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
    public partial class QueimaduraQuimicas : Form
    {
        public QueimaduraQuimicas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            QueimaduraQuimicas queimaduraQuimicas = new();
            queimaduraQuimicas.Closed += (s, args) => this.Close();
            TiposQueimadura tiposQueimadura = new TiposQueimadura();
            tiposQueimadura.Show();
        }
    }
}
