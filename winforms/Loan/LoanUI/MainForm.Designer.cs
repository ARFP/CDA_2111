namespace LoanUI
{
    partial class MainForm
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
            this.labelNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxCapital = new System.Windows.Forms.TextBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelDuree = new System.Windows.Forms.Label();
            this.labelNbMois = new System.Windows.Forms.Label();
            this.ScrBarDuree = new System.Windows.Forms.HScrollBar();
            this.gbxInterets = new System.Windows.Forms.GroupBox();
            this.Rb9 = new System.Windows.Forms.RadioButton();
            this.Rb8 = new System.Windows.Forms.RadioButton();
            this.Rb7 = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lbxPeriode = new System.Windows.Forms.ListBox();
            this.labelPeriode = new System.Windows.Forms.Label();
            this.labelNbRb = new System.Windows.Forms.Label();
            this.labelMontantRb = new System.Windows.Forms.Label();
            this.labelRb = new System.Windows.Forms.Label();
            this.gbxInterets.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(78, 38);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(34, 15);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(194, 30);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(154, 23);
            this.tbxNom.TabIndex = 1;
            // 
            // tbxCapital
            // 
            this.tbxCapital.Location = new System.Drawing.Point(194, 77);
            this.tbxCapital.Name = "tbxCapital";
            this.tbxCapital.Size = new System.Drawing.Size(154, 23);
            this.tbxCapital.TabIndex = 2;
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(78, 85);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(99, 15);
            this.labelCapital.TabIndex = 3;
            this.labelCapital.Text = "Capital Emprunté";
            // 
            // labelDuree
            // 
            this.labelDuree.Location = new System.Drawing.Point(28, 149);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(100, 35);
            this.labelDuree.TabIndex = 4;
            this.labelDuree.Text = "Durée en mois du remboursement";
            // 
            // labelNbMois
            // 
            this.labelNbMois.AutoSize = true;
            this.labelNbMois.Location = new System.Drawing.Point(153, 156);
            this.labelNbMois.Name = "labelNbMois";
            this.labelNbMois.Size = new System.Drawing.Size(13, 15);
            this.labelNbMois.TabIndex = 5;
            this.labelNbMois.Text = "0";
            // 
            // ScrBarDuree
            // 
            this.ScrBarDuree.Location = new System.Drawing.Point(194, 149);
            this.ScrBarDuree.Maximum = 369;
            this.ScrBarDuree.Minimum = 1;
            this.ScrBarDuree.Name = "ScrBarDuree";
            this.ScrBarDuree.Size = new System.Drawing.Size(161, 22);
            this.ScrBarDuree.TabIndex = 6;
            this.ScrBarDuree.Value = 1;
            // 
            // gbxInterets
            // 
            this.gbxInterets.Controls.Add(this.Rb9);
            this.gbxInterets.Controls.Add(this.Rb8);
            this.gbxInterets.Controls.Add(this.Rb7);
            this.gbxInterets.Location = new System.Drawing.Point(384, 27);
            this.gbxInterets.Name = "gbxInterets";
            this.gbxInterets.Size = new System.Drawing.Size(100, 144);
            this.gbxInterets.TabIndex = 7;
            this.gbxInterets.TabStop = false;
            this.gbxInterets.Text = "Taux D\'intérêts";
            // 
            // Rb9
            // 
            this.Rb9.AutoSize = true;
            this.Rb9.Location = new System.Drawing.Point(10, 106);
            this.Rb9.Name = "Rb9";
            this.Rb9.Size = new System.Drawing.Size(44, 19);
            this.Rb9.TabIndex = 2;
            this.Rb9.TabStop = true;
            this.Rb9.Tag = "9";
            this.Rb9.Text = "9 %";
            this.Rb9.UseVisualStyleBackColor = true;
            // 
            // Rb8
            // 
            this.Rb8.AutoSize = true;
            this.Rb8.Location = new System.Drawing.Point(10, 67);
            this.Rb8.Name = "Rb8";
            this.Rb8.Size = new System.Drawing.Size(44, 19);
            this.Rb8.TabIndex = 1;
            this.Rb8.TabStop = true;
            this.Rb8.Tag = "8";
            this.Rb8.Text = "8 %";
            this.Rb8.UseVisualStyleBackColor = true;
            // 
            // Rb7
            // 
            this.Rb7.AutoSize = true;
            this.Rb7.Location = new System.Drawing.Point(10, 28);
            this.Rb7.Name = "Rb7";
            this.Rb7.Size = new System.Drawing.Size(44, 19);
            this.Rb7.TabIndex = 0;
            this.Rb7.TabStop = true;
            this.Rb7.Tag = "7";
            this.Rb7.Text = "7 %";
            this.Rb7.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(512, 39);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(512, 94);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // lbxPeriode
            // 
            this.lbxPeriode.FormattingEnabled = true;
            this.lbxPeriode.ItemHeight = 15;
            this.lbxPeriode.Location = new System.Drawing.Point(28, 220);
            this.lbxPeriode.Name = "lbxPeriode";
            this.lbxPeriode.Size = new System.Drawing.Size(163, 79);
            this.lbxPeriode.TabIndex = 10;
            // 
            // labelPeriode
            // 
            this.labelPeriode.AutoSize = true;
            this.labelPeriode.Location = new System.Drawing.Point(28, 202);
            this.labelPeriode.Name = "labelPeriode";
            this.labelPeriode.Size = new System.Drawing.Size(167, 15);
            this.labelPeriode.TabIndex = 11;
            this.labelPeriode.Text = "Périodicité de remboursement";
            // 
            // labelNbRb
            // 
            this.labelNbRb.AutoSize = true;
            this.labelNbRb.Location = new System.Drawing.Point(384, 220);
            this.labelNbRb.Name = "labelNbRb";
            this.labelNbRb.Size = new System.Drawing.Size(13, 15);
            this.labelNbRb.TabIndex = 12;
            this.labelNbRb.Text = "0";
            // 
            // labelMontantRb
            // 
            this.labelMontantRb.AutoSize = true;
            this.labelMontantRb.Location = new System.Drawing.Point(512, 262);
            this.labelMontantRb.Name = "labelMontantRb";
            this.labelMontantRb.Size = new System.Drawing.Size(13, 15);
            this.labelMontantRb.TabIndex = 13;
            this.labelMontantRb.Text = "0";
            // 
            // labelRb
            // 
            this.labelRb.AutoSize = true;
            this.labelRb.Location = new System.Drawing.Point(487, 220);
            this.labelRb.Name = "labelRb";
            this.labelRb.Size = new System.Drawing.Size(100, 15);
            this.labelRb.TabIndex = 14;
            this.labelRb.Text = "Remboursements";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 350);
            this.Controls.Add(this.labelRb);
            this.Controls.Add(this.labelMontantRb);
            this.Controls.Add(this.labelNbRb);
            this.Controls.Add(this.labelPeriode);
            this.Controls.Add(this.lbxPeriode);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbxInterets);
            this.Controls.Add(this.ScrBarDuree);
            this.Controls.Add(this.labelNbMois);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.tbxCapital);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.labelNom);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxInterets.ResumeLayout(false);
            this.gbxInterets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Label labelNom;
        private TextBox tbxNom;
        private TextBox tbxCapital;
        private Label labelCapital;
        private Label labelDuree;
        private Label labelNbMois;
        private HScrollBar ScrBarDuree;
        private GroupBox gbxInterets;
        private RadioButton Rb9;
        private RadioButton Rb8;
        private RadioButton Rb7;
        private Button btnOk;
        private Button btnAnnuler;
        private ListBox lbxPeriode;
        private Label labelPeriode;
        private Label labelNbRb;
        private Label labelMontantRb;
        private Label labelRb;
    }
}