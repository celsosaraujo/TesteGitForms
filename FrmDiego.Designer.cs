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
            txtnome = new TextBox();
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)picSenac).BeginInit();
            SuspendLayout();
            // 
            // picSenac
            // 
            picSenac.Image = (Image)resources.GetObject("picSenac.Image");
            picSenac.Location = new Point(552, 16);
            picSenac.Name = "picSenac";
            picSenac.Size = new Size(192, 104);
            picSenac.SizeMode = PictureBoxSizeMode.Zoom;
            picSenac.TabIndex = 0;
            picSenac.TabStop = false;
            // 
            // lblVagasEmprego
            // 
            lblVagasEmprego.AutoSize = true;
            lblVagasEmprego.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVagasEmprego.Location = new Point(24, 40);
            lblVagasEmprego.Name = "lblVagasEmprego";
            lblVagasEmprego.Size = new Size(518, 65);
            lblVagasEmprego.TabIndex = 1;
            lblVagasEmprego.Text = "Vagas de Emprego ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F);
            lblNome.Location = new Point(40, 152);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome:";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(96, 152);
            txtnome.Multiline = true;
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(248, 24);
            txtnome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(40, 200);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Cargo:";
            // 
            // rdbInstrutor
            // 
            rdbInstrutor.AutoSize = true;
            rdbInstrutor.Location = new Point(96, 200);
            rdbInstrutor.Name = "rdbInstrutor";
            rdbInstrutor.Size = new Size(84, 19);
            rdbInstrutor.TabIndex = 6;
            rdbInstrutor.TabStop = true;
            rdbInstrutor.Text = "Instrutor(a)";
            rdbInstrutor.UseVisualStyleBackColor = true;
            // 
            // rdbCoordenadorCurso
            // 
            rdbCoordenadorCurso.AutoSize = true;
            rdbCoordenadorCurso.Location = new Point(184, 200);
            rdbCoordenadorCurso.Name = "rdbCoordenadorCurso";
            rdbCoordenadorCurso.Size = new Size(159, 19);
            rdbCoordenadorCurso.TabIndex = 7;
            rdbCoordenadorCurso.TabStop = true;
            rdbCoordenadorCurso.Text = "Coordenador(a) de Curso";
            rdbCoordenadorCurso.UseVisualStyleBackColor = true;
            // 
            // rdbTecnicoInformatica
            // 
            rdbTecnicoInformatica.AutoSize = true;
            rdbTecnicoInformatica.Location = new Point(352, 200);
            rdbTecnicoInformatica.Name = "rdbTecnicoInformatica";
            rdbTecnicoInformatica.Size = new Size(163, 19);
            rdbTecnicoInformatica.TabIndex = 8;
            rdbTecnicoInformatica.TabStop = true;
            rdbTecnicoInformatica.Text = "Técnico(a) em Informática";
            rdbTecnicoInformatica.UseVisualStyleBackColor = true;
            // 
            // rdbAssistenteAdministrativo
            // 
            rdbAssistenteAdministrativo.AutoSize = true;
            rdbAssistenteAdministrativo.Location = new Point(536, 200);
            rdbAssistenteAdministrativo.Name = "rdbAssistenteAdministrativo";
            rdbAssistenteAdministrativo.Size = new Size(159, 19);
            rdbAssistenteAdministrativo.TabIndex = 9;
            rdbAssistenteAdministrativo.TabStop = true;
            rdbAssistenteAdministrativo.Text = "Assistente Administrativo";
            rdbAssistenteAdministrativo.UseVisualStyleBackColor = true;
            // 
            // txtExperiencia
            // 
            txtExperiencia.Location = new Point(128, 240);
            txtExperiencia.Multiline = true;
            txtExperiencia.Name = "txtExperiencia";
            txtExperiencia.Size = new Size(192, 72);
            txtExperiencia.TabIndex = 10;
            // 
            // lblExperiencia
            // 
            lblExperiencia.AutoSize = true;
            lblExperiencia.Font = new Font("Segoe UI", 11F);
            lblExperiencia.Location = new Point(40, 264);
            lblExperiencia.Name = "lblExperiencia";
            lblExperiencia.Size = new Size(88, 20);
            lblExperiencia.TabIndex = 11;
            lblExperiencia.Text = "Experiência:";
            // 
            // cmbDisponibilidade
            // 
            cmbDisponibilidade.FormattingEnabled = true;
            cmbDisponibilidade.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite", "Integral" });
            cmbDisponibilidade.Location = new Point(512, 264);
            cmbDisponibilidade.Name = "cmbDisponibilidade";
            cmbDisponibilidade.Size = new Size(121, 23);
            cmbDisponibilidade.TabIndex = 12;
            // 
            // lblDisponibilidade
            // 
            lblDisponibilidade.AutoSize = true;
            lblDisponibilidade.Font = new Font("Segoe UI", 11F);
            lblDisponibilidade.Location = new Point(384, 264);
            lblDisponibilidade.Name = "lblDisponibilidade";
            lblDisponibilidade.Size = new Size(118, 20);
            lblDisponibilidade.TabIndex = 13;
            lblDisponibilidade.Text = "Disponibilidade:";
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 20F);
            btnEnviar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnviar.ImageIndex = 0;
            btnEnviar.ImageList = imlIcones;
            btnEnviar.Location = new Point(168, 344);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(152, 72);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextAlign = ContentAlignment.MiddleRight;
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "enviar.png");
            // 
            // FrmDiego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(lblDisponibilidade);
            Controls.Add(cmbDisponibilidade);
            Controls.Add(lblExperiencia);
            Controls.Add(txtExperiencia);
            Controls.Add(rdbAssistenteAdministrativo);
            Controls.Add(rdbTecnicoInformatica);
            Controls.Add(rdbCoordenadorCurso);
            Controls.Add(rdbInstrutor);
            Controls.Add(label1);
            Controls.Add(txtnome);
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
        private TextBox txtnome;
        private Label label1;
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
    }
}