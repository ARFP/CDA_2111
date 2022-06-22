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
            this.labelName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCapital = new System.Windows.Forms.TextBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.gbxInterests = new System.Windows.Forms.GroupBox();
            this.Rb9 = new System.Windows.Forms.RadioButton();
            this.Rb8 = new System.Windows.Forms.RadioButton();
            this.Rb7 = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelNbRp = new System.Windows.Forms.Label();
            this.labelAmountRp = new System.Windows.Forms.Label();
            this.labelRp = new System.Windows.Forms.Label();
            this.periodUserControl1 = new LoanUI.UserControls.PeriodUserControl();
            this.gbxInterests.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(78, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nom";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(194, 30);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(154, 23);
            this.tbxName.TabIndex = 1;
            // 
            // tbxCapital
            // 
            this.tbxCapital.Location = new System.Drawing.Point(194, 77);
            this.tbxCapital.Name = "tbxCapital";
            this.tbxCapital.Size = new System.Drawing.Size(154, 23);
            this.tbxCapital.TabIndex = 2;
            this.tbxCapital.TextChanged += new System.EventHandler(this.tbxCapital_TextChanged);
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
            // gbxInterests
            // 
            this.gbxInterests.Controls.Add(this.Rb9);
            this.gbxInterests.Controls.Add(this.Rb8);
            this.gbxInterests.Controls.Add(this.Rb7);
            this.gbxInterests.Location = new System.Drawing.Point(384, 27);
            this.gbxInterests.Name = "gbxInterests";
            this.gbxInterests.Size = new System.Drawing.Size(100, 144);
            this.gbxInterests.TabIndex = 7;
            this.gbxInterests.TabStop = false;
            this.gbxInterests.Text = "Taux D\'intérêts";
            // 
            // Rb9
            // 
            this.Rb9.AutoSize = true;
            this.Rb9.Location = new System.Drawing.Point(10, 106);
            this.Rb9.Name = "Rb9";
            this.Rb9.Size = new System.Drawing.Size(44, 19);
            this.Rb9.TabIndex = 2;
            this.Rb9.TabStop = true;
            this.Rb9.Tag = "0,09";
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
            this.Rb8.Tag = "0,08";
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
            this.Rb7.Tag = "0,07";
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(512, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // labelNbRp
            // 
            this.labelNbRp.AutoSize = true;
            this.labelNbRp.Location = new System.Drawing.Point(384, 220);
            this.labelNbRp.Name = "labelNbRp";
            this.labelNbRp.Size = new System.Drawing.Size(13, 15);
            this.labelNbRp.TabIndex = 12;
            this.labelNbRp.Text = "0";
            // 
            // labelAmountRp
            // 
            this.labelAmountRp.AutoSize = true;
            this.labelAmountRp.Location = new System.Drawing.Point(512, 262);
            this.labelAmountRp.Name = "labelAmountRp";
            this.labelAmountRp.Size = new System.Drawing.Size(13, 15);
            this.labelAmountRp.TabIndex = 13;
            this.labelAmountRp.Text = "0";
            // 
            // labelRp
            // 
            this.labelRp.AutoSize = true;
            this.labelRp.Location = new System.Drawing.Point(487, 220);
            this.labelRp.Name = "labelRp";
            this.labelRp.Size = new System.Drawing.Size(100, 15);
            this.labelRp.TabIndex = 14;
            this.labelRp.Text = "Remboursements";
            // 
            // periodUserControl1
            // 
            this.periodUserControl1.Location = new System.Drawing.Point(12, 146);
            this.periodUserControl1.Name = "periodUserControl1";
            this.periodUserControl1.Size = new System.Drawing.Size(245, 162);
            this.periodUserControl1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 350);
            this.Controls.Add(this.periodUserControl1);
            this.Controls.Add(this.labelRp);
            this.Controls.Add(this.labelAmountRp);
            this.Controls.Add(this.labelNbRp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbxInterests);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.tbxCapital);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.labelName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxInterests.ResumeLayout(false);
            this.gbxInterests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Label labelName;
        private TextBox tbxName;
        private TextBox tbxCapital;
        private Label labelCapital;
        private GroupBox gbxInterests;
        private RadioButton Rb9;
        private RadioButton Rb8;
        private RadioButton Rb7;
        private Button btnOk;
        private Button btnCancel;
        private Label labelNbRp;
        private Label labelAmountRp;
        private Label labelRp;
        private UserControls.PeriodUserControl periodUserControl1;
    }
}