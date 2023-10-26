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
            SuspendLayout();
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(31, 145);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(117, 29);
            BtnConnexion.TabIndex = 0;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(265, 145);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(112, 29);
            BtnInscription.TabIndex = 1;
            BtnInscription.Text = "Inscription";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // FrmCaveAVin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 213);
            Controls.Add(BtnInscription);
            Controls.Add(BtnConnexion);
            Name = "FrmCaveAVin";
            Text = "Cave à vin";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnConnexion;
        private Button BtnInscription;
    }
}