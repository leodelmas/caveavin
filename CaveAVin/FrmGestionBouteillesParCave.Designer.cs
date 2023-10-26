namespace CaveAVin
{
    partial class FrmGestionBouteillesParCave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            BtnSupprimerBouteille = new Button();
            BtnModifierBouteille = new Button();
            BtnAjouterBouteille = new Button();
            BtnAfficherBouteilles = new Button();
            LbxBouteilleParCave = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSupprimerBouteille);
            groupBox1.Controls.Add(BtnModifierBouteille);
            groupBox1.Controls.Add(BtnAjouterBouteille);
            groupBox1.Controls.Add(BtnAfficherBouteilles);
            groupBox1.Controls.Add(LbxBouteilleParCave);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 306);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Liste des bouteilles";
            // 
            // BtnSupprimerBouteille
            // 
            BtnSupprimerBouteille.Location = new Point(184, 131);
            BtnSupprimerBouteille.Name = "BtnSupprimerBouteille";
            BtnSupprimerBouteille.Size = new Size(166, 29);
            BtnSupprimerBouteille.TabIndex = 4;
            BtnSupprimerBouteille.Text = "Supprimer la bouteille";
            BtnSupprimerBouteille.UseVisualStyleBackColor = true;
            BtnSupprimerBouteille.Click += BtnSupprimerBouteille_Click;
            // 
            // BtnModifierBouteille
            // 
            BtnModifierBouteille.Location = new Point(184, 86);
            BtnModifierBouteille.Name = "BtnModifierBouteille";
            BtnModifierBouteille.Size = new Size(166, 29);
            BtnModifierBouteille.TabIndex = 3;
            BtnModifierBouteille.Text = "Modifier la bouteille";
            BtnModifierBouteille.UseVisualStyleBackColor = true;
            BtnModifierBouteille.Click += BtnModifierBouteille_Click;
            // 
            // BtnAjouterBouteille
            // 
            BtnAjouterBouteille.Location = new Point(184, 39);
            BtnAjouterBouteille.Name = "BtnAjouterBouteille";
            BtnAjouterBouteille.Size = new Size(166, 29);
            BtnAjouterBouteille.TabIndex = 2;
            BtnAjouterBouteille.Text = "Ajouter bouteille";
            BtnAjouterBouteille.UseVisualStyleBackColor = true;
            BtnAjouterBouteille.Click += BtnAjouterBouteille_Click;
            // 
            // BtnAfficherBouteilles
            // 
            BtnAfficherBouteilles.Location = new Point(6, 263);
            BtnAfficherBouteilles.Name = "BtnAfficherBouteilles";
            BtnAfficherBouteilles.Size = new Size(344, 29);
            BtnAfficherBouteilles.TabIndex = 1;
            BtnAfficherBouteilles.Text = "Afficher les bouteilles";
            BtnAfficherBouteilles.UseVisualStyleBackColor = true;
            BtnAfficherBouteilles.Click += BtnAfficherBouteilles_Click;
            // 
            // LbxBouteilleParCave
            // 
            LbxBouteilleParCave.FormattingEnabled = true;
            LbxBouteilleParCave.ItemHeight = 20;
            LbxBouteilleParCave.Location = new Point(6, 26);
            LbxBouteilleParCave.Name = "LbxBouteilleParCave";
            LbxBouteilleParCave.Size = new Size(172, 224);
            LbxBouteilleParCave.TabIndex = 0;
            // 
            // FrmGestionBouteillesParCave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 330);
            Controls.Add(groupBox1);
            Name = "FrmGestionBouteillesParCave";
            Text = "FrmGestionBouteillesParCave";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnSupprimerBouteille;
        private Button BtnModifierBouteille;
        private Button BtnAjouterBouteille;
        private Button BtnAfficherBouteilles;
        private ListBox LbxBouteilleParCave;
    }
}