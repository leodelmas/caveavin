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
    public partial class FrmGestionDesCaves : Form
    {
        public FrmGestionDesCaves()
        {
            InitializeComponent();
            this.Load += FrmGestionDesCaves_Load;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjouterCave_Click(object sender, EventArgs e)
        {
            Close();
            FrmCave frmCave = new FrmCave();
            frmCave.Show();
        }

        private void BtnModifierCave_Click(object sender, EventArgs e)
        {
            var caveSelectionnee = LbxCavesAVin.SelectedItem as Cave;
            if (caveSelectionnee == null)
            {
                MessageBox.Show("Veuillez sélectionner une cave à modifier.");
                return;
            }

            Close();
            FrmCave frmCave = new FrmCave(caveSelectionnee);
            frmCave.Show();
        }

        private void BtnSupprimerCave_Click(object sender, EventArgs e)
        {
            var caveSelectionnee = LbxCavesAVin.SelectedItem as Cave;

            if (caveSelectionnee == null)
            {
                MessageBox.Show("Veuillez sélectionner une cave à supprimer.");
                return;
            }

            DialogResult confirmation = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette cave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                using (var context = new CaveAvinContext())
                {
                    context.Caves.Remove(caveSelectionnee);
                    context.SaveChanges();
                }

                // Rafraîchir la liste
                FrmGestionDesCaves_Load(sender, e);
            }
        }

        private void BtnAfficherBouteilles_Click(object sender, EventArgs e)
        {
            var caveSelectionnee = LbxCavesAVin.SelectedItem as Cave;
            InformationsGlobales.CaveCourante = caveSelectionnee;
            FrmGestionBouteillesParCave frmGestionBouteilles = new FrmGestionBouteillesParCave();
            frmGestionBouteilles.Show();
        }

        private void FrmGestionDesCaves_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new CaveAvinContext())
                {
                    LbxCavesAVin.DataSource = context.Caves.ToList();
                    LbxCavesAVin.DisplayMember = "designation";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            FrmAccueil frmAccueil = new FrmAccueil();
            frmAccueil.Show();
        }
    }
}
