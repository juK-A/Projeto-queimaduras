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
    public partial class CRED : Form
    {
        public CRED()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRED cred = new CRED();
            cred.Closed += (s, args) => this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void CRED_Load(object sender, EventArgs e)
        {

        }
    }
}
