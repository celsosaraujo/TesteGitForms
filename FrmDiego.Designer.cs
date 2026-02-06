namespace frmTesteGitForms
{
    partial class FrmDiego
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiego));
            picSenac = new PictureBox();
            lblVagasEmprego = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEnviar = new Label();
            rdbInstrutor = new RadioButton();
            rdbCoordenadorCurso = new RadioButton();
            rdbTecnicoInformatica = new RadioButton();
            rdbAssistenteAdministrativo = new RadioButton();
            txtExperiencia = new TextBox();
            lblExperiencia = new Label();
            cmbDisponibilidade = new ComboBox();
            lblDisponibilidade = new Label();
            btnEnviar = new Button();
            imlIcones = new ImageList(components);
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picSenac).BeginInit();
            SuspendLayout();
            // 
            // picSenac
            // 
            picSenac.BackColor = Color.Transparent;
            picSenac.Image = (Image)resources.GetObject("picSenac.Image");
            picSenac.Location = new Point(448, 16);
            picSenac.Name = "picSenac";
            picSenac.Size = new Size(192, 104);
            picSenac.SizeMode = PictureBoxSizeMode.Zoom;
            picSenac.TabIndex = 0;
            picSenac.TabStop = false;
            // 
            // lblVagasEmprego
            // 
            lblVagasEmprego.AutoSize = true;
            lblVagasEmprego.BackColor = Color.Transparent;
            lblVagasEmprego.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVagasEmprego.Location = new Point(24, 40);
            lblVagasEmprego.Name = "lblVagasEmprego";
            lblVagasEmprego.Size = new Size(389, 50);
            lblVagasEmprego.TabIndex = 1;
            lblVagasEmprego.Text = "Vagas de Emprego ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.Location = new Point(16, 152);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Location = new Point(96, 152);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 24);
            txtNome.TabIndex = 0;
            // 
            // lblEnviar
            // 
            lblEnviar.AutoSize = true;
            lblEnviar.BackColor = Color.Transparent;
            lblEnviar.Font = new Font("Segoe UI", 11F);
            lblEnviar.Location = new Point(16, 200);
            lblEnviar.Name = "lblEnviar";
            lblEnviar.Size = new Size(52, 20);
            lblEnviar.TabIndex = 5;
            lblEnviar.Text = "Cargo:";
            // 
            // rdbInstrutor
            // 
            rdbInstrutor.AutoSize = true;
            rdbInstrutor.BackColor = Color.Transparent;
            rdbInstrutor.Location = new Point(80, 200);
            rdbInstrutor.Name = "rdbInstrutor";
            rdbInstrutor.Size = new Size(84, 19);
            rdbInstrutor.TabIndex = 1;
            rdbInstrutor.TabStop = true;
            rdbInstrutor.Text = "Instrutor(a)";
            rdbInstrutor.UseVisualStyleBackColor = false;
            // 
            // rdbCoordenadorCurso
            // 
            rdbCoordenadorCurso.AutoSize = true;
            rdbCoordenadorCurso.BackColor = Color.Transparent;
            rdbCoordenadorCurso.Location = new Point(168, 200);
            rdbCoordenadorCurso.Name = "rdbCoordenadorCurso";
            rdbCoordenadorCurso.Size = new Size(159, 19);
            rdbCoordenadorCurso.TabIndex = 2;
            rdbCoordenadorCurso.TabStop = true;
            rdbCoordenadorCurso.Text = "Coordenador(a) de Curso";
            rdbCoordenadorCurso.UseVisualStyleBackColor = false;
            // 
            // rdbTecnicoInformatica
            // 
            rdbTecnicoInformatica.AutoSize = true;
            rdbTecnicoInformatica.BackColor = Color.Transparent;
            rdbTecnicoInformatica.Location = new Point(336, 200);
            rdbTecnicoInformatica.Name = "rdbTecnicoInformatica";
            rdbTecnicoInformatica.Size = new Size(163, 19);
            rdbTecnicoInformatica.TabIndex = 3;
            rdbTecnicoInformatica.TabStop = true;
            rdbTecnicoInformatica.Text = "Técnico(a) em Informática";
            rdbTecnicoInformatica.UseVisualStyleBackColor = false;
            // 
            // rdbAssistenteAdministrativo
            // 
            rdbAssistenteAdministrativo.AutoSize = true;
            rdbAssistenteAdministrativo.BackColor = Color.Transparent;
            rdbAssistenteAdministrativo.Location = new Point(504, 200);
            rdbAssistenteAdministrativo.Name = "rdbAssistenteAdministrativo";
            rdbAssistenteAdministrativo.Size = new Size(159, 19);
            rdbAssistenteAdministrativo.TabIndex = 4;
            rdbAssistenteAdministrativo.TabStop = true;
            rdbAssistenteAdministrativo.Text = "Assistente Administrativo";
            rdbAssistenteAdministrativo.UseVisualStyleBackColor = false;
            // 
            // txtExperiencia
            // 
            txtExperiencia.BackColor = Color.White;
            txtExperiencia.Location = new Point(112, 240);
            txtExperiencia.Multiline = true;
            txtExperiencia.Name = "txtExperiencia";
            txtExperiencia.Size = new Size(192, 72);
            txtExperiencia.TabIndex = 5;
            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.BackColor = Color.Transparent;
            lblExperiencia.Font = new Font("Segoe UI", 11F);
            lblExperiencia.Location = new Point(16, 264);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(88, 20);
            lblExperiencia.TabIndex = 11;
            lblExperiencia.Text = "Experiência:";
            // 
            // cmbDisponibilidade
            // 
            cmbDisponibilidade.BackColor = Color.White;
            cmbDisponibilidade.ForeColor = SystemColors.WindowText;
            cmbDisponibilidade.FormattingEnabled = true;
            cmbDisponibilidade.ItemHeight = 15;
            cmbDisponibilidade.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite", "Integral" });
            cmbDisponibilidade.Location = new Point(456, 264);
            cmbDisponibilidade.Name = "cmbDisponibilidade";
            cmbDisponibilidade.Size = new Size(121, 23);
            cmbDisponibilidade.TabIndex = 6;
            // 
            // lblDisponibilidade
            // 
            lblDisponibilidade.AutoSize = true;
            lblDisponibilidade.BackColor = Color.Transparent;
            lblDisponibilidade.Font = new Font("Segoe UI", 11F);
            lblDisponibilidade.Location = new Point(336, 264);
            lblDisponibilidade.Name = "lblDisponibilidade";
            lblDisponibilidade.Size = new Size(118, 20);
            lblDisponibilidade.TabIndex = 13;
            lblDisponibilidade.Text = "Disponibilidade:";
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.White;
            btnEnviar.Font = new Font("Segoe UI", 17F);
            btnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviar.ImageIndex = 0;
            btnEnviar.ImageList = imlIcones;
            btnEnviar.Location = new Point(280, 352);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(112, 40);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextAlign = ContentAlignment.MiddleRight;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "enviar.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ChatGPT Image 2 de fev. de 2026, 19_47_19.png");
            // 
            // FrmDiego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ChatGPT_Image_2_de_fev__de_2026__19_47_19;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(676, 450);
            Controls.Add(btnEnviar);
            Controls.Add(lblDisponibilidade);
            Controls.Add(cmbDisponibilidade);
            Controls.Add(lblExperiencia);
            Controls.Add(txtExperiencia);
            Controls.Add(rdbAssistenteAdministrativo);
            Controls.Add(rdbTecnicoInformatica);
            Controls.Add(rdbCoordenadorCurso);
            Controls.Add(rdbInstrutor);
            Controls.Add(lblEnviar);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblVagasEmprego);
            Controls.Add(picSenac);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDiego";
            Text = "Formulário do Diego";
            ((System.ComponentModel.ISupportInitialize)picSenac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picSenac;
        private Label lblVagasEmprego;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEnviar;
        private RadioButton rdbInstrutor;
        private RadioButton rdbCoordenadorCurso;
        private RadioButton rdbTecnicoInformatica;
        private RadioButton rdbAssistenteAdministrativo;
        private TextBox txtExperiencia;
        private Label lblExperiencia;
        private ComboBox cmbDisponibilidade;
        private Label lblDisponibilidade;
        private Button btnEnviar;
        private ImageList imlIcones;
        private ImageList imageList1;
    }
}