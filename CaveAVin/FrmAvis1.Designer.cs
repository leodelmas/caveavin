namespace CaveAVin
{
    partial class FrmAvis1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvis1));
            BtnValider = new Button();
            BtnAnnuler = new Button();
            LblNom = new Label();
            LblMillesime = new Label();
            RtbCommentaire = new RichTextBox();
            PbxEtoile1 = new PictureBox();
            PbxEtoile2 = new PictureBox();
            PbxEtoile3 = new PictureBox();
            PbxEtoile4 = new PictureBox();
            PbxEtoile5 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile5).BeginInit();
            SuspendLayout();
            // 
            // BtnValider
            // 
            BtnValider.Location = new Point(38, 280);
            BtnValider.Name = "BtnValider";
            BtnValider.Size = new Size(159, 29);
            BtnValider.TabIndex = 0;
            BtnValider.Text = "Ok";
            BtnValider.UseVisualStyleBackColor = true;
            BtnValider.Click += BtnValider_Click;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.Location = new Point(255, 280);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(159, 29);
            BtnAnnuler.TabIndex = 1;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // LblNom
            // 
            LblNom.AutoSize = true;
            LblNom.Location = new Point(30, 27);
            LblNom.Name = "LblNom";
            LblNom.Size = new Size(50, 20);
            LblNom.TabIndex = 2;
            LblNom.Text = "label1";
            LblNom.Click += label1_Click;
            // 
            // LblMillesime
            // 
            LblMillesime.AutoSize = true;
            LblMillesime.Location = new Point(30, 67);
            LblMillesime.Name = "LblMillesime";
            LblMillesime.Size = new Size(50, 20);
            LblMillesime.TabIndex = 3;
            LblMillesime.Text = "label2";
            LblMillesime.Click += label2_Click;
            // 
            // RtbCommentaire
            // 
            RtbCommentaire.Location = new Point(26, 184);
            RtbCommentaire.Name = "RtbCommentaire";
            RtbCommentaire.Size = new Size(391, 79);
            RtbCommentaire.TabIndex = 4;
            RtbCommentaire.Text = "";
            // 
            // PbxEtoile1
            // 
            PbxEtoile1.Image = Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile1.Location = new Point(132, 120);
            PbxEtoile1.Name = "PbxEtoile1";
            PbxEtoile1.Size = new Size(36, 37);
            PbxEtoile1.TabIndex = 5;
            PbxEtoile1.TabStop = false;
            PbxEtoile1.Click += pictureBox1_Click;
            // 
            // PbxEtoile2
            // 
            PbxEtoile2.Image = Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile2.Location = new Point(192, 120);
            PbxEtoile2.Name = "PbxEtoile2";
            PbxEtoile2.Size = new Size(36, 37);
            PbxEtoile2.TabIndex = 6;
            PbxEtoile2.TabStop = false;
            PbxEtoile2.Click += PbxEtoile2_Click;
            // 
            // PbxEtoile3
            // 
            PbxEtoile3.Image = Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile3.Location = new Point(248, 120);
            PbxEtoile3.Name = "PbxEtoile3";
            PbxEtoile3.Size = new Size(36, 37);
            PbxEtoile3.TabIndex = 7;
            PbxEtoile3.TabStop = false;
            PbxEtoile3.Click += PbxEtoile3_Click;
            // 
            // PbxEtoile4
            // 
            PbxEtoile4.Image = Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile4.Location = new Point(302, 120);
            PbxEtoile4.Name = "PbxEtoile4";
            PbxEtoile4.Size = new Size(36, 37);
            PbxEtoile4.TabIndex = 8;
            PbxEtoile4.TabStop = false;
            PbxEtoile4.Click += PbxEtoile4_Click;
            // 
            // PbxEtoile5
            // 
            PbxEtoile5.Image = Properties.Resources.icone_etoile_vide_jaune;
            PbxEtoile5.Location = new Point(357, 120);
            PbxEtoile5.Name = "PbxEtoile5";
            PbxEtoile5.Size = new Size(36, 37);
            PbxEtoile5.TabIndex = 9;
            PbxEtoile5.TabStop = false;
            PbxEtoile5.Click += PbxEtoile5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 129);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 10;
            label3.Text = "Avis :";
            label3.Click += label3_Click;
            // 
            // FrmAvis1
            // 
            AcceptButton = BtnValider;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnAnnuler;
            ClientSize = new Size(455, 335);
            Controls.Add(label3);
            Controls.Add(PbxEtoile5);
            Controls.Add(PbxEtoile4);
            Controls.Add(PbxEtoile3);
            Controls.Add(PbxEtoile2);
            Controls.Add(PbxEtoile1);
            Controls.Add(RtbCommentaire);
            Controls.Add(LblMillesime);
            Controls.Add(LblNom);
            Controls.Add(BtnAnnuler);
            Controls.Add(BtnValider);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmAvis1";
            Text = "Avis";
            ((System.ComponentModel.ISupportInitialize)PbxEtoile1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxEtoile5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnValider;
        private Button BtnAnnuler;
        private Label LblNom;
        private Label LblMillesime;
        private RichTextBox RtbCommentaire;
        private PictureBox PbxEtoile1;
        private PictureBox PbxEtoile2;
        private PictureBox PbxEtoile3;
        private PictureBox PbxEtoile4;
        private PictureBox PbxEtoile5;
        private Label label3;
    }
}