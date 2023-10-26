using CaveAVin.Models;

namespace CaveAVin
{
    public partial class FrmBouteille : Form
    {
        private Bouteille _bouteille;

        public FrmBouteille(Bouteille bouteille = null)
        {
            InitializeComponent();
            _bouteille = bouteille;
        }

        private void FrmBouteille_Load(object sender, EventArgs e)
        {
            // Complétion des champs externes
            try
            {
                using (CaveAvinContext db = new CaveAvinContext())
                {
                    var couleurs = db.Couleurs.ToList();
                    CbxIdCouleur.DataSource = couleurs;
                    CbxIdCouleur.DisplayMember = "Nom";
                    CbxIdCouleur.ValueMember = "IdCouleur";
                    var appellations = db.Appellations.ToList();
                    CbxIdAppellation.DataSource = appellations;
                    CbxIdAppellation.DisplayMember = "Nom";
                    CbxIdAppellation.ValueMember = "IdAppellation";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            // Bouteille existante
            if (_bouteille != null)
            {
                TbxNomComplet.Text = _bouteille.NomComplet;
                TbxMillesime.Text = _bouteille.Millesime.ToString();
                TbxAnneeGardeMin.Text = _bouteille.AnneeGardeMin.ToString();
                TbxAnneeGardeMax.Text = _bouteille.AnneeGardeMax.ToString();
                TbxNumTiroir.Text = _bouteille.NumTiroir.ToString();
                TbxNumEmplacement.Text = _bouteille.NumEmplacement.ToString();
                CbxIdCouleur.SelectedItem = _bouteille.IdCouleur;
                CbxIdAppellation.SelectedItem = _bouteille.IdAppellationNavigation;
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
                    int numTiroir = int.Parse(TbxNumTiroir.Text);
                    int numEmplacement = int.Parse(TbxNumEmplacement.Text);

                    // Vérifiez si un emplacement dans le même tiroir est déjà occupé.
                    var bouteilleExistante = db.Bouteilles
                        .FirstOrDefault(b => b.NumTiroir == numTiroir && b.NumEmplacement == numEmplacement);

                    if (bouteilleExistante != null && (bouteilleExistante.IdBouteille != _bouteille.IdBouteille))
                    {
                        MessageBox.Show("L'emplacement dans ce tiroir est déjà occupé.");
                        return;
                    }

                    _bouteille.NomComplet = TbxNomComplet.Text;
                    _bouteille.Millesime = int.Parse(TbxMillesime.Text);
                    _bouteille.AnneeGardeMin = int.Parse(TbxAnneeGardeMin.Text);
                    _bouteille.AnneeGardeMax = int.Parse(TbxAnneeGardeMax.Text);
                    _bouteille.NumTiroir = numTiroir;
                    _bouteille.NumEmplacement = numEmplacement;
                    _bouteille.IdCouleur = ((Couleur)CbxIdCouleur.SelectedItem).IdCouleur;
                    _bouteille.IdAppellation = ((Appellation)CbxIdAppellation.SelectedItem).IdAppellation;
                    _bouteille.IdCave = InformationsGlobales.CaveCourante.IdCave;

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
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
