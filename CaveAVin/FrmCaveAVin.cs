namespace CaveAVin
{
    public partial class FrmCaveAVin : Form
    {
        public FrmCaveAVin()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            Hide();
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.Show();
        }

        private void BtnInscription_Click(object sender, EventArgs e)
        {
            Hide();
            FrmInscription frmInscription = new FrmInscription();
            frmInscription.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}