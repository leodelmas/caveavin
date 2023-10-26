namespace CaveAVin
{
    partial class FrmInscription
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
            TbxAdresseMail = new TextBox();
            TbxMotDePasse = new TextBox();
            BtnInscription = new Button();
            SuspendLayout();
            // 
            // LblAdresseMail
            // 
            LblAdresseMail.AutoSize = true;
            LblAdresseMail.Location = new Point(37, 53);
            LblAdresseMail.Name = "LblAdresseMail";
            LblAdresseMail.Size = new Size(101, 20);
            LblAdresseMail.TabIndex = 0;
            LblAdresseMail.Text = "Adresse mail :";
            // 
            // LblMotDePasse
            // 
            LblMotDePasse.AutoSize = true;
            LblMotDePasse.Location = new Point(37, 105);
            LblMotDePasse.Name = "LblMotDePasse";
            LblMotDePasse.Size = new Size(105, 20);
            LblMotDePasse.TabIndex = 1;
            LblMotDePasse.Text = "Mot de passe :";
            // 
            // TbxAdresseMail
            // 
            TbxAdresseMail.Location = new Point(167, 53);
            TbxAdresseMail.Name = "TbxAdresseMail";
            TbxAdresseMail.Size = new Size(210, 27);
            TbxAdresseMail.TabIndex = 2;
            // 
            // TbxMotDePasse
            // 
            TbxMotDePasse.Location = new Point(167, 102);
            TbxMotDePasse.Name = "TbxMotDePasse";
            TbxMotDePasse.PasswordChar = '*';
            TbxMotDePasse.Size = new Size(210, 27);
            TbxMotDePasse.TabIndex = 3;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(37, 139);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(340, 29);
            BtnInscription.TabIndex = 4;
            BtnInscription.Text = "Inscription";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // FrmInscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 194);
            Controls.Add(BtnInscription);
            Controls.Add(TbxMotDePasse);
            Controls.Add(TbxAdresseMail);
            Controls.Add(LblMotDePasse);
            Controls.Add(LblAdresseMail);
            Name = "FrmInscription";
            Text = "FrmInscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAdresseMail;
        private Label LblMotDePasse;
        private TextBox TbxAdresseMail;
        private TextBox TbxMotDePasse;
        private Button BtnInscription;
    }
}