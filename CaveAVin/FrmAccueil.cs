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
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
            LblUtilisateur.Text = InformationsGlobales.UtilisateurConnecte.Email;
        }

        private void BtnGestionDesCaves_Click(object sender, EventArgs e)
        {
            Close();
            FrmGestionDesCaves frmGestionDesCaves = new FrmGestionDesCaves();
            frmGestionDesCaves.Show();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }

        private void BtnBouteillesApogee_Click(object sender, EventArgs e)
        {
            Close();
            FrmApogee frmApogee = new FrmApogee();
            frmApogee.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            InformationsGlobales.UtilisateurConnecte = null;

            Close();
            FrmCaveAVin frmCaveAVin = new FrmCaveAVin();
            frmCaveAVin.Show();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
