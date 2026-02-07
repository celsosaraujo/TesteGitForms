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
            mnuluis = new ToolStripMenuItem();
            diegoToolStripMenuItem = new ToolStripMenuItem();
            mnuAffonso = new ToolStripMenuItem();
            mniPedro = new ToolStripMenuItem();
            mnuHanna = new ToolStripMenuItem();
            suelyToolStripMenuItem = new ToolStripMenuItem();
            mniElias = new ToolStripMenuItem();
            mnuPaulo = new ToolStripMenuItem();
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
            
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuCelso,mnuThiago });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuGustavo });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuluis });
            // 
            // mniFomularios
            // 
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { diegoToolStripMenuItem });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuAffonso });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mniPedro });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuHanna });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { suelyToolStripMenuItem });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mniElias });
            mniFomularios.DropDownItems.AddRange(new ToolStripItem[] { mnuPaulo });
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
            mnuluis.Name = "mnuluis";
            mnuluis.Size = new Size(180, 22);
            mnuluis.Text = "Luis Gustavo";
            mnuluis.Click += mnuluis_Click;
            // 
            // diegoToolStripMenuItem
            // 
            diegoToolStripMenuItem.Name = "diegoToolStripMenuItem";
            diegoToolStripMenuItem.Size = new Size(180, 22);
            diegoToolStripMenuItem.Text = "Diego";
            diegoToolStripMenuItem.Click += diegoToolStripMenuItem_Click;
            // 
            // mnuAffonso
            // 
            mnuAffonso.Name = "mnuAffonso";
            mnuAffonso.Size = new Size(180, 22);
            mnuAffonso.Text = "Affonso";
            mnuAffonso.Click += affonsoToolStripMenuItem_Click;
            // 
            // mniPedro
            // 
            mniPedro.Name = "mniPedro";
            mniPedro.Size = new Size(180, 22);
            mniPedro.Text = "Pedro";
            mniPedro.Click += mniPedro_Click;
            // 
            // mnuHanna
            // 
            mnuHanna.Name = "mnuHanna";
            mnuHanna.Size = new Size(180, 22);
            mnuHanna.Text = "Hanna";
            mnuHanna.Click += hannaToolStripMenuItem_Click;
            // 
            // suelyToolStripMenuItem
            // 
            suelyToolStripMenuItem.Name = "suelyToolStripMenuItem";
            suelyToolStripMenuItem.Size = new Size(102, 22);
            suelyToolStripMenuItem.Text = "Suely";
            suelyToolStripMenuItem.Click += suelyToolStripMenuItem_Click;
            // 
            // mniElias
            // 
            mniElias.Name = "mniElias";
            mniElias.Size = new Size(180, 22);
            mniElias.Text = "Elias";
            mniElias.Click += mniElias_Click;
            // 
            // mnuPaulo
            // 
            mnuPaulo.Name = "mnuPaulo";
            mnuPaulo.Size = new Size(180, 22);
            mnuPaulo.Text = "paulo";
            mnuPaulo.Click += PauloToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulários Criativos";
            WindowState = FormWindowState.Minimized;
            Load += frmPrincipal_Load;
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
        private ToolStripMenuItem mnuluis;
        private ToolStripMenuItem diegoToolStripMenuItem;
        private ToolStripMenuItem mnuAffonso;
        private ToolStripMenuItem mniPedro;
        private ToolStripMenuItem mnuHanna;
        private ToolStripMenuItem suelyToolStripMenuItem;
        private ToolStripMenuItem mniElias;
        private ToolStripMenuItem mnuPaulo;
    }
}
