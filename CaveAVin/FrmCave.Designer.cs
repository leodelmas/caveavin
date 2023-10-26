namespace CaveAVin
{
    partial class FrmCave
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
            LblDesignation = new Label();
            LblNombreTiroirs = new Label();
            LblBouteilleParTiroir = new Label();
            LblTemperature = new Label();
            LblFabricant = new Label();
            LblFamille = new Label();
            CbxFamille = new ComboBox();
            CbxFabricant = new ComboBox();
            TbxTemperature = new TextBox();
            LblDegres = new Label();
            TbxNombreBouteillesParTiroir = new TextBox();
            TbxNombreTiroirs = new TextBox();
            TbxDesignation = new TextBox();
            BtnCreer = new Button();
            BtnAnnuler = new Button();
            SuspendLayout();
            // 
            // LblDesignation
            // 
            LblDesignation.AutoSize = true;
            LblDesignation.Location = new Point(12, 9);
            LblDesignation.Name = "LblDesignation";
            LblDesignation.Size = new Size(96, 20);
            LblDesignation.TabIndex = 0;
            LblDesignation.Text = "Désignation :";
            // 
            // LblNombreTiroirs
            // 
            LblNombreTiroirs.AutoSize = true;
            LblNombreTiroirs.Location = new Point(12, 43);
            LblNombreTiroirs.Name = "LblNombreTiroirs";
            LblNombreTiroirs.Size = new Size(134, 20);
            LblNombreTiroirs.TabIndex = 1;
            LblNombreTiroirs.Text = "Nombre de tiroirs :";
            // 
            // LblBouteilleParTiroir
            // 
            LblBouteilleParTiroir.AutoSize = true;
            LblBouteilleParTiroir.Location = new Point(12, 78);
            LblBouteilleParTiroir.Name = "LblBouteilleParTiroir";
            LblBouteilleParTiroir.Size = new Size(223, 20);
            LblBouteilleParTiroir.TabIndex = 2;
            LblBouteilleParTiroir.Text = "Nombre de bouteilles par tiroir :";
            // 
            // LblTemperature
            // 
            LblTemperature.AutoSize = true;
            LblTemperature.Location = new Point(12, 118);
            LblTemperature.Name = "LblTemperature";
            LblTemperature.Size = new Size(230, 20);
            LblTemperature.TabIndex = 3;
            LblTemperature.Text = "Température de fonctionnement :";
            // 
            // LblFabricant
            // 
            LblFabricant.AutoSize = true;
            LblFabricant.Location = new Point(12, 149);
            LblFabricant.Name = "LblFabricant";
            LblFabricant.Size = new Size(76, 20);
            LblFabricant.TabIndex = 4;
            LblFabricant.Text = "Fabricant :";
            // 
            // LblFamille
            // 
            LblFamille.AutoSize = true;
            LblFamille.Location = new Point(12, 182);
            LblFamille.Name = "LblFamille";
            LblFamille.Size = new Size(63, 20);
            LblFamille.TabIndex = 5;
            LblFamille.Text = "Famille :";
            // 
            // CbxFamille
            // 
            CbxFamille.FormattingEnabled = true;
            CbxFamille.Location = new Point(91, 182);
            CbxFamille.Name = "CbxFamille";
            CbxFamille.Size = new Size(151, 28);
            CbxFamille.TabIndex = 6;
            CbxFamille.SelectedIndexChanged += CbxFamille_SelectedIndexChanged;
            // 
            // CbxFabricant
            // 
            CbxFabricant.FormattingEnabled = true;
            CbxFabricant.Location = new Point(91, 146);
            CbxFabricant.Name = "CbxFabricant";
            CbxFabricant.Size = new Size(151, 28);
            CbxFabricant.TabIndex = 7;
            CbxFabricant.SelectedIndexChanged += CbxFabricant_SelectedIndexChanged;
            // 
            // TbxTemperature
            // 
            TbxTemperature.Location = new Point(248, 118);
            TbxTemperature.Name = "TbxTemperature";
            TbxTemperature.Size = new Size(58, 27);
            TbxTemperature.TabIndex = 8;
            TbxTemperature.TextChanged += TbxTemperature_TextChanged;
            // 
            // LblDegres
            // 
            LblDegres.AutoSize = true;
            LblDegres.Location = new Point(312, 121);
            LblDegres.Name = "LblDegres";
            LblDegres.Size = new Size(65, 20);
            LblDegres.TabIndex = 9;
            LblDegres.Text = "° Celcius";
            // 
            // TbxNombreBouteillesParTiroir
            // 
            TbxNombreBouteillesParTiroir.Location = new Point(241, 78);
            TbxNombreBouteillesParTiroir.Name = "TbxNombreBouteillesParTiroir";
            TbxNombreBouteillesParTiroir.Size = new Size(88, 27);
            TbxNombreBouteillesParTiroir.TabIndex = 10;
            TbxNombreBouteillesParTiroir.TextChanged += TbxNombreBouteillesParTiroir_TextChanged;
            // 
            // TbxNombreTiroirs
            // 
            TbxNombreTiroirs.Location = new Point(152, 40);
            TbxNombreTiroirs.Name = "TbxNombreTiroirs";
            TbxNombreTiroirs.Size = new Size(125, 27);
            TbxNombreTiroirs.TabIndex = 11;
            TbxNombreTiroirs.TextChanged += TbxNombreTiroirs_TextChanged;
            // 
            // TbxDesignation
            // 
            TbxDesignation.Location = new Point(117, 9);
            TbxDesignation.Name = "TbxDesignation";
            TbxDesignation.Size = new Size(125, 27);
            TbxDesignation.TabIndex = 12;
            TbxDesignation.TextChanged += TbxDesignation_TextChanged;
            // 
            // BtnCreer
            // 
            BtnCreer.Location = new Point(52, 227);
            BtnCreer.Name = "BtnCreer";
            BtnCreer.Size = new Size(94, 29);
            BtnCreer.TabIndex = 13;
            BtnCreer.Text = "Créer";
            BtnCreer.UseVisualStyleBackColor = true;
            BtnCreer.Click += BtnCreer_Click;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Location = new Point(235, 227);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(94, 29);
            BtnAnnuler.TabIndex = 14;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // FrmCave
            // 
            AcceptButton = BtnCreer;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 268);
            Controls.Add(BtnAnnuler);
            Controls.Add(BtnCreer);
            Controls.Add(TbxDesignation);
            Controls.Add(TbxNombreTiroirs);
            Controls.Add(TbxNombreBouteillesParTiroir);
            Controls.Add(LblDegres);
            Controls.Add(TbxTemperature);
            Controls.Add(CbxFabricant);
            Controls.Add(CbxFamille);
            Controls.Add(LblFamille);
            Controls.Add(LblFabricant);
            Controls.Add(LblTemperature);
            Controls.Add(LblBouteilleParTiroir);
            Controls.Add(LblNombreTiroirs);
            Controls.Add(LblDesignation);
            Name = "FrmCave";
            Text = "Ajouter/Modifier une cave";
            Load += FrmCave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblDesignation;
        private Label LblNombreTiroirs;
        private Label LblBouteilleParTiroir;
        private Label LblTemperature;
        private Label LblFabricant;
        private Label LblFamille;
        private ComboBox CbxFamille;
        private ComboBox CbxFabricant;
        private TextBox TbxTemperature;
        private Label LblDegres;
        private TextBox TbxNombreBouteillesParTiroir;
        private TextBox TbxNombreTiroirs;
        private TextBox TbxDesignation;
        private Button BtnCreer;
        private Button BtnAnnuler;
    }
}