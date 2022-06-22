namespace LoanUI.UserControls
{
    partial class PeriodUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sbNbMonths = new System.Windows.Forms.HScrollBar();
            this.lbPeriodicity = new System.Windows.Forms.ListBox();
            this.labelNbMonths = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sbNbMonths
            // 
            this.sbNbMonths.Location = new System.Drawing.Point(77, 11);
            this.sbNbMonths.Name = "sbNbMonths";
            this.sbNbMonths.Size = new System.Drawing.Size(148, 17);
            this.sbNbMonths.TabIndex = 0;
            this.sbNbMonths.ValueChanged += new System.EventHandler(this.sbNbMonths_ValueChanged);
            // 
            // lbPeriodicity
            // 
            this.lbPeriodicity.FormattingEnabled = true;
            this.lbPeriodicity.ItemHeight = 15;
            this.lbPeriodicity.Location = new System.Drawing.Point(3, 48);
            this.lbPeriodicity.Name = "lbPeriodicity";
            this.lbPeriodicity.Size = new System.Drawing.Size(120, 94);
            this.lbPeriodicity.TabIndex = 1;
            this.lbPeriodicity.SelectedIndexChanged += new System.EventHandler(this.lbPeriodicity_SelectedIndexChanged);
            // 
            // labelNbMonths
            // 
            this.labelNbMonths.AutoSize = true;
            this.labelNbMonths.Location = new System.Drawing.Point(47, 11);
            this.labelNbMonths.Name = "labelNbMonths";
            this.labelNbMonths.Size = new System.Drawing.Size(13, 15);
            this.labelNbMonths.TabIndex = 2;
            this.labelNbMonths.Text = "1";
            // 
            // PeriodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNbMonths);
            this.Controls.Add(this.lbPeriodicity);
            this.Controls.Add(this.sbNbMonths);
            this.Name = "PeriodUserControl";
            this.Size = new System.Drawing.Size(264, 162);
            this.Load += new System.EventHandler(this.PeriodUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HScrollBar sbNbMonths;
        private ListBox lbPeriodicity;
        private Label labelNbMonths;
    }
}
