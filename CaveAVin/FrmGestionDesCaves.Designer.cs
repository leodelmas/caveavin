﻿namespace CaveAVin
{
    partial class FrmGestionDesCaves
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
            LbxCavesAVin = new ListBox();
            BtnAfficherBouteilles = new Button();
            BtnAjouterCave = new Button();
            BtnModifierCave = new Button();
            BtnSupprimerCave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnSupprimerCave);
            groupBox1.Controls.Add(BtnModifierCave);
            groupBox1.Controls.Add(BtnAjouterCave);
            groupBox1.Controls.Add(BtnAfficherBouteilles);
            groupBox1.Controls.Add(LbxCavesAVin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Liste des caves à vin";
            // 
            // LbxCavesAVin
            // 
            LbxCavesAVin.FormattingEnabled = true;
            LbxCavesAVin.ItemHeight = 20;
            LbxCavesAVin.Location = new Point(6, 26);
            LbxCavesAVin.Name = "LbxCavesAVin";
            LbxCavesAVin.Size = new Size(172, 224);
            LbxCavesAVin.TabIndex = 0;
            LbxCavesAVin.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BtnAfficherBouteilles
            // 
            BtnAfficherBouteilles.Location = new Point(6, 263);
            BtnAfficherBouteilles.Name = "BtnAfficherBouteilles";
            BtnAfficherBouteilles.Size = new Size(327, 29);
            BtnAfficherBouteilles.TabIndex = 1;
            BtnAfficherBouteilles.Text = "Afficher les bouteilles";
            BtnAfficherBouteilles.UseVisualStyleBackColor = true;
            // 
            // BtnAjouterCave
            // 
            BtnAjouterCave.Location = new Point(184, 39);
            BtnAjouterCave.Name = "BtnAjouterCave";
            BtnAjouterCave.Size = new Size(149, 29);
            BtnAjouterCave.TabIndex = 2;
            BtnAjouterCave.Text = "Ajouter une cave";
            BtnAjouterCave.UseVisualStyleBackColor = true;
            // 
            // BtnModifierCave
            // 
            BtnModifierCave.Location = new Point(184, 86);
            BtnModifierCave.Name = "BtnModifierCave";
            BtnModifierCave.Size = new Size(149, 29);
            BtnModifierCave.TabIndex = 3;
            BtnModifierCave.Text = "Modifier la cave";
            BtnModifierCave.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimerCave
            // 
            BtnSupprimerCave.Location = new Point(184, 131);
            BtnSupprimerCave.Name = "BtnSupprimerCave";
            BtnSupprimerCave.Size = new Size(149, 29);
            BtnSupprimerCave.TabIndex = 4;
            BtnSupprimerCave.Text = "Supprimer la cave";
            BtnSupprimerCave.UseVisualStyleBackColor = true;
            // 
            // FrmGestionDesCaves
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 339);
            Controls.Add(groupBox1);
            Name = "FrmGestionDesCaves";
            Text = "FrmGestionDesCaves";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox LbxCavesAVin;
        private Button BtnAfficherBouteilles;
        private Button BtnSupprimerCave;
        private Button BtnModifierCave;
        private Button BtnAjouterCave;
    }
}