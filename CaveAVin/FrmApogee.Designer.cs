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
            LbxApogee = new ListBox();
            SuspendLayout();
            // 
            // LbxApogee
            // 
            LbxApogee.FormattingEnabled = true;
            LbxApogee.ItemHeight = 20;
            LbxApogee.Location = new Point(12, 10);
            LbxApogee.Name = "LbxApogee";
            LbxApogee.Size = new Size(262, 244);
            LbxApogee.TabIndex = 0;
            LbxApogee.SelectedIndexChanged += LbxApogee_SelectedIndexChanged;
            // 
            // FrmApogee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 280);
            Controls.Add(LbxApogee);
            Name = "FrmApogee";
            Text = "Bouteille(s) à l'apogée";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LbxApogee;
    }
}