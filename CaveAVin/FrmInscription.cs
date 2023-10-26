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
using System.Security.Cryptography;

namespace CaveAVin
{
    public partial class FrmInscription : Form
    {
        public FrmInscription()
        {
            InitializeComponent();
        }

        private void BtnInscription_Click(object sender, EventArgs e)
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

            // Vérifier l'adresse mail
            if (!EstEmailValide(email))
            {
                MessageBox.Show("L'adresse mail n'est pas au bon format.");
                return;
            }

            using (var context = new CaveAvinContext())
            {
                // Vérifiez si un utilisateur avec le même utilisateur existe déjà
                var utilisateurExistant = context.Utilisateurs.FirstOrDefault(j => j.Email == email);
                if (utilisateurExistant != null)
                {
                    MessageBox.Show("Cet adresse mail est déjà utilisé par un autre utilisateur. Veuillez choisir un autre pseudo.");
                    return;
                }

                // Hasher le mot de passe
                string motDePasseHashed = HasherMotDePasse(motDePasse);

                // Créez un nouvel objet Joueur
                var utilisateur = new Utilisateur
                {
                    Email = email,
                    MotDePasse = motDePasseHashed
                };

                context.Utilisateurs.Add(utilisateur);
                context.SaveChanges();

                Close();
                FrmConnexion frmConnexion = new FrmConnexion();
                frmConnexion.Show();
            }

        }

        private bool EstEmailValide(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
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
