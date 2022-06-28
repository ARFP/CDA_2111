namespace DemoMdiContainer.Apps
{
    partial class FrmDefilement
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
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBleu = new System.Windows.Forms.Label();
            this.hsbRedValue = new System.Windows.Forms.HScrollBar();
            this.hsbGreenValue = new System.Windows.Forms.HScrollBar();
            this.hsbBlueValue = new System.Windows.Forms.HScrollBar();
            this.lblResultColor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numRedValue = new System.Windows.Forms.NumericUpDown();
            this.numGreenValue = new System.Windows.Forms.NumericUpDown();
            this.numBlueValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numRedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(578, 110);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(100, 23);
            this.lblRed.TabIndex = 0;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(578, 174);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(100, 23);
            this.lblGreen.TabIndex = 1;
            // 
            // lblBleu
            // 
            this.lblBleu.BackColor = System.Drawing.Color.Blue;
            this.lblBleu.Location = new System.Drawing.Point(578, 243);
            this.lblBleu.Name = "lblBleu";
            this.lblBleu.Size = new System.Drawing.Size(100, 23);
            this.lblBleu.TabIndex = 2;
            // 
            // hsbRedValue
            // 
            this.hsbRedValue.Location = new System.Drawing.Point(246, 116);
            this.hsbRedValue.Maximum = 264;
            this.hsbRedValue.Name = "hsbRedValue";
            this.hsbRedValue.Size = new System.Drawing.Size(138, 17);
            this.hsbRedValue.TabIndex = 3;
            this.hsbRedValue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorValueChanged);
            // 
            // hsbGreenValue
            // 
            this.hsbGreenValue.Location = new System.Drawing.Point(246, 174);
            this.hsbGreenValue.Maximum = 264;
            this.hsbGreenValue.Name = "hsbGreenValue";
            this.hsbGreenValue.Size = new System.Drawing.Size(138, 21);
            this.hsbGreenValue.TabIndex = 4;
            // 
            // hsbBlueValue
            // 
            this.hsbBlueValue.Location = new System.Drawing.Point(246, 247);
            this.hsbBlueValue.Maximum = 264;
            this.hsbBlueValue.Name = "hsbBlueValue";
            this.hsbBlueValue.Size = new System.Drawing.Size(138, 17);
            this.hsbBlueValue.TabIndex = 5;
            // 
            // lblResultColor
            // 
            this.lblResultColor.BackColor = System.Drawing.Color.Black;
            this.lblResultColor.Location = new System.Drawing.Point(202, 330);
            this.lblResultColor.Name = "lblResultColor";
            this.lblResultColor.Size = new System.Drawing.Size(379, 99);
            this.lblResultColor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(152, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rouge";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(152, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vert";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(152, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bleu";
            // 
            // numRedValue
            // 
            this.numRedValue.Location = new System.Drawing.Point(430, 108);
            this.numRedValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRedValue.Name = "numRedValue";
            this.numRedValue.Size = new System.Drawing.Size(120, 23);
            this.numRedValue.TabIndex = 10;
            this.numRedValue.ValueChanged += new System.EventHandler(this.ColorValueChanged);
            // 
            // numGreenValue
            // 
            this.numGreenValue.Location = new System.Drawing.Point(430, 172);
            this.numGreenValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreenValue.Name = "numGreenValue";
            this.numGreenValue.Size = new System.Drawing.Size(120, 23);
            this.numGreenValue.TabIndex = 11;
            // 
            // numBlueValue
            // 
            this.numBlueValue.Location = new System.Drawing.Point(430, 241);
            this.numBlueValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlueValue.Name = "numBlueValue";
            this.numBlueValue.Size = new System.Drawing.Size(120, 23);
            this.numBlueValue.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numBlueValue);
            this.Controls.Add(this.numGreenValue);
            this.Controls.Add(this.numRedValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblResultColor);
            this.Controls.Add(this.hsbBlueValue);
            this.Controls.Add(this.hsbGreenValue);
            this.Controls.Add(this.hsbRedValue);
            this.Controls.Add(this.lblBleu);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Name = "Form1";
            this.Text = "Vert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblRed;
        private Label lblGreen;
        private Label lblBleu;
        private HScrollBar hsbRedValue;
        private HScrollBar hsbGreenValue;
        private HScrollBar hsbBlueValue;
        private Label lblResultColor;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numRedValue;
        private NumericUpDown numGreenValue;
        private NumericUpDown numBlueValue;
    }
}