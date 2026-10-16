namespace PocitackaHezci
{
    public partial class PocitackaHezci : Form
    {
        public PocitackaHezci()
        {
            InitializeComponent();
        }

        private void btnSoucet_Click(object sender, EventArgs e)
        {
            txtVysledek.Text = Vypocti.Soucet(txtA.Text, txtB.Text);
        }

        private void btnRozdil_Click(object sender, EventArgs e)
        {
            txtVysledek.Text = Vypocti.Rozdil(txtA.Text, txtB.Text);
        }


        private void btnSoucin_Click(object sender, EventArgs e)
        {
            txtVysledek.Text = Vypocti.Soucin(txtA.Text, txtB.Text);
        }

        private void btnDeleni_Click(object sender, EventArgs e)
        {
            txtVysledek.Text = Vypocti.Deleni(txtA.Text, txtB.Text);
        }
    }
}
