namespace frmTesteGitForms
{
    partial class frmSuely
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuely));
            lblNome = new Label();
            lblAvaliacao = new Label();
            txtNome = new TextBox();
            rdbMuitoRuim = new RadioButton();
            rdbRuim = new RadioButton();
            rdbRegular = new RadioButton();
            rdbBom = new RadioButton();
            rdbExcelente = new RadioButton();
            grpAvaliacao = new GroupBox();
            chkProfessores = new CheckBox();
            chkConteudo = new CheckBox();
            chkMaterial = new CheckBox();
            chkAmbiente = new CheckBox();
            chkOutros = new CheckBox();
            label1 = new Label();
            btnLimpar = new Button();
            btnEnviar = new Button();
            label2 = new Label();
            grpAvaliacao.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = SystemColors.ButtonHighlight;
            lblNome.Location = new Point(96, 392);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 17);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblAvaliacao
            // 
            lblAvaliacao.BackColor = Color.Transparent;
            lblAvaliacao.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvaliacao.ForeColor = SystemColors.ButtonHighlight;
            lblAvaliacao.Location = new Point(168, 112);
            lblAvaliacao.Name = "lblAvaliacao";
            lblAvaliacao.Size = new Size(432, 32);
            lblAvaliacao.TabIndex = 1;
            lblAvaliacao.Text = "Queremos saber como você avalia nosso curso?";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.GradientActiveCaption;
            txtNome.Location = new Point(152, 392);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(432, 23);
            txtNome.TabIndex = 3;
            // 
            // rdbMuitoRuim
            // 
            rdbMuitoRuim.AutoSize = true;
            rdbMuitoRuim.Location = new Point(80, 24);
            rdbMuitoRuim.Name = "rdbMuitoRuim";
            rdbMuitoRuim.Size = new Size(99, 21);
            rdbMuitoRuim.TabIndex = 5;
            rdbMuitoRuim.TabStop = true;
            rdbMuitoRuim.Text = "Muito Ruim";
            rdbMuitoRuim.UseVisualStyleBackColor = true;
            // 
            // rdbRuim
            // 
            rdbRuim.AutoSize = true;
            rdbRuim.Location = new Point(208, 24);
            rdbRuim.Name = "rdbRuim";
            rdbRuim.Size = new Size(58, 21);
            rdbRuim.TabIndex = 6;
            rdbRuim.TabStop = true;
            rdbRuim.Text = "Ruim";
            rdbRuim.UseVisualStyleBackColor = true;
            // 
            // rdbRegular
            // 
            rdbRegular.AutoSize = true;
            rdbRegular.Location = new Point(296, 24);
            rdbRegular.Name = "rdbRegular";
            rdbRegular.Size = new Size(73, 21);
            rdbRegular.TabIndex = 7;
            rdbRegular.TabStop = true;
            rdbRegular.Text = "Regular";
            rdbRegular.UseVisualStyleBackColor = true;
            // 
            // rdbBom
            // 
            rdbBom.AutoSize = true;
            rdbBom.Location = new Point(408, 24);
            rdbBom.Name = "rdbBom";
            rdbBom.Size = new Size(54, 21);
            rdbBom.TabIndex = 8;
            rdbBom.TabStop = true;
            rdbBom.Text = "Bom";
            rdbBom.UseVisualStyleBackColor = true;
            // 
            // rdbExcelente
            // 
            rdbExcelente.AutoSize = true;
            rdbExcelente.Location = new Point(488, 24);
            rdbExcelente.Name = "rdbExcelente";
            rdbExcelente.Size = new Size(84, 21);
            rdbExcelente.TabIndex = 9;
            rdbExcelente.TabStop = true;
            rdbExcelente.Text = "Excelente";
            rdbExcelente.UseVisualStyleBackColor = true;
            // 
            // grpAvaliacao
            // 
            grpAvaliacao.BackColor = Color.Transparent;
            grpAvaliacao.Controls.Add(rdbExcelente);
            grpAvaliacao.Controls.Add(rdbMuitoRuim);
            grpAvaliacao.Controls.Add(rdbBom);
            grpAvaliacao.Controls.Add(rdbRuim);
            grpAvaliacao.Controls.Add(rdbRegular);
            grpAvaliacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAvaliacao.ForeColor = SystemColors.ButtonHighlight;
            grpAvaliacao.Location = new Point(88, 152);
            grpAvaliacao.Name = "grpAvaliacao";
            grpAvaliacao.Size = new Size(608, 56);
            grpAvaliacao.TabIndex = 10;
            grpAvaliacao.TabStop = false;
            grpAvaliacao.Text = "Nota";
            // 
            // chkProfessores
            // 
            chkProfessores.AutoSize = true;
            chkProfessores.BackColor = Color.Transparent;
            chkProfessores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkProfessores.ForeColor = SystemColors.ButtonHighlight;
            chkProfessores.Location = new Point(112, 272);
            chkProfessores.Name = "chkProfessores";
            chkProfessores.Size = new Size(98, 21);
            chkProfessores.TabIndex = 11;
            chkProfessores.Text = "Professores";
            chkProfessores.UseVisualStyleBackColor = false;
            // 
            // chkConteudo
            // 
            chkConteudo.AutoSize = true;
            chkConteudo.BackColor = Color.Transparent;
            chkConteudo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkConteudo.ForeColor = SystemColors.ButtonHighlight;
            chkConteudo.Location = new Point(240, 272);
            chkConteudo.Name = "chkConteudo";
            chkConteudo.Size = new Size(87, 21);
            chkConteudo.TabIndex = 12;
            chkConteudo.Text = "Conteúdo";
            chkConteudo.UseVisualStyleBackColor = false;
            // 
            // chkMaterial
            // 
            chkMaterial.AutoSize = true;
            chkMaterial.BackColor = Color.Transparent;
            chkMaterial.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMaterial.ForeColor = SystemColors.ButtonHighlight;
            chkMaterial.Location = new Point(360, 272);
            chkMaterial.Name = "chkMaterial";
            chkMaterial.Size = new Size(78, 21);
            chkMaterial.TabIndex = 13;
            chkMaterial.Text = "Material";
            chkMaterial.UseVisualStyleBackColor = false;
            // 
            // chkAmbiente
            // 
            chkAmbiente.AutoSize = true;
            chkAmbiente.BackColor = Color.Transparent;
            chkAmbiente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAmbiente.ForeColor = SystemColors.ButtonHighlight;
            chkAmbiente.Location = new Point(464, 272);
            chkAmbiente.Name = "chkAmbiente";
            chkAmbiente.Size = new Size(87, 21);
            chkAmbiente.TabIndex = 14;
            chkAmbiente.Text = "Ambiente";
            chkAmbiente.UseVisualStyleBackColor = false;
            // 
            // chkOutros
            // 
            chkOutros.AutoSize = true;
            chkOutros.BackColor = Color.Transparent;
            chkOutros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkOutros.ForeColor = SystemColors.HighlightText;
            chkOutros.Location = new Point(576, 272);
            chkOutros.Name = "chkOutros";
            chkOutros.Size = new Size(69, 21);
            chkOutros.TabIndex = 15;
            chkOutros.Text = "Outros";
            chkOutros.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(88, 232);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 16;
            label1.Text = "Pontos  Positivos :";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Bisque;
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(672, 40);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 32);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.CornflowerBlue;
            btnEnviar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviar.ForeColor = Color.Black;
            btnEnviar.Location = new Point(672, 384);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(99, 32);
            btnEnviar.TabIndex = 18;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(184, 16);
            label2.Name = "label2";
            label2.Size = new Size(414, 62);
            label2.TabIndex = 19;
            label2.Tag = "";
            label2.Text = "Pesquisa de Satisfação";
            // 
            // frmSuely
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnEnviar);
            Controls.Add(btnLimpar);
            Controls.Add(label1);
            Controls.Add(chkOutros);
            Controls.Add(chkAmbiente);
            Controls.Add(chkMaterial);
            Controls.Add(chkConteudo);
            Controls.Add(chkProfessores);
            Controls.Add(lblAvaliacao);
            Controls.Add(grpAvaliacao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "frmSuely";
            Text = "S";
            grpAvaliacao.ResumeLayout(false);
            grpAvaliacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblAvaliacao;
        private TextBox txtNome;
        private RadioButton rdbMuitoRuim;
        private RadioButton rdbRuim;
        private RadioButton rdbRegular;
        private RadioButton rdbBom;
        private RadioButton rdbExcelente;
        private GroupBox grpAvaliacao;
        private CheckBox chkProfessores;
        private CheckBox chkConteudo;
        private CheckBox chkMaterial;
        private CheckBox chkAmbiente;
        private CheckBox chkOutros;
        private Label label1;
        private Button btnLimpar;
        private Button btnEnviar;
        private Label label2;
    }
}