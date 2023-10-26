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
            TbxRecherche = new TextBox();
            BtnEffacer = new Button();
            BtnChercher = new Button();
            BtnRetour = new Button();
            BtnSupprimerBouteille = new Button();
            BtnModifierBouteille = new Button();
            BtnAjouterBouteille = new Button();
            LbxBouteilleParCave = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TbxRecherche);
            groupBox1.Controls.Add(BtnEffacer);
            groupBox1.Controls.Add(BtnChercher);
            groupBox1.Controls.Add(BtnRetour);
            groupBox1.Controls.Add(BtnSupprimerBouteille);
            groupBox1.Controls.Add(BtnModifierBouteille);
            groupBox1.Controls.Add(BtnAjouterBouteille);
            groupBox1.Controls.Add(LbxBouteilleParCave);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 297);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Liste des bouteilles";
            // 
            // TbxRecherche
            // 
            TbxRecherche.Location = new Point(347, 133);
            TbxRecherche.Name = "TbxRecherche";
            TbxRecherche.Size = new Size(111, 27);
            TbxRecherche.TabIndex = 8;
            // 
            // BtnEffacer
            // 
            BtnEffacer.Location = new Point(347, 201);
            BtnEffacer.Name = "BtnEffacer";
            BtnEffacer.Size = new Size(111, 29);
            BtnEffacer.TabIndex = 7;
            BtnEffacer.Text = "Effacer";
            BtnEffacer.UseVisualStyleBackColor = true;
            BtnEffacer.Click += BtnEffacer_Click;
            // 
            // BtnChercher
            // 
            BtnChercher.Location = new Point(347, 166);
            BtnChercher.Name = "BtnChercher";
            BtnChercher.Size = new Size(111, 29);
            BtnChercher.TabIndex = 6;
            BtnChercher.Text = "Chercher";
            BtnChercher.UseVisualStyleBackColor = true;
            BtnChercher.Click += BtnChercher_Click;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(236, 256);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(105, 29);
            BtnRetour.TabIndex = 5;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // BtnSupprimerBouteille
            // 
            BtnSupprimerBouteille.Location = new Point(347, 61);
            BtnSupprimerBouteille.Name = "BtnSupprimerBouteille";
            BtnSupprimerBouteille.Size = new Size(111, 29);
            BtnSupprimerBouteille.TabIndex = 4;
            BtnSupprimerBouteille.Text = "Supprimer";
            BtnSupprimerBouteille.UseVisualStyleBackColor = true;
            BtnSupprimerBouteille.Click += BtnSupprimerBouteille_Click;
            // 
            // BtnModifierBouteille
            // 
            BtnModifierBouteille.Location = new Point(347, 26);
            BtnModifierBouteille.Name = "BtnModifierBouteille";
            BtnModifierBouteille.Size = new Size(111, 29);
            BtnModifierBouteille.TabIndex = 3;
            BtnModifierBouteille.Text = "Editer";
            BtnModifierBouteille.UseVisualStyleBackColor = true;
            BtnModifierBouteille.Click += BtnModifierBouteille_Click;
            // 
            // BtnAjouterBouteille
            // 
            BtnAjouterBouteille.Location = new Point(8, 256);
            BtnAjouterBouteille.Name = "BtnAjouterBouteille";
            BtnAjouterBouteille.Size = new Size(105, 29);
            BtnAjouterBouteille.TabIndex = 2;
            BtnAjouterBouteille.Text = "Ajouter";
            BtnAjouterBouteille.UseVisualStyleBackColor = true;
            BtnAjouterBouteille.Click += BtnAjouterBouteille_Click;
            // 
            // LbxBouteilleParCave
            // 
            LbxBouteilleParCave.FormattingEnabled = true;
            LbxBouteilleParCave.ItemHeight = 20;
            LbxBouteilleParCave.Location = new Point(8, 26);
            LbxBouteilleParCave.Name = "LbxBouteilleParCave";
            LbxBouteilleParCave.Size = new Size(333, 204);
            LbxBouteilleParCave.TabIndex = 0;
            // 
            // FrmGestionBouteillesParCave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 324);
            Controls.Add(groupBox1);
            Name = "FrmGestionBouteillesParCave";
            Text = "Gestion des bouteilles";
            Load += FrmGestionBouteillesParCave_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnSupprimerBouteille;
        private Button BtnModifierBouteille;
        private Button BtnAjouterBouteille;
        private ListBox LbxBouteilleParCave;
        private Button BtnRetour;
        private Button BtnEffacer;
        private Button BtnChercher;
        private TextBox TbxRecherche;
    }
}