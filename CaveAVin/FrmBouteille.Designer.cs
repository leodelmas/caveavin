namespace CaveAVin
{
    partial class FrmBouteille
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
            LblAppellation = new Label();
            LblCouleur = new Label();
            LblEmplacement = new Label();
            LblNumeroTiroir = new Label();
            LblApogee = new Label();
            LblMillesime = new Label();
            LblNomComplet = new Label();
            BtnEnregistrer = new Button();
            SuspendLayout();
            // 
            // LblAppellation
            // 
            LblAppellation.AutoSize = true;
            LblAppellation.Location = new Point(22, 217);
            LblAppellation.Name = "LblAppellation";
            LblAppellation.Size = new Size(94, 20);
            LblAppellation.TabIndex = 13;
            LblAppellation.Text = "Appellation :";
            // 
            // LblCouleur
            // 
            LblCouleur.AutoSize = true;
            LblCouleur.Location = new Point(25, 184);
            LblCouleur.Name = "LblCouleur";
            LblCouleur.Size = new Size(67, 20);
            LblCouleur.TabIndex = 12;
            LblCouleur.Text = "Couleur :";
            // 
            // LblEmplacement
            // 
            LblEmplacement.AutoSize = true;
            LblEmplacement.Location = new Point(25, 153);
            LblEmplacement.Name = "LblEmplacement";
            LblEmplacement.Size = new Size(177, 20);
            LblEmplacement.TabIndex = 11;
            LblEmplacement.Text = "Numéro d'emplacement :";
            // 
            // LblNumeroTiroir
            // 
            LblNumeroTiroir.AutoSize = true;
            LblNumeroTiroir.Location = new Point(25, 121);
            LblNumeroTiroir.Name = "LblNumeroTiroir";
            LblNumeroTiroir.Size = new Size(127, 20);
            LblNumeroTiroir.TabIndex = 10;
            LblNumeroTiroir.Text = "Numéro du tiroir :";
            // 
            // LblApogee
            // 
            LblApogee.AutoSize = true;
            LblApogee.Location = new Point(22, 80);
            LblApogee.Name = "LblApogee";
            LblApogee.Size = new Size(69, 20);
            LblApogee.TabIndex = 9;
            LblApogee.Text = "Apogée :";
            // 
            // LblMillesime
            // 
            LblMillesime.AutoSize = true;
            LblMillesime.Location = new Point(22, 50);
            LblMillesime.Name = "LblMillesime";
            LblMillesime.Size = new Size(80, 20);
            LblMillesime.TabIndex = 8;
            LblMillesime.Text = "Millesime :";
            // 
            // LblNomComplet
            // 
            LblNomComplet.AutoSize = true;
            LblNomComplet.Location = new Point(22, 21);
            LblNomComplet.Name = "LblNomComplet";
            LblNomComplet.Size = new Size(108, 20);
            LblNomComplet.TabIndex = 7;
            LblNomComplet.Text = "Nom complet :";
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.Location = new Point(131, 248);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(166, 29);
            BtnEnregistrer.TabIndex = 14;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // FrmBouteille
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 289);
            Controls.Add(BtnEnregistrer);
            Controls.Add(LblAppellation);
            Controls.Add(LblCouleur);
            Controls.Add(LblEmplacement);
            Controls.Add(LblNumeroTiroir);
            Controls.Add(LblApogee);
            Controls.Add(LblMillesime);
            Controls.Add(LblNomComplet);
            Name = "FrmBouteille";
            Text = "FrmAjouterBouteille";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAppellation;
        private Label LblCouleur;
        private Label LblEmplacement;
        private Label LblNumeroTiroir;
        private Label LblApogee;
        private Label LblMillesime;
        private Label LblNomComplet;
        private Button BtnEnregistrer;
    }
}