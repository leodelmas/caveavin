namespace CaveAVin
{
    partial class FrmApogee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApogee));
            LbxApogee = new ListBox();
            BtnRetour = new Button();
            SuspendLayout();
            // 
            // LbxApogee
            // 
            LbxApogee.FormattingEnabled = true;
            LbxApogee.ItemHeight = 20;
            LbxApogee.Location = new Point(12, 10);
            LbxApogee.Name = "LbxApogee";
            LbxApogee.Size = new Size(262, 204);
            LbxApogee.TabIndex = 0;
            LbxApogee.SelectedIndexChanged += LbxApogee_SelectedIndexChanged;
            // 
            // BtnRetour
            // 
            BtnRetour.Location = new Point(53, 225);
            BtnRetour.Name = "BtnRetour";
            BtnRetour.Size = new Size(176, 29);
            BtnRetour.TabIndex = 1;
            BtnRetour.Text = "Retour";
            BtnRetour.UseVisualStyleBackColor = true;
            BtnRetour.Click += BtnRetour_Click;
            // 
            // FrmApogee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnRetour;
            ClientSize = new Size(289, 268);
            Controls.Add(BtnRetour);
            Controls.Add(LbxApogee);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmApogee";
            Text = "Bouteille(s) à l'apogée";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LbxApogee;
        private Button BtnRetour;
    }
}