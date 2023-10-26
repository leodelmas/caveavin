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
            BtnGestionDesCaves = new Button();
            BtnBouteillesApogee = new Button();
            BtnExport = new Button();
            SuspendLayout();
            // 
            // BtnGestionDesCaves
            // 
            BtnGestionDesCaves.Location = new Point(32, 29);
            BtnGestionDesCaves.Name = "BtnGestionDesCaves";
            BtnGestionDesCaves.Size = new Size(223, 29);
            BtnGestionDesCaves.TabIndex = 0;
            BtnGestionDesCaves.Text = "Gestion des caves";
            BtnGestionDesCaves.UseVisualStyleBackColor = true;
            BtnGestionDesCaves.Click += BtnGestionDesCaves_Click;
            // 
            // BtnBouteillesApogee
            // 
            BtnBouteillesApogee.Location = new Point(32, 87);
            BtnBouteillesApogee.Name = "BtnBouteillesApogee";
            BtnBouteillesApogee.Size = new Size(223, 29);
            BtnBouteillesApogee.TabIndex = 1;
            BtnBouteillesApogee.Text = "Mes bouteilles à l'apogée";
            BtnBouteillesApogee.UseVisualStyleBackColor = true;
            // 
            // BtnExport
            // 
            BtnExport.Location = new Point(32, 141);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(223, 29);
            BtnExport.TabIndex = 2;
            BtnExport.Text = "Exportation des données";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 209);
            Controls.Add(BtnExport);
            Controls.Add(BtnBouteillesApogee);
            Controls.Add(BtnGestionDesCaves);
            Name = "FrmAccueil";
            Text = "Logiciel de gestion de cave à vin";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGestionDesCaves;
        private Button BtnBouteillesApogee;
        private Button BtnExport;
    }
}