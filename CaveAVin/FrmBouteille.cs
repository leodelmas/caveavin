using CaveAVin.Models;

namespace CaveAVin
{
    public partial class FrmBouteille : Form
    {
        private Bouteille _bouteille;

        public FrmBouteille(Bouteille? bouteille = null)
        {
            InitializeComponent();
            if (bouteille != null)
            {
                _bouteille = bouteille;
                TbxNomComplet.Text = _bouteille.NomComplet;
                TbxMillesime.Text = _bouteille.Millesime.ToString();
                TbxAnneeGardeMin.Text = _bouteille.AnneeGardeMin.ToString();
                TbxAnneeGardeMax.Text = _bouteille.AnneeGardeMax.ToString();
                TbxNumTiroir.Text = _bouteille.NumTiroir.ToString();
                TbxNumEmplacement.Text = _bouteille.NumEmplacement.ToString();
                // TODO : Cave, Appellation, Couleur
            }
            else
            {
                _bouteille = new Bouteille();
            }
        }

        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                using (CaveAvinContext db = new CaveAvinContext())
                {
                    _bouteille.NomComplet = TbxNomComplet.Text;
                    _bouteille.Millesime = int.Parse(TbxMillesime.Text);
                    _bouteille.AnneeGardeMin = int.Parse(TbxAnneeGardeMin.Text);
                    _bouteille.AnneeGardeMax = int.Parse(TbxAnneeGardeMax.Text);
                    _bouteille.NumTiroir = int.Parse(TbxNumTiroir.Text);
                    _bouteille.NumEmplacement = int.Parse(TbxNumEmplacement.Text);
                    _bouteille.IdCouleur = ((Couleur)CbxIdCouleur.SelectedItem).IdCouleur;
                    _bouteille.IdAppellation = ((Appellation)CbxIdAppellation.SelectedItem).IdAppellation;
                    _bouteille.IdCave = ((Cave)CbxIdCave.SelectedItem).IdCave;


                    if (_bouteille.IdBouteille == 0)
                    {
                        db.Bouteilles.Add(_bouteille);
                    }
                    else
                    {
                        db.Bouteilles.Update(_bouteille);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
