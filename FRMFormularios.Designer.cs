namespace frmTesteGitForms
{
    partial class frmPrincipal
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
            mnuDiego = new MenuStrip();
            mniFomularios = new ToolStripMenuItem();
            diegoToolStripMenuItem = new ToolStripMenuItem();
            mnuDiego.SuspendLayout();
            SuspendLayout();
            // 
            // mnuDiego
            // 
            mnuDiego.Items.AddRange(new ToolStripItem[] { mniFomularios });
            mnuDiego.Location = new Point(0, 0);
            mnuDiego.Name = "mnuDiego";
            mnuDiego.Size = new Size(800, 24);
            mnuDiego.TabIndex = 0;
            mnuDiego.Text = "menuStrip1";
            // 
            // mniFomularios
            // 
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { diegoToolStripMenuItem });
            mniFomularios.Name = "mniFomularios";
            mniFomularios.Size = new Size(82, 20);
            mniFomularios.Text = "Formulários";
            // 
            // diegoToolStripMenuItem
            // 
            diegoToolStripMenuItem.Name = "diegoToolStripMenuItem";
            diegoToolStripMenuItem.Size = new Size(180, 22);
            diegoToolStripMenuItem.Text = "Diego";
            diegoToolStripMenuItem.Click += diegoToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuDiego);
            MainMenuStrip = mnuDiego;
            Name = "frmPrincipal";
            Text = "Formulários Criativos";
            WindowState = FormWindowState.Minimized;
            mnuDiego.ResumeLayout(false);
            mnuDiego.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuDiego;
        private ToolStripMenuItem mniFomularios;
        private ToolStripMenuItem diegoToolStripMenuItem;
    }
}
