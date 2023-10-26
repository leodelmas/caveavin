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
    public partial class FrmAvis1 : Form
    {
        private int noteActuelle = 0;
        public int Id { get; set; }
        public int IdBouteille { get; set; }
        public int IdUtilisateur { get; set; }
        public int Note { get; set; }
        public string Commentaire { get; set; }

        public FrmAvis1(int idBouteille)
        {
            InitializeComponent();
            this.IdBouteille = idBouteille;
            AfficherInfosBouteille(this.IdBouteille);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Gestionnaires d'événements pour les clics sur les étoiles
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MettreAJourEtoiles(1);
        }

        private void PbxEtoile2_Click(object sender, EventArgs e)
        {
            MettreAJourEtoiles(2);
        }

        private void PbxEtoile3_Click(object sender, EventArgs e)
        {
            MettreAJourEtoiles(3);
        }

        private void PbxEtoile4_Click(object sender, EventArgs e)
        {
            MettreAJourEtoiles(4);
        }

        private void PbxEtoile5_Click(object sender, EventArgs e)
        {
            MettreAJourEtoiles(5);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            int idBouteille = IdBouteille;
            int idUtilisateur = InformationsGlobales.UtilisateurConnecte.IdUtilisateur;
            string commentaire = RtbCommentaire.Text;

            EnregistrerAvis(idBouteille, idUtilisateur, noteActuelle, commentaire);
            Close();

        }

        private void MettreAJourEtoiles(int note)
        {
            noteActuelle = note;

            // Mettez à jour chaque étoile en fonction de la note actuelle
            PbxEtoile1.Image = noteActuelle >= 1 ? Properties.Resources.icone_etoile_jaune : Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile2.Image = noteActuelle >= 2 ? Properties.Resources.icone_etoile_jaune : Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile3.Image = noteActuelle >= 3 ? Properties.Resources.icone_etoile_jaune : Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile4.Image = noteActuelle >= 4 ? Properties.Resources.icone_etoile_jaune : Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile5.Image = noteActuelle >= 5 ? Properties.Resources.icone_etoile_jaune : Properties.Resources.icone_etoile_vide_jaune;
        }
        private Bouteille ObtenirBouteilleParId(int id)
        {
            using (var context = new CaveAvinContext())
            {
                return context.Bouteilles.FirstOrDefault(b => b.IdBouteille == id);
            }
        }
        private void AfficherInfosBouteille(int idBouteille)
        {
            Bouteille bouteille = ObtenirBouteilleParId(idBouteille);

            if (bouteille != null)
            {
                LblNom.Text = $"Nom : {bouteille.NomComplet}";
                LblMillesime.Text = $"Millesime : {bouteille.Millesime}";
            }
            else
            {
                LblNom.Text = "Informations non disponibles";
                LblMillesime.Text = "Informations non disponibles";
            }
        }

        private void EnregistrerAvis(int idBouteille, int idUtilisateur, int note, string commentaire)
        {
            using (var context = new CaveAvinContext())
            {
                // Vérifiez si un avis existe déjà pour cette combinaison utilisateur-bouteille
                var avisExistant = context.Avis
                    .FirstOrDefault(a => a.IdBouteille == idBouteille && a.IdUtilisateur == idUtilisateur);

                if (avisExistant != null)
                {
                    MessageBox.Show("Vous avez déjà laissé un avis pour cette bouteille.");
                    return;
                }
                else
                {
                    MessageBox.Show("Avis enregistré avec succès!");
                }

                var avis = new Avi
                {
                    IdBouteille = idBouteille,
                    IdUtilisateur = idUtilisateur,
                    Note = note,
                    Texte = commentaire
                };

                context.Avis.Add(avis);
                context.SaveChanges();
            }
        }


    }
}
