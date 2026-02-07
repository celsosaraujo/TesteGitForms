namespace frmTesteGitForms
{
    partial class frmPaulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaulo));
            lblNome = new Label();
            txtNome = new TextBox();
            lblPatente = new Label();
            lblSituacao = new Label();
            cmbPatente = new ComboBox();
            cmbSituacao = new ComboBox();
            btnConfirmarStatus = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(16, 40);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(70, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(217, 23);
            txtNome.TabIndex = 2;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPatente.Location = new Point(16, 96);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(55, 17);
            lblPatente.TabIndex = 3;
            lblPatente.Text = "Patente";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSituacao.Location = new Point(16, 152);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(59, 17);
            lblSituacao.TabIndex = 5;
            lblSituacao.Text = "Situação";
            // 
            // cmbPatente
            // 
            cmbPatente.ForeColor = SystemColors.ControlDarkDark;
            cmbPatente.FormattingEnabled = true;
            cmbPatente.Items.AddRange(new object[] { "Soldado", "Cabo", "Sargento" });
            cmbPatente.Location = new Point(73, 94);
            cmbPatente.Name = "cmbPatente";
            cmbPatente.Size = new Size(128, 23);
            cmbPatente.TabIndex = 6;
            // 
            // cmbSituacao
            // 
            cmbSituacao.FormattingEnabled = true;
            cmbSituacao.Items.AddRange(new object[] { "Em serviço", "Em treinamento", "De folga" });
            cmbSituacao.Location = new Point(76, 150);
            cmbSituacao.Name = "cmbSituacao";
            cmbSituacao.Size = new Size(128, 23);
            cmbSituacao.TabIndex = 7;
            // 
            // btnConfirmarStatus
            // 
            btnConfirmarStatus.BackColor = Color.OliveDrab;
            btnConfirmarStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirmarStatus.ForeColor = SystemColors.ControlDarkDark;
            btnConfirmarStatus.Location = new Point(64, 224);
            btnConfirmarStatus.Name = "btnConfirmarStatus";
            btnConfirmarStatus.Size = new Size(192, 32);
            btnConfirmarStatus.TabIndex = 8;
            btnConfirmarStatus.Text = "Confirmar Status";
            btnConfirmarStatus.UseVisualStyleBackColor = false;
            btnConfirmarStatus.Click += btnConfirmarStatus_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmPaulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 338);
            Controls.Add(pictureBox1);
            Controls.Add(btnConfirmarStatus);
            Controls.Add(cmbSituacao);
            Controls.Add(cmbPatente);
            Controls.Add(lblSituacao);
            Controls.Add(lblPatente);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "frmPaulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPaulo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private TextBox txtNome;
        private Label lblPatente;
        private Label lblSituacao;
        private ComboBox cmbPatente;
        private ComboBox cmbSituacao;
        private Button btnConfirmarStatus;
        private PictureBox pictureBox1;
    }
}