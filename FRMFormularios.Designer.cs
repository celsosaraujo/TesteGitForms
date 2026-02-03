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
            menuStrip1 = new MenuStrip();
            mniFomularios = new ToolStripMenuItem();
            mnuCelso = new ToolStripMenuItem();
            mnuThiago = new ToolStripMenuItem();
            mnuGustavo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mniFomularios });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mniFomularios
            // 
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuCelso,mnuThiago });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuGustavo });
            mniFomularios.Name = "mniFomularios";
            mniFomularios.Size = new Size(82, 20);
            mniFomularios.Text = "Formulários";

            // 
            // mnuCelso
            // 
            mnuCelso.Name = "mnuCelso";
            mnuCelso.Size = new Size(180, 22);
            mnuCelso.Text = "Celso";
            mnuCelso.Click += mnuCelso_Click;

            mnuThiago.Name = "mnuThiago";
            mnuThiago.Size = new Size(180, 22);
            mnuThiago.Text = "Thiago";
            mnuThiago.Click += mnuThiago_Click;
            // 
            // mnuGustavo
            // 
            mnuGustavo.Name = "mnuGustavo";
            mnuGustavo.Size = new Size(180, 22);
            mnuGustavo.Text = "Gustavo";
            mnuGustavo.Click += gustavoToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Formulários Criativos";
            WindowState = FormWindowState.Minimized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mniFomularios;
        private ToolStripMenuItem mnuCelso;
        private ToolStripMenuItem mnuThiago;
        private ToolStripMenuItem mnuGustavo;
    }
}
