namespace frmTesteGitForms
{
    partial class FRMFElias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMFElias));
            pbCharmander = new PictureBox();
            pbBulbasaur = new PictureBox();
            barVidaCharmander = new ProgressBar();
            barVidaBulbasaur = new ProgressBar();
            btnTackle = new Button();
            btnEmber = new Button();
            rtbLog = new RichTextBox();
            pnlBulbasaur = new Panel();
            lblVidaBulbasaur = new Label();
            lblLevelBulbasaur = new Label();
            lblBulbasaur = new Label();
            pnlCharmander = new Panel();
            lblVidaCharmander = new Label();
            lblLevelCharmander = new Label();
            lblCharmander = new Label();
            panel2 = new Panel();
            btnNovaBatalha = new Button();
            pnlAtaques = new Panel();
            btnVoltar = new Button();
            btnGrowl = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCharmander).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBulbasaur).BeginInit();
            pnlBulbasaur.SuspendLayout();
            pnlCharmander.SuspendLayout();
            panel2.SuspendLayout();
            pnlAtaques.SuspendLayout();
            SuspendLayout();
            // 
            // pbCharmander
            // 
            pbCharmander.Image = (Image)resources.GetObject("pbCharmander.Image");
            pbCharmander.Location = new Point(86, 168);
            pbCharmander.Name = "pbCharmander";
            pbCharmander.Size = new Size(160, 160);
            pbCharmander.SizeMode = PictureBoxSizeMode.Zoom;
            pbCharmander.TabIndex = 0;
            pbCharmander.TabStop = false;
            // 
            // pbBulbasaur
            // 
            pbBulbasaur.Image = (Image)resources.GetObject("pbBulbasaur.Image");
            pbBulbasaur.Location = new Point(604, 27);
            pbBulbasaur.Name = "pbBulbasaur";
            pbBulbasaur.Size = new Size(140, 140);
            pbBulbasaur.SizeMode = PictureBoxSizeMode.Zoom;
            pbBulbasaur.TabIndex = 1;
            pbBulbasaur.TabStop = false;
            // 
            // barVidaCharmander
            // 
            barVidaCharmander.Location = new Point(37, 24);
            barVidaCharmander.Name = "barVidaCharmander";
            barVidaCharmander.Size = new Size(211, 23);
            barVidaCharmander.TabIndex = 2;
            barVidaCharmander.Value = 100;
            // 
            // barVidaBulbasaur
            // 
            barVidaBulbasaur.Location = new Point(37, 24);
            barVidaBulbasaur.Name = "barVidaBulbasaur";
            barVidaBulbasaur.Size = new Size(214, 23);
            barVidaBulbasaur.TabIndex = 3;
            barVidaBulbasaur.Value = 100;
            // 
            // btnTackle
            // 
            btnTackle.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnTackle.Location = new Point(37, 11);
            btnTackle.Name = "btnTackle";
            btnTackle.Size = new Size(86, 27);
            btnTackle.TabIndex = 0;
            btnTackle.Text = "TACKLE";
            btnTackle.UseVisualStyleBackColor = true;
            btnTackle.Click += btnAtaque1_Click;
            // 
            // btnEmber
            // 
            btnEmber.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnEmber.Location = new Point(37, 44);
            btnEmber.Name = "btnEmber";
            btnEmber.Size = new Size(86, 27);
            btnEmber.TabIndex = 1;
            btnEmber.Text = "EMBER";
            btnEmber.UseVisualStyleBackColor = true;
            btnEmber.Click += btnAtaque2_Click;
            // 
            // rtbLog
            // 
            rtbLog.Enabled = false;
            rtbLog.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbLog.Location = new Point(41, 355);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(535, 112);
            rtbLog.TabIndex = 6;
            rtbLog.Text = "";
            // 
            // pnlBulbasaur
            // 
            pnlBulbasaur.Controls.Add(lblVidaBulbasaur);
            pnlBulbasaur.Controls.Add(lblLevelBulbasaur);
            pnlBulbasaur.Controls.Add(lblBulbasaur);
            pnlBulbasaur.Controls.Add(barVidaBulbasaur);
            pnlBulbasaur.Location = new Point(72, 28);
            pnlBulbasaur.Name = "pnlBulbasaur";
            pnlBulbasaur.Size = new Size(260, 60);
            pnlBulbasaur.TabIndex = 7;
            // 
            // lblVidaBulbasaur
            // 
            lblVidaBulbasaur.AutoSize = true;
            lblVidaBulbasaur.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidaBulbasaur.Location = new Point(9, 28);
            lblVidaBulbasaur.Name = "lblVidaBulbasaur";
            lblVidaBulbasaur.Size = new Size(28, 14);
            lblVidaBulbasaur.TabIndex = 10;
            lblVidaBulbasaur.Text = "HP:";
            // 
            // lblLevelBulbasaur
            // 
            lblLevelBulbasaur.AutoSize = true;
            lblLevelBulbasaur.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevelBulbasaur.Location = new Point(222, 0);
            lblLevelBulbasaur.Name = "lblLevelBulbasaur";
            lblLevelBulbasaur.Size = new Size(35, 14);
            lblLevelBulbasaur.TabIndex = 0;
            lblLevelBulbasaur.Text = "Lv.5";
            // 
            // lblBulbasaur
            // 
            lblBulbasaur.AutoSize = true;
            lblBulbasaur.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblBulbasaur.Location = new Point(3, 0);
            lblBulbasaur.Name = "lblBulbasaur";
            lblBulbasaur.Size = new Size(80, 17);
            lblBulbasaur.TabIndex = 9;
            lblBulbasaur.Text = "BULBASAUR";
            // 
            // pnlCharmander
            // 
            pnlCharmander.Controls.Add(lblVidaCharmander);
            pnlCharmander.Controls.Add(lblLevelCharmander);
            pnlCharmander.Controls.Add(lblCharmander);
            pnlCharmander.Controls.Add(barVidaCharmander);
            pnlCharmander.Location = new Point(578, 280);
            pnlCharmander.Name = "pnlCharmander";
            pnlCharmander.Size = new Size(260, 60);
            pnlCharmander.TabIndex = 11;
            // 
            // lblVidaCharmander
            // 
            lblVidaCharmander.AutoSize = true;
            lblVidaCharmander.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidaCharmander.Location = new Point(9, 28);
            lblVidaCharmander.Name = "lblVidaCharmander";
            lblVidaCharmander.Size = new Size(28, 14);
            lblVidaCharmander.TabIndex = 10;
            lblVidaCharmander.Text = "HP:";
            // 
            // lblLevelCharmander
            // 
            lblLevelCharmander.AutoSize = true;
            lblLevelCharmander.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevelCharmander.Location = new Point(222, 0);
            lblLevelCharmander.Name = "lblLevelCharmander";
            lblLevelCharmander.Size = new Size(35, 14);
            lblLevelCharmander.TabIndex = 0;
            lblLevelCharmander.Text = "Lv.5";
            // 
            // lblCharmander
            // 
            lblCharmander.AutoSize = true;
            lblCharmander.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblCharmander.Location = new Point(3, 0);
            lblCharmander.Name = "lblCharmander";
            lblCharmander.Size = new Size(88, 17);
            lblCharmander.TabIndex = 9;
            lblCharmander.Text = "CHARMANDER";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNovaBatalha);
            panel2.Controls.Add(pnlAtaques);
            panel2.Controls.Add(pbBulbasaur);
            panel2.Controls.Add(pbCharmander);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 458);
            panel2.TabIndex = 12;
            // 
            // btnNovaBatalha
            // 
            btnNovaBatalha.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnNovaBatalha.Location = new Point(774, 0);
            btnNovaBatalha.Name = "btnNovaBatalha";
            btnNovaBatalha.Size = new Size(86, 27);
            btnNovaBatalha.TabIndex = 4;
            btnNovaBatalha.Text = "RESET";
            btnNovaBatalha.UseVisualStyleBackColor = true;
            btnNovaBatalha.Click += btnNovaBatalha_Click_1;
            // 
            // pnlAtaques
            // 
            pnlAtaques.Controls.Add(btnVoltar);
            pnlAtaques.Controls.Add(btnGrowl);
            pnlAtaques.Controls.Add(btnEmber);
            pnlAtaques.Controls.Add(btnTackle);
            pnlAtaques.Location = new Point(566, 340);
            pnlAtaques.Name = "pnlAtaques";
            pnlAtaques.Size = new Size(260, 115);
            pnlAtaques.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnVoltar.Location = new Point(173, 87);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(86, 27);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnGrowl
            // 
            btnGrowl.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnGrowl.Location = new Point(129, 11);
            btnGrowl.Name = "btnGrowl";
            btnGrowl.Size = new Size(86, 27);
            btnGrowl.TabIndex = 2;
            btnGrowl.Text = "GROWL";
            btnGrowl.UseVisualStyleBackColor = true;
            btnGrowl.Click += btnGrowl_Click;
            // 
            // FRMFElias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 482);
            Controls.Add(pnlCharmander);
            Controls.Add(rtbLog);
            Controls.Add(pnlBulbasaur);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FRMFElias";
            Text = "Elias";
            Load += FRMFElias_Load;
            ((System.ComponentModel.ISupportInitialize)pbCharmander).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBulbasaur).EndInit();
            pnlBulbasaur.ResumeLayout(false);
            pnlBulbasaur.PerformLayout();
            pnlCharmander.ResumeLayout(false);
            pnlCharmander.PerformLayout();
            panel2.ResumeLayout(false);
            pnlAtaques.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbCharmander;
        private PictureBox pbBulbasaur;
        private ProgressBar barVidaCharmander;
        private ProgressBar barVidaBulbasaur;
        private Button btnTackle;
        private Button btnEmber;
        private RichTextBox rtbLog;
        private Panel pnlBulbasaur;
        private Label lblVidaBulbasaur;
        private Label lblLevelBulbasaur;
        private Label lblBulbasaur;
        private Panel pnlCharmander;
        private Label lblVidaCharmander;
        private Label lblLevelCharmander;
        private Label lblCharmander;
        private Panel panel2;
        private Panel pnlAtaques;
        private Button btnGrowl;
        private Button btnNovaBatalha;
        private Button btnVoltar;
    }
}