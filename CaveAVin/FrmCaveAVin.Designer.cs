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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaveAVin));
            BtnConnexion = new Button();
            BtnInscription = new Button();
            LblAppli = new Label();
            BtnQuitter = new Button();
            SuspendLayout();
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(12, 64);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(117, 29);
            BtnConnexion.TabIndex = 0;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(153, 64);
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
            LblAppli.Font = new Font("Bahnschrift SemiCondensed", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LblAppli.Location = new Point(25, 10);
            LblAppli.Name = "LblAppli";
            LblAppli.Size = new Size(234, 30);
            LblAppli.TabIndex = 2;
            LblAppli.Text = "Gestion de cave à Vins";
            LblAppli.Click += label1_Click;
            // 
            // BtnQuitter
            // 
            BtnQuitter.Location = new Point(28, 120);
            BtnQuitter.Name = "BtnQuitter";
            BtnQuitter.Size = new Size(219, 32);
            BtnQuitter.TabIndex = 3;
            BtnQuitter.Text = "Quitter l'application";
            BtnQuitter.UseVisualStyleBackColor = true;
            BtnQuitter.Click += BtnQuitter_Click;
            // 
            // FrmCaveAVin
            // 
            AcceptButton = BtnConnexion;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            CancelButton = BtnQuitter;
            ClientSize = new Size(285, 163);
            Controls.Add(BtnQuitter);
            Controls.Add(LblAppli);
            Controls.Add(BtnInscription);
            Controls.Add(BtnConnexion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmCaveAVin";
            Text = "Cave à vin";
            Load += FrmCaveAVin_Load;
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