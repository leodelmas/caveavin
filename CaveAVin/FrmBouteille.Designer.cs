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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBouteille));
            LblAppellation = new Label();
            LblCouleur = new Label();
            LblEmplacement = new Label();
            LblNumeroTiroir = new Label();
            LblApogee = new Label();
            LblMillesime = new Label();
            LblNomComplet = new Label();
            BtnEnregistrer = new Button();
            TbxNomComplet = new TextBox();
            TbxMillesime = new TextBox();
            TbxAnneeGardeMin = new TextBox();
            label1 = new Label();
            TbxAnneeGardeMax = new TextBox();
            label2 = new Label();
            TbxNumTiroir = new TextBox();
            TbxNumEmplacement = new TextBox();
            CbxIdCouleur = new ComboBox();
            CbxIdAppellation = new ComboBox();
            BtnAnnuler = new Button();
            SuspendLayout();
            // 
            // LblAppellation
            // 
            LblAppellation.AutoSize = true;
            LblAppellation.Location = new Point(22, 224);
            LblAppellation.Name = "LblAppellation";
            LblAppellation.Size = new Size(94, 20);
            LblAppellation.TabIndex = 13;
            LblAppellation.Text = "Appellation :";
            // 
            // LblCouleur
            // 
            LblCouleur.AutoSize = true;
            LblCouleur.Location = new Point(22, 190);
            LblCouleur.Name = "LblCouleur";
            LblCouleur.Size = new Size(67, 20);
            LblCouleur.TabIndex = 12;
            LblCouleur.Text = "Couleur :";
            // 
            // LblEmplacement
            // 
            LblEmplacement.AutoSize = true;
            LblEmplacement.Location = new Point(22, 157);
            LblEmplacement.Name = "LblEmplacement";
            LblEmplacement.Size = new Size(177, 20);
            LblEmplacement.TabIndex = 11;
            LblEmplacement.Text = "Numéro d'emplacement :";
            // 
            // LblNumeroTiroir
            // 
            LblNumeroTiroir.AutoSize = true;
            LblNumeroTiroir.Location = new Point(22, 124);
            LblNumeroTiroir.Name = "LblNumeroTiroir";
            LblNumeroTiroir.Size = new Size(127, 20);
            LblNumeroTiroir.TabIndex = 10;
            LblNumeroTiroir.Text = "Numéro du tiroir :";
            // 
            // LblApogee
            // 
            LblApogee.AutoSize = true;
            LblApogee.Location = new Point(22, 87);
            LblApogee.Name = "LblApogee";
            LblApogee.Size = new Size(107, 20);
            LblApogee.TabIndex = 9;
            LblApogee.Text = "Apogée entre :";
            // 
            // LblMillesime
            // 
            LblMillesime.AutoSize = true;
            LblMillesime.Location = new Point(22, 54);
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
            BtnEnregistrer.Location = new Point(26, 263);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(166, 29);
            BtnEnregistrer.TabIndex = 14;
            BtnEnregistrer.Text = "Enregistrer";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // TbxNomComplet
            // 
            TbxNomComplet.Location = new Point(223, 18);
            TbxNomComplet.Name = "TbxNomComplet";
            TbxNomComplet.PlaceholderText = "Nom";
            TbxNomComplet.Size = new Size(181, 27);
            TbxNomComplet.TabIndex = 0;
            // 
            // TbxMillesime
            // 
            TbxMillesime.Location = new Point(223, 51);
            TbxMillesime.Name = "TbxMillesime";
            TbxMillesime.PlaceholderText = "2008";
            TbxMillesime.Size = new Size(181, 27);
            TbxMillesime.TabIndex = 1;
            // 
            // TbxAnneeGardeMin
            // 
            TbxAnneeGardeMin.Location = new Point(223, 84);
            TbxAnneeGardeMin.Name = "TbxAnneeGardeMin";
            TbxAnneeGardeMin.PlaceholderText = "3";
            TbxAnneeGardeMin.Size = new Size(55, 27);
            TbxAnneeGardeMin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 87);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 18;
            label1.Text = "et";
            // 
            // TbxAnneeGardeMax
            // 
            TbxAnneeGardeMax.Location = new Point(312, 84);
            TbxAnneeGardeMax.Name = "TbxAnneeGardeMax";
            TbxAnneeGardeMax.PlaceholderText = "5";
            TbxAnneeGardeMax.Size = new Size(55, 27);
            TbxAnneeGardeMax.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 87);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 20;
            label2.Text = "ans";
            // 
            // TbxNumTiroir
            // 
            TbxNumTiroir.Location = new Point(223, 121);
            TbxNumTiroir.Name = "TbxNumTiroir";
            TbxNumTiroir.PlaceholderText = "4";
            TbxNumTiroir.Size = new Size(181, 27);
            TbxNumTiroir.TabIndex = 4;
            // 
            // TbxNumEmplacement
            // 
            TbxNumEmplacement.Location = new Point(223, 154);
            TbxNumEmplacement.Name = "TbxNumEmplacement";
            TbxNumEmplacement.PlaceholderText = "3";
            TbxNumEmplacement.Size = new Size(181, 27);
            TbxNumEmplacement.TabIndex = 5;
            // 
            // CbxIdCouleur
            // 
            CbxIdCouleur.FormattingEnabled = true;
            CbxIdCouleur.Location = new Point(223, 187);
            CbxIdCouleur.Name = "CbxIdCouleur";
            CbxIdCouleur.Size = new Size(181, 28);
            CbxIdCouleur.TabIndex = 6;
            // 
            // CbxIdAppellation
            // 
            CbxIdAppellation.FormattingEnabled = true;
            CbxIdAppellation.Location = new Point(223, 221);
            CbxIdAppellation.Name = "CbxIdAppellation";
            CbxIdAppellation.Size = new Size(181, 28);
            CbxIdAppellation.TabIndex = 7;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Location = new Point(223, 263);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(166, 29);
            BtnAnnuler.TabIndex = 27;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // FrmBouteille
            // 
            AcceptButton = BtnEnregistrer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnAnnuler;
            ClientSize = new Size(430, 310);
            Controls.Add(BtnAnnuler);
            Controls.Add(CbxIdAppellation);
            Controls.Add(CbxIdCouleur);
            Controls.Add(TbxNumEmplacement);
            Controls.Add(TbxNumTiroir);
            Controls.Add(label2);
            Controls.Add(TbxAnneeGardeMax);
            Controls.Add(label1);
            Controls.Add(TbxAnneeGardeMin);
            Controls.Add(TbxMillesime);
            Controls.Add(TbxNomComplet);
            Controls.Add(BtnEnregistrer);
            Controls.Add(LblAppellation);
            Controls.Add(LblCouleur);
            Controls.Add(LblEmplacement);
            Controls.Add(LblNumeroTiroir);
            Controls.Add(LblApogee);
            Controls.Add(LblMillesime);
            Controls.Add(LblNomComplet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmBouteille";
            Text = "Gestion d'une bouteille";
            Load += FrmBouteille_Load;
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
        private TextBox TbxNomComplet;
        private TextBox TbxMillesime;
        private TextBox TbxAnneeGardeMin;
        private Label label1;
        private TextBox TbxAnneeGardeMax;
        private Label label2;
        private TextBox TbxNumTiroir;
        private TextBox TbxNumEmplacement;
        private ComboBox CbxIdCouleur;
        private ComboBox CbxIdAppellation;
        private Button BtnAnnuler;
    }
}