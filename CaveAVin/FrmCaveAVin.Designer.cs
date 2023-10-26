namespace CaveAVin
{
    partial class FrmCaveAVin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnConnexion = new Button();
            BtnInscription = new Button();
            LblAppli = new Label();
            BtnQuitter = new Button();
            SuspendLayout();
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(35, 79);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(117, 29);
            BtnConnexion.TabIndex = 0;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(265, 79);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(112, 29);
            BtnInscription.TabIndex = 1;
            BtnInscription.Text = "Inscription";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // LblAppli
            // 
            LblAppli.AutoSize = true;
            LblAppli.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LblAppli.Location = new Point(1, 9);
            LblAppli.Name = "LblAppli";
            LblAppli.Size = new Size(418, 35);
            LblAppli.TabIndex = 2;
            LblAppli.Text = "Application gestion de cave à Vins";
            LblAppli.Click += label1_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Location = new Point(120, 136);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(176, 32);
            BtnQuitter.TabIndex = 3;
            BtnQuitter.Text = "Quitter l'application";
            BtnQuitter.UseVisualStyleBackColor = true;
            // 
            // FrmCaveAVin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 193);
            Controls.Add(BtnQuitter);
            Controls.Add(LblAppli);
            Controls.Add(BtnInscription);
            Controls.Add(BtnConnexion);
            Name = "FrmCaveAVin";
            Text = "Cave à vin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConnexion;
        private Button BtnInscription;
        private Label LblAppli;
        private Button BtnQuitter;
    }
}