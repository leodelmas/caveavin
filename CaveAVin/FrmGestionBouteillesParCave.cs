using CaveAVin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmBouteille.Show();
        }

        private void BtnModifierBouteille_Click(object sender, EventArgs e)
        {
            Bouteille bouteille = (Bouteille)LbxBouteilleParCave.SelectedItem;

            if (bouteille == null )
            {
                MessageBox.Show("Aucune bouteille n'a été sélectionnée.");
                return;
            }

            FrmBouteille frmBouteille = new FrmBouteille(bouteille);
            frmBouteille.Show();
        }

        private void BtnSupprimerBouteille_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?", "Êtes-vous sûr ?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (CaveAvinContext db = new CaveAvinContext())
                    {
                        Bouteille bouteille = (Bouteille)LbxBouteilleParCave.SelectedItem;
                        db.Bouteilles.Attach(bouteille);
                        db.Bouteilles.Remove(bouteille);
                        db.SaveChanges();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void BtnAfficherBouteilles_Click(object sender, EventArgs e)
        {

        }

        private void ChargerListe()
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
