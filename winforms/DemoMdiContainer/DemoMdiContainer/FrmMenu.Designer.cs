namespace DemoMdiContainer
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStep1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDemo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStep2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStep3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDefil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConnection,
            this.menuStep1,
            this.menuStep2,
            this.menuStep3,
            this.menuWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuConnection
            // 
            this.menuConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSignIn,
            this.menuQuit});
            this.menuConnection.Name = "menuConnection";
            this.menuConnection.Size = new System.Drawing.Size(77, 20);
            this.menuConnection.Text = "Connexion";
            // 
            // menuSignIn
            // 
            this.menuSignIn.Name = "menuSignIn";
            this.menuSignIn.Size = new System.Drawing.Size(130, 22);
            this.menuSignIn.Text = "S\'identifier";
            this.menuSignIn.Click += new System.EventHandler(this.menuSignIn_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(130, 22);
            this.menuQuit.Text = "Quitter";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // menuStep1
            // 
            this.menuStep1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDemo});
            this.menuStep1.Enabled = false;
            this.menuStep1.Name = "menuStep1";
            this.menuStep1.Size = new System.Drawing.Size(59, 20);
            this.menuStep1.Text = "Phase 1";
            // 
            // menuDemo
            // 
            this.menuDemo.Name = "menuDemo";
            this.menuDemo.Size = new System.Drawing.Size(180, 22);
            this.menuDemo.Tag = "0";
            this.menuDemo.Text = "Démo";
            this.menuDemo.Click += new System.EventHandler(this.menuAppClick);
            // 
            // menuStep2
            // 
            this.menuStep2.Enabled = false;
            this.menuStep2.Name = "menuStep2";
            this.menuStep2.Size = new System.Drawing.Size(59, 20);
            this.menuStep2.Text = "Phase 2";
            // 
            // menuStep3
            // 
            this.menuStep3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDefil});
            this.menuStep3.Enabled = false;
            this.menuStep3.Name = "menuStep3";
            this.menuStep3.Size = new System.Drawing.Size(59, 20);
            this.menuStep3.Text = "Phase 3";
            // 
            // menuDefil
            // 
            this.menuDefil.Name = "menuDefil";
            this.menuDefil.Size = new System.Drawing.Size(180, 22);
            this.menuDefil.Tag = "0";
            this.menuDefil.Text = "Défilement";
            this.menuDefil.Click += new System.EventHandler(this.menuAppClick);
            // 
            // menuWindows
            // 
            this.menuWindows.Enabled = false;
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(63, 20);
            this.menuWindows.Text = "Fenêtres";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuConnection;
        private ToolStripMenuItem menuSignIn;
        private ToolStripMenuItem menuQuit;
        private ToolStripMenuItem menuStep1;
        private ToolStripMenuItem menuStep2;
        private ToolStripMenuItem menuStep3;
        private ToolStripMenuItem menuWindows;
        private ToolStripMenuItem menuDemo;
        private ToolStripMenuItem menuDefil;
    }
}