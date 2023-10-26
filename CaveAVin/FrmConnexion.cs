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
using System.Security.Cryptography;

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
                    // Hasher le mot de passe
                    string motDePasseHashed = HasherMotDePasse(motDePasse);

                    // Comparer les mots de passe
                    if (utilisateur.MotDePasse == motDePasseHashed)
                    {
                        InformationsGlobales.UtilisateurConnecte = utilisateur;

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

        private void TxbAdresseMail_TextChanged(object sender, EventArgs e)
        {

        }
        private string HasherMotDePasse(string motDePasse)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(motDePasse));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
            FrmCaveAVin frmCaveAVin = new FrmCaveAVin();
            frmCaveAVin.Show();
        }
    }
}