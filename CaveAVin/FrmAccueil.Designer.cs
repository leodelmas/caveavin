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
            BtnExporter = new Button();
            SuspendLayout();
            // 
            // BtnGestionDesCaves
            // 
            BtnGestionDesCaves.Location = new Point(32, 42);
            BtnGestionDesCaves.Name = "BtnGestionDesCaves";
            BtnGestionDesCaves.Size = new Size(157, 29);
            BtnGestionDesCaves.TabIndex = 0;
            BtnGestionDesCaves.Text = "Gestion des caves";
            BtnGestionDesCaves.UseVisualStyleBackColor = true;
            // 
            // BtnBouteillesApogee
            // 
            BtnBouteillesApogee.Location = new Point(212, 42);
            BtnBouteillesApogee.Name = "BtnBouteillesApogee";
            BtnBouteillesApogee.Size = new Size(223, 29);
            BtnBouteillesApogee.TabIndex = 1;
            BtnBouteillesApogee.Text = "Mes bouteilles à l'apogée";
            BtnBouteillesApogee.UseVisualStyleBackColor = true;
            BtnBouteillesApogee.Click += BtnBouteillesApogee_Click;
            // 
            // BtnExporter
            // 
            BtnExporter.Location = new Point(457, 42);
            BtnExporter.Name = "BtnExporter";
            BtnExporter.Size = new Size(193, 29);
            BtnExporter.TabIndex = 2;
            BtnExporter.Text = "Exportation des données";
            BtnExporter.UseVisualStyleBackColor = true;
            BtnExporter.Click += BtnExporter_Click;
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 112);
            Controls.Add(BtnExporter);
            Controls.Add(BtnBouteillesApogee);
            Controls.Add(BtnGestionDesCaves);
            Name = "FrmAccueil";
            Text = "Logiciel de gestion de cave à vin";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGestionDesCaves;
        private Button BtnBouteillesApogee;
        private Button BtnExporter;
    }
}