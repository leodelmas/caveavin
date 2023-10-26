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
    public partial class FrmApogee : Form
    {
        public FrmApogee()
        {
            InitializeComponent();
            List<Bouteille> mesBouteilles = null;
            using (var context = new CaveAvinContext())
            {
                // Utilisez une requête LINQ pour récupérer toutes les bouteilles depuis la base de données.
                mesBouteilles = context.Bouteilles.ToList();
            }

            foreach (var bouteille in mesBouteilles)
            {
                if (bouteille.EstApogee())
                {
                    LbxApogee.Items.Add(bouteille); // Affichez le nom de la bouteille (ou d'autres informations pertinentes) dans la ListBox.
                }
            }

            if (LbxApogee.Items.Count == 0)
            {
                LbxApogee.Items.Add("Aucune bouteille à l'apogée n'a été trouvée.");
            }
        }

        private void LbxApogee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
