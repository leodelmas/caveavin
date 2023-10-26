namespace CaveAVin
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
            LblAdresseMail = new Label();
            LblMotDePasse = new Label();
            TxbAdresseMail = new TextBox();
            TxbMotDePasse = new TextBox();
            BtnConnexion = new Button();
            SuspendLayout();
            // 
            // LblAdresseMail
            // 
            LblAdresseMail.AutoSize = true;
            LblAdresseMail.Location = new Point(63, 47);
            LblAdresseMail.Name = "LblAdresseMail";
            LblAdresseMail.Size = new Size(101, 20);
            LblAdresseMail.TabIndex = 0;
            LblAdresseMail.Text = "Adresse mail :";
            // 
            // LblMotDePasse
            // 
            LblMotDePasse.AutoSize = true;
            LblMotDePasse.Location = new Point(59, 89);
            LblMotDePasse.Name = "LblMotDePasse";
            LblMotDePasse.Size = new Size(105, 20);
            LblMotDePasse.TabIndex = 1;
            LblMotDePasse.Text = "Mot de passe :";
            LblMotDePasse.Click += LblMotDePasse_Click;
            // 
            // TxbAdresseMail
            // 
            TxbAdresseMail.Location = new Point(170, 44);
            TxbAdresseMail.Name = "TxbAdresseMail";
            TxbAdresseMail.Size = new Size(174, 27);
            TxbAdresseMail.TabIndex = 2;
            // 
            // TxbMotDePasse
            // 
            TxbMotDePasse.Location = new Point(170, 86);
            TxbMotDePasse.Name = "TxbMotDePasse";
            TxbMotDePasse.PasswordChar = '*';
            TxbMotDePasse.Size = new Size(174, 27);
            TxbMotDePasse.TabIndex = 3;
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(59, 132);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(285, 29);
            BtnConnexion.TabIndex = 4;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // FrmConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 219);
            Controls.Add(BtnConnexion);
            Controls.Add(TxbMotDePasse);
            Controls.Add(TxbAdresseMail);
            Controls.Add(LblMotDePasse);
            Controls.Add(LblAdresseMail);
            Name = "FrmConnexion";
            Text = "FrmConnexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAdresseMail;
        private Label LblMotDePasse;
        private TextBox TxbAdresseMail;
        private TextBox TxbMotDePasse;
        private Button BtnConnexion;
    }
}