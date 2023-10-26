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

            // Valider le mot de passe
            if (!ValiderMotDePasse(motDePasse))
            {
                MessageBox.Show("Le mot de passe ne respecte pas les critères de sécurité.");
                return;
            }

            using (var context = new CaveAvinContext())
            {
                // Vérifiez si un utilisateur avec le même utilisateur existe déjà
                var utilisateurExistant = context.Utilisateurs.FirstOrDefault(u => u.Email == email);
                if (utilisateurExistant != null)
                {
                    MessageBox.Show("Cet adresse mail est déjà utilisé par un autre utilisateur. Veuillez choisir un autre email.");
                    return;
                }

                // Générez un sel aléatoire pour renforcer la sécurité du mot de passe
                byte[] sel = GenererSelAleatoire(16);

                // Hachez le mot de passe avec le sel
                string motDePasseHache = HasherMotDePasse(motDePasse, sel);

                // Créez un nouvel objet Utilisateur
                var utilisateur = new Utilisateur
                {
                    Email = email,
                    MotDePasse = motDePasseHache,
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

        private string HasherMotDePasse(string motDePasse, byte[] sel)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Combinez le mot de passe et le sel.
                byte[] motDePasseBytes = Encoding.UTF8.GetBytes(motDePasse);
                byte[] motDePasseSel = new byte[motDePasseBytes.Length + sel.Length];
                Array.Copy(motDePasseBytes, motDePasseSel, motDePasseBytes.Length);
                Array.Copy(sel, 0, motDePasseSel, motDePasseBytes.Length, sel.Length);

                // Hachez le mot de passe combiné avec le sel.
                byte[] hashBytes = sha256.ComputeHash(motDePasseSel);

                // Convertissez le résultat en une chaîne hexadécimale.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
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
        private bool ValiderMotDePasse(string motDePasse)
        {
            // Assurez-vous que le mot de passe a un nombre minimum de caractères.
            if (motDePasse.Length < 8)
            {
                return false;
            }

            // Assurez-vous que le mot de passe contient au moins un caractère spécial.
            if (!motDePasse.Any(char.IsPunctuation))
            {
                return false;
            }

            return true;
        }

        private byte[] GenererSelAleatoire(int longueur)
        {
            // Créez un générateur de nombres aléatoires.
            Random random = new Random();

            // Créez un tableau d'octets pour stocker le sel.
            byte[] sel = new byte[longueur];

            // Remplissez le tableau avec des octets aléatoires.
            random.NextBytes(sel);

            return sel;
        }

    }
}
