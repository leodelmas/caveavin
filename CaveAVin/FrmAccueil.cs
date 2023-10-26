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
    }
}
