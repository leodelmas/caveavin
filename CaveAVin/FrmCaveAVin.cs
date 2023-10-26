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
            FrmConnexion frmConnexion = new FrmConnexion();
            frmConnexion.Show();
        }

        private void BtnInscription_Click(object sender, EventArgs e)
        {
            FrmInscription frmInscription = new FrmInscription();
            frmInscription.Show();
        }
    }
}