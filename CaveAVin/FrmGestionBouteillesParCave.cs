using CaveAVin.Models;
using System.Data;

namespace CaveAVin
{
    public partial class FrmGestionBouteillesParCave : Form
    {
        public FrmGestionBouteillesParCave()
        {
            InitializeComponent();
        }

        private void BtnAjouterBouteille_Click(object sender, EventArgs e)
        {
            FrmBouteille frmBouteille = new FrmBouteille();
            frmBouteille.ShowDialog();
            ChargerListe();
        }

        private void BtnModifierBouteille_Click(object sender, EventArgs e)
        {
            Bouteille bouteille = (Bouteille)LbxBouteilleParCave.SelectedItem;

            if (bouteille == null)
            {
                MessageBox.Show("Aucune bouteille n'a été sélectionnée.");
                return;
            }

            FrmBouteille frmBouteille = new FrmBouteille(bouteille);
            frmBouteille.ShowDialog();
            ChargerListe();
        }

        private void BtnSupprimerBouteille_Click(object sender, EventArgs e)
        {
            Bouteille bouteille = (Bouteille)LbxBouteilleParCave.SelectedItem;

            if (bouteille == null)
            {
                MessageBox.Show("Aucune bouteille n'a été sélectionnée.");
                return;
            }

            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?", "Êtes-vous sûr ?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (CaveAvinContext db = new CaveAvinContext())
                    {
                        db.Bouteilles.Attach(bouteille);
                        db.Bouteilles.Remove(bouteille);
                        db.SaveChanges();
                    }
                    ChargerListe();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void FrmGestionBouteillesParCave_Load(object sender, EventArgs e)
        {
            ChargerListe();
        }

        private void ChargerListe()
        {
            try
            {
                LbxBouteilleParCave.DataSource = null;
                LbxBouteilleParCave.Items.Clear();
                using (var db = new CaveAvinContext())
                {
                    LbxBouteilleParCave.DataSource = db.Bouteilles.Where(b => b.IdCave == InformationsGlobales.CaveCourante.IdCave).ToList();
                    LbxBouteilleParCave.DisplayMember = "NomComplet";
                    LbxBouteilleParCave.ValueMember = "IdBouteille";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
