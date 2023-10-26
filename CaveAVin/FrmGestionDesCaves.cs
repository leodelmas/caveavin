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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new CaveAvinContext())
            {
                LbxCavesAVin.DataSource = context.Caves.ToList();
                LbxCavesAVin.DisplayMember = "designation";
            }
        }

        private void BtnAjouterCave_Click(object sender, EventArgs e)
        {
            Close();
            FrmCave frmCave = new FrmCave();
            frmCave.Show();
        }

        private void BtnModifierCave_Click(object sender, EventArgs e)
        {

        }

        private void BtnSupprimerCave_Click(object sender, EventArgs e)
        {
            var caveSelectionnee = LbxCavesAVin.SelectedItem as Cave;

            if (caveSelectionnee == null)
            {
                MessageBox.Show("Veuillez sélectionner une cave à supprimer.");
                return;
            }

            using (var context = new CaveAvinContext())
            {
                context.Caves.Remove(caveSelectionnee);
                context.SaveChanges();
            }

            // Rafraîchir la liste
            listBox1_SelectedIndexChanged(sender, e);
        }

        private void BtnAfficherBouteilles_Click(object sender, EventArgs e)
        {

        }

    }
}
