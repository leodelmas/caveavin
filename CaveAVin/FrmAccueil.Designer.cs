namespace CaveAVin
{
    partial class FrmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            BtnGestionDesCaves = new Button();
            BtnBouteillesApogee = new Button();
            GbxGestion = new GroupBox();
            LblUtilisateur = new Label();
            BtnDeconnexion = new Button();
            BtnQuitter = new Button();
            GbxGestion.SuspendLayout();
            SuspendLayout();
            // 
            // BtnGestionDesCaves
            // 
            BtnGestionDesCaves.Location = new Point(20, 35);
            BtnGestionDesCaves.Name = "BtnGestionDesCaves";
            BtnGestionDesCaves.Size = new Size(223, 29);
            BtnGestionDesCaves.TabIndex = 0;
            BtnGestionDesCaves.Text = "Gestion des caves";
            BtnGestionDesCaves.UseVisualStyleBackColor = true;
            BtnGestionDesCaves.Click += BtnGestionDesCaves_Click;
            // 
            // BtnBouteillesApogee
            // 
            BtnBouteillesApogee.Location = new Point(20, 80);
            BtnBouteillesApogee.Name = "BtnBouteillesApogee";
            BtnBouteillesApogee.Size = new Size(223, 29);
            BtnBouteillesApogee.TabIndex = 1;
            BtnBouteillesApogee.Text = "Mes bouteilles à l'apogée";
            BtnBouteillesApogee.UseVisualStyleBackColor = true;
            BtnBouteillesApogee.Click += BtnBouteillesApogee_Click;
            // 
            // GbxGestion
            // 
            GbxGestion.Controls.Add(BtnGestionDesCaves);
            GbxGestion.Controls.Add(BtnBouteillesApogee);
            GbxGestion.Location = new Point(14, 52);
            GbxGestion.Name = "GbxGestion";
            GbxGestion.Size = new Size(267, 126);
            GbxGestion.TabIndex = 3;
            GbxGestion.TabStop = false;
            GbxGestion.Text = "Gestion";
            // 
            // LblUtilisateur
            // 
            LblUtilisateur.AutoSize = true;
            LblUtilisateur.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblUtilisateur.Location = new Point(14, 15);
            LblUtilisateur.Name = "LblUtilisateur";
            LblUtilisateur.Size = new Size(0, 18);
            LblUtilisateur.TabIndex = 4;
            LblUtilisateur.Tag = "";
            // 
            // BtnDeconnexion
            // 
            BtnDeconnexion.Location = new Point(14, 184);
            BtnDeconnexion.Name = "BtnDeconnexion";
            BtnDeconnexion.Size = new Size(121, 31);
            BtnDeconnexion.TabIndex = 5;
            BtnDeconnexion.Text = "Déconnexion";
            BtnDeconnexion.UseVisualStyleBackColor = true;
            BtnDeconnexion.Click += BtnDeconnexion_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Location = new Point(160, 184);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(121, 31);
            BtnQuitter.TabIndex = 6;
            BtnQuitter.Text = "Quitter";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // FrmAccueil
            // 
            AcceptButton = BtnGestionDesCaves;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnDeconnexion;
            ClientSize = new Size(291, 227);
            Controls.Add(BtnQuitter);
            Controls.Add(BtnDeconnexion);
            Controls.Add(LblUtilisateur);
            Controls.Add(GbxGestion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAccueil";
            Text = "Logiciel de gestion de cave à vin";
            GbxGestion.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGestionDesCaves;
        private Button BtnBouteillesApogee;
        private GroupBox GbxGestion;
        private Label LblUtilisateur;
        private Button BtnDeconnexion;
        private Button BtnQuitter;
    }
}