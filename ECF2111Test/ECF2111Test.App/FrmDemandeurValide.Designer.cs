namespace ECF2111Test.App
{
    partial class FrmDemandeurValide
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
            this.tbxYearDip = new System.Windows.Forms.TextBox();
            this.tbxDiploma = new System.Windows.Forms.TextBox();
            this.tbxFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLname = new System.Windows.Forms.TextBox();
            this.tbxLevel = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEmp = new System.Windows.Forms.Label();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxYearDip
            // 
            this.tbxYearDip.Location = new System.Drawing.Point(104, 217);
            this.tbxYearDip.Name = "tbxYearDip";
            this.tbxYearDip.ReadOnly = true;
            this.tbxYearDip.Size = new System.Drawing.Size(154, 23);
            this.tbxYearDip.TabIndex = 22;
            // 
            // tbxDiploma
            // 
            this.tbxDiploma.Location = new System.Drawing.Point(104, 173);
            this.tbxDiploma.Name = "tbxDiploma";
            this.tbxDiploma.ReadOnly = true;
            this.tbxDiploma.Size = new System.Drawing.Size(154, 23);
            this.tbxDiploma.TabIndex = 21;
            // 
            // tbxFname
            // 
            this.tbxFname.Location = new System.Drawing.Point(104, 95);
            this.tbxFname.Name = "tbxFname";
            this.tbxFname.ReadOnly = true;
            this.tbxFname.Size = new System.Drawing.Size(154, 23);
            this.tbxFname.TabIndex = 20;
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
            this.label3.Location = new System.Drawing.Point(10, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nom";
            // 
            // tbxLname
            // 
            this.tbxLname.Location = new System.Drawing.Point(104, 56);
            this.tbxLname.Name = "tbxLname";
            this.tbxLname.ReadOnly = true;
            this.tbxLname.Size = new System.Drawing.Size(154, 23);
            this.tbxLname.TabIndex = 14;
            // 
            // tbxLevel
            // 
            this.tbxLevel.Location = new System.Drawing.Point(104, 136);
            this.tbxLevel.Name = "tbxLevel";
            this.tbxLevel.ReadOnly = true;
            this.tbxLevel.Size = new System.Drawing.Size(154, 23);
            this.tbxLevel.TabIndex = 23;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(12, 9);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(63, 25);
            this.labelId.TabIndex = 24;
            this.labelId.Text = "label4";
            // 
            // labelEmp
            // 
            this.labelEmp.AutoSize = true;
            this.labelEmp.Location = new System.Drawing.Point(104, 262);
            this.labelEmp.Name = "labelEmp";
            this.labelEmp.Size = new System.Drawing.Size(38, 15);
            this.labelEmp.TabIndex = 25;
            this.labelEmp.Text = "label4";
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(164, 292);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(94, 23);
            this.btnSaveJson.TabIndex = 26;
            this.btnSaveJson.Text = "Sauvegarder";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // FrmDemandeurValide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 336);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.labelEmp);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.tbxLevel);
            this.Controls.Add(this.tbxYearDip);
            this.Controls.Add(this.tbxDiploma);
            this.Controls.Add(this.tbxFname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxLname);
            this.Name = "FrmDemandeurValide";
            this.Text = "Demander d\'emploi ajouté !";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemandeurValide_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbxYearDip;
        private TextBox tbxDiploma;
        private TextBox tbxFname;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbxLname;
        private TextBox tbxLevel;
        private Label labelId;
        private Label labelEmp;
        private Button btnSaveJson;
    }
}