namespace projeto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://anaviq.org.br");
        }

        private void TQ_Click(object sender, EventArgs e)
        {
            TiposQueimadura tiposDeQueimadura = new TiposQueimadura();
            tiposDeQueimadura.Show();
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            tiposDeQueimadura.Show();
        }

        private void EQ_Click(object sender, EventArgs e)
        {
            EviteQueimaduras eviteQueimaduras = new EviteQueimaduras();
            eviteQueimaduras.Show();
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            eviteQueimaduras.Show();
        }

        private void HA_Click(object sender, EventArgs e)
        {
            Hospitais hospitais = new Hospitais();
            hospitais.Show();
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            hospitais.Show();
        }

        private void PS_Click(object sender, EventArgs e)
        {
            PrimeirosSocorros primeirosSocorros = new PrimeirosSocorros();
            primeirosSocorros.Show();
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            primeirosSocorros.Show();
        }

        private void TT_Click(object sender, EventArgs e)
        {
            TiposTratamento tiposTratamento = new TiposTratamento();
            tiposTratamento.Show();
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            tiposTratamento.Show();
        }

        private void CRED_Click(object sender, EventArgs e)
        {
            CRED cred = new CRED();
            cred.Show();
            this.Hide();
            Menu menu = new Menu();
            menu.Closed += (s, args) => this.Close();
            cred.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://anaviq.org.br");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}