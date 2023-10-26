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
    public partial class FrmCave : Form
    {
        private Cave _cave;
        public FrmCave(Cave cave = null)
        {
            InitializeComponent();
            _cave = cave;
        }

        private void FrmCave_Load(object sender, EventArgs e)
        {
            using (var context = new CaveAvinContext())
            {
                // Chargez les fabricants
                var fabricants = context.Fabricants.ToList();
                CbxFabricant.DataSource = fabricants;
                CbxFabricant.DisplayMember = "Nom";
                CbxFabricant.ValueMember = "IdFabricant";

                // Continuez avec le chargement des familles comme précédemment
                var familles = context.Familles.ToList();
                CbxFamille.DataSource = familles;
                CbxFamille.DisplayMember = "Nom";
                CbxFamille.ValueMember = "IdFamille";
            }

            if (_cave != null)
            {
                // contrôles avec les données de _cave
                TbxDesignation.Text = _cave.Designation;
                TbxNombreTiroirs.Text = _cave.NbTiroirs.ToString();
                TbxNombreBouteillesParTiroir.Text = _cave.NbBouteillesParTiroir.ToString();
                TbxTemperature.Text = _cave.TemperatureFonctionnement.ToString();
                CbxFabricant.SelectedValue = _cave.IdFabricant;
                CbxFamille.SelectedValue = _cave.IdFamille;


            }
        }

        private void TbxDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxNombreTiroirs_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxNombreBouteillesParTiroir_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxTemperature_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbxFabricant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxFamille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreer_Click(object sender, EventArgs e)
        {
            {
                using (var context = new CaveAvinContext())
                {
                    if (_cave == null)
                    {
                        _cave = new Cave();
                        context.Caves.Add(_cave);
                    }

                    // Mettez à jour _cave avec les données des contrôles, par exemple:
                    _cave.Designation = TbxDesignation.Text;
                    _cave.NbTiroirs = int.Parse(TbxNombreTiroirs.Text);
                    _cave.NbBouteillesParTiroir = int.Parse(TbxNombreBouteillesParTiroir.Text);
                    _cave.TemperatureFonctionnement = int.Parse(TbxTemperature.Text);
                    _cave.IdFabricant = (int)CbxFabricant.SelectedValue;
                    _cave.IdFamille = (int)CbxFamille.SelectedValue;

                    context.SaveChanges();
                }
                this.Close();
                FrmGestionDesCaves frmGestionDesCaves = new FrmGestionDesCaves();
                frmGestionDesCaves.Show();
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
            FrmGestionDesCaves frmGestionDesCaves = new FrmGestionDesCaves();
            frmGestionDesCaves.Show();
        }
    }
}
