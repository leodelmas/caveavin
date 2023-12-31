﻿namespace CaveAVin
{
    partial class FrmConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            LblAdresseMail = new Label();
            LblMotDePasse = new Label();
            TbxAdresseMail = new TextBox();
            TbxMotDePasse = new TextBox();
            BtnConnexion = new Button();
            BtnAnnuler = new Button();
            SuspendLayout();
            // 
            // LblAdresseMail
            // 
            LblAdresseMail.AutoSize = true;
            LblAdresseMail.Location = new Point(46, 26);
            LblAdresseMail.Name = "LblAdresseMail";
            LblAdresseMail.Size = new Size(101, 20);
            LblAdresseMail.TabIndex = 0;
            LblAdresseMail.Text = "Adresse mail :";
            // 
            // LblMotDePasse
            // 
            LblMotDePasse.AutoSize = true;
            LblMotDePasse.Location = new Point(42, 68);
            LblMotDePasse.Name = "LblMotDePasse";
            LblMotDePasse.Size = new Size(105, 20);
            LblMotDePasse.TabIndex = 1;
            LblMotDePasse.Text = "Mot de passe :";
            LblMotDePasse.Click += LblMotDePasse_Click;
            // 
            // TbxAdresseMail
            // 
            TbxAdresseMail.Location = new Point(153, 23);
            TbxAdresseMail.Name = "TbxAdresseMail";
            TbxAdresseMail.PlaceholderText = "utilisateur@domaine.fr";
            TbxAdresseMail.Size = new Size(174, 27);
            TbxAdresseMail.TabIndex = 0;
            TbxAdresseMail.TextChanged += TxbAdresseMail_TextChanged;
            // 
            // TbxMotDePasse
            // 
            TbxMotDePasse.Location = new Point(153, 65);
            TbxMotDePasse.Name = "TbxMotDePasse";
            TbxMotDePasse.PasswordChar = '*';
            TbxMotDePasse.Size = new Size(174, 27);
            TbxMotDePasse.TabIndex = 1;
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(42, 111);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(135, 29);
            BtnConnexion.TabIndex = 4;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Location = new Point(192, 111);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(135, 29);
            BtnAnnuler.TabIndex = 5;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // FrmConnexion
            // 
            AcceptButton = BtnConnexion;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnAnnuler;
            ClientSize = new Size(368, 162);
            Controls.Add(BtnAnnuler);
            Controls.Add(BtnConnexion);
            Controls.Add(TbxMotDePasse);
            Controls.Add(TbxAdresseMail);
            Controls.Add(LblMotDePasse);
            Controls.Add(LblAdresseMail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmConnexion";
            Text = "Connexion";
            Load += FrmConnexion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAdresseMail;
        private Label LblMotDePasse;
        private TextBox TbxAdresseMail;
        private TextBox TbxMotDePasse;
        private Button BtnConnexion;
        private Button BtnAnnuler;
    }
}