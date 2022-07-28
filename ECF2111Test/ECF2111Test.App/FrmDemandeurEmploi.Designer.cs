namespace ECF2111Test.App
{
    partial class FrmDemandeurEmploi
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.cbxLevel = new System.Windows.Forms.ComboBox();
            this.tbxYearDip = new System.Windows.Forms.TextBox();
            this.tbxDiploma = new System.Windows.Forms.TextBox();
            this.tbxFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(183, 246);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 10;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // cbxLevel
            // 
            this.cbxLevel.FormattingEnabled = true;
            this.cbxLevel.Location = new System.Drawing.Point(104, 136);
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Size = new System.Drawing.Size(154, 23);
            this.cbxLevel.TabIndex = 3;
            // 
            // tbxYearDip
            // 
            this.tbxYearDip.Location = new System.Drawing.Point(104, 217);
            this.tbxYearDip.Name = "tbxYearDip";
            this.tbxYearDip.Size = new System.Drawing.Size(154, 23);
            this.tbxYearDip.TabIndex = 5;
            // 
            // tbxDiploma
            // 
            this.tbxDiploma.Location = new System.Drawing.Point(104, 173);
            this.tbxDiploma.Name = "tbxDiploma";
            this.tbxDiploma.Size = new System.Drawing.Size(154, 23);
            this.tbxDiploma.TabIndex = 4;
            // 
            // tbxFname
            // 
            this.tbxFname.Location = new System.Drawing.Point(104, 51);
            this.tbxFname.Name = "tbxFname";
            this.tbxFname.Size = new System.Drawing.Size(154, 23);
            this.tbxFname.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Année diplôme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Diplôme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom";
            // 
            // tbxLname
            // 
            this.tbxLname.Location = new System.Drawing.Point(104, 12);
            this.tbxLname.Name = "tbxLname";
            this.tbxLname.Size = new System.Drawing.Size(154, 23);
            this.tbxLname.TabIndex = 1;
            // 
            // FrmDemandeurEmploi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 286);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.cbxLevel);
            this.Controls.Add(this.tbxYearDip);
            this.Controls.Add(this.tbxDiploma);
            this.Controls.Add(this.tbxFname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxLname);
            this.Name = "FrmDemandeurEmploi";
            this.Text = "TotoIsBack";
            this.Load += new System.EventHandler(this.TotoIsBack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnValidate;
        private ComboBox cbxLevel;
        private TextBox tbxYearDip;
        private TextBox tbxDiploma;
        private TextBox tbxFname;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxLname;
    }
}