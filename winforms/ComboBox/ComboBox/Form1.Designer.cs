namespace ComboBox
{
    partial class Form1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.lbxTarget = new System.Windows.Forms.ListBox();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemoveOne = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnMovedown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(262, 92);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(54, 13);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(43, 15);
            this.labelSource.TabIndex = 0;
            this.labelSource.Text = "Source";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(304, 9);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(34, 15);
            this.labelTarget.TabIndex = 1;
            this.labelTarget.Text = "Cible";
            // 
            // lbxTarget
            // 
            this.lbxTarget.FormattingEnabled = true;
            this.lbxTarget.ItemHeight = 15;
            this.lbxTarget.Location = new System.Drawing.Point(292, 27);
            this.lbxTarget.Name = "lbxTarget";
            this.lbxTarget.Size = new System.Drawing.Size(120, 154);
            this.lbxTarget.TabIndex = 2;
            // 
            // cbxSource
            // 
            this.cbxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(12, 59);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(121, 23);
            this.cbxSource.TabIndex = 3;
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(193, 27);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(75, 23);
            this.btnAddOne.TabIndex = 4;
            this.btnAddOne.Text = ">";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(193, 59);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnAddAll.TabIndex = 5;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.Location = new System.Drawing.Point(193, 125);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOne.TabIndex = 6;
            this.btnRemoveOne.Text = "<";
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(238, 204);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 7;
            this.btnMoveUp.Text = "move up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(193, 158);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Text = "<<";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnMovedown
            // 
            this.btnMovedown.Location = new System.Drawing.Point(319, 204);
            this.btnMovedown.Name = "btnMovedown";
            this.btnMovedown.Size = new System.Drawing.Size(80, 23);
            this.btnMovedown.TabIndex = 9;
            this.btnMovedown.Text = "move down";
            this.btnMovedown.UseVisualStyleBackColor = true;
            this.btnMovedown.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.btnMovedown);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRemoveOne);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.cbxSource);
            this.Controls.Add(this.lbxTarget);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelSource);
            this.Name = "Form1";
            this.Text = "Les listes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private HScrollBar hScrollBar1;
        private GroupBox groupBox1;
        private Label labelSource;
        private Label labelTarget;
        private ListBox lbxTarget;
        private System.Windows.Forms.ComboBox cbxSource;
        private Button btnAddOne;
        private Button btnAddAll;
        private Button btnRemoveOne;
        private Button btnMoveUp;
        private Button btnRemoveAll;
        private Button btnMovedown;
    }
}