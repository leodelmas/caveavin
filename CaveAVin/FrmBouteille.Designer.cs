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
            CbxIdCave = new ComboBox();
            label3 = new Label();
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
            BtnEnregistrer.Location = new Point(238, 304);
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
            TbxNomComplet.Size = new Size(181, 27);
            TbxNomComplet.TabIndex = 15;
            // 
            // TbxMillesime
            // 
            TbxMillesime.Location = new Point(223, 51);
            TbxMillesime.Name = "TbxMillesime";
            TbxMillesime.Size = new Size(181, 27);
            TbxMillesime.TabIndex = 16;
            // 
            // TbxAnneeGardeMin
            // 
            TbxAnneeGardeMin.Location = new Point(223, 84);
            TbxAnneeGardeMin.Name = "TbxAnneeGardeMin";
            TbxAnneeGardeMin.Size = new Size(55, 27);
            TbxAnneeGardeMin.TabIndex = 17;
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
            TbxAnneeGardeMax.Size = new Size(55, 27);
            TbxAnneeGardeMax.TabIndex = 19;
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
            TbxNumTiroir.Size = new Size(181, 27);
            TbxNumTiroir.TabIndex = 21;
            // 
            // TbxNumEmplacement
            // 
            TbxNumEmplacement.Location = new Point(223, 154);
            TbxNumEmplacement.Name = "TbxNumEmplacement";
            TbxNumEmplacement.Size = new Size(181, 27);
            TbxNumEmplacement.TabIndex = 22;
            // 
            // CbxIdCouleur
            // 
            CbxIdCouleur.FormattingEnabled = true;
            CbxIdCouleur.Location = new Point(223, 187);
            CbxIdCouleur.Name = "CbxIdCouleur";
            CbxIdCouleur.Size = new Size(181, 28);
            CbxIdCouleur.TabIndex = 23;
            // 
            // CbxIdAppellation
            // 
            CbxIdAppellation.FormattingEnabled = true;
            CbxIdAppellation.Location = new Point(223, 221);
            CbxIdAppellation.Name = "CbxIdAppellation";
            CbxIdAppellation.Size = new Size(181, 28);
            CbxIdAppellation.TabIndex = 24;
            // 
            // CbxIdCave
            // 
            CbxIdCave.FormattingEnabled = true;
            CbxIdCave.Location = new Point(223, 255);
            CbxIdCave.Name = "CbxIdCave";
            CbxIdCave.Size = new Size(181, 28);
            CbxIdCave.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 258);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 26;
            label3.Text = "Cave :";
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Location = new Point(22, 304);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(166, 29);
            BtnAnnuler.TabIndex = 27;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmBouteille
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 352);
            Controls.Add(BtnAnnuler);
            Controls.Add(label3);
            Controls.Add(CbxIdCave);
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
            Name = "FrmBouteille";
            Text = "Gestion d'une bouteille";
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
        private ComboBox CbxIdCave;
        private Label label3;
        private Button BtnAnnuler;
    }
}