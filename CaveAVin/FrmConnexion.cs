using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaveAVin.Models;

namespace CaveAVin
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void LblMotDePasse_Click(object sender, EventArgs e)
        {

        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            // Récupérez les valeurs des TextBox
            string email = TbxAdresseMail.Text;
            string motDePasse = TbxMotDePasse.Text;

            // Vérifiez si les champs sont vides ou nuls
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            using (var context = new CaveAvinContext())
            {
                var utilisateur = context.Utilisateurs.FirstOrDefault(j => j.Email == email);

                if (utilisateur != null)
                {
                    // Pour le moment, nous allons simplement comparer les mots de passe en clair
                    if (utilisateur.MotDePasse == motDePasse)
                    {
                        InformationsGlobales.IdJoueurConnecte = utilisateur.Id;

                        Close();
                        FrmAccueil frmAccueil = new FrmAccueil();
                        frmAccueil.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect.");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun utilisateur avec cet e-mail trouvé.");
                }
            }
        }
    }
}
