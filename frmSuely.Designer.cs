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
            rdbNota1 = new RadioButton();
            rdbNota2 = new RadioButton();
            rdbNota3 = new RadioButton();
            rdbNota4 = new RadioButton();
            rdbNota5 = new RadioButton();
            grpAvaliacao = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
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
            lblNome.Location = new Point(88, 408);
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
            lblAvaliacao.Location = new Point(168, 120);
            lblAvaliacao.Name = "lblAvaliacao";
            lblAvaliacao.Size = new Size(432, 32);
            lblAvaliacao.TabIndex = 1;
            lblAvaliacao.Text = "Queremos saber como você avalia nosso curso?";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.GradientActiveCaption;
            txtNome.Location = new Point(144, 408);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(432, 23);
            txtNome.TabIndex = 3;
            // 
            // rdbNota1
            // 
            rdbNota1.AutoSize = true;
            rdbNota1.Location = new Point(80, 24);
            rdbNota1.Name = "rdbNota1";
            rdbNota1.Size = new Size(99, 21);
            rdbNota1.TabIndex = 5;
            rdbNota1.TabStop = true;
            rdbNota1.Text = "Muito Ruim";
            rdbNota1.UseVisualStyleBackColor = true;
            // 
            // rdbNota2
            // 
            rdbNota2.AutoSize = true;
            rdbNota2.Location = new Point(208, 24);
            rdbNota2.Name = "rdbNota2";
            rdbNota2.Size = new Size(58, 21);
            rdbNota2.TabIndex = 6;
            rdbNota2.TabStop = true;
            rdbNota2.Text = "Ruim";
            rdbNota2.UseVisualStyleBackColor = true;
            // 
            // rdbNota3
            // 
            rdbNota3.AutoSize = true;
            rdbNota3.Location = new Point(296, 24);
            rdbNota3.Name = "rdbNota3";
            rdbNota3.Size = new Size(73, 21);
            rdbNota3.TabIndex = 7;
            rdbNota3.TabStop = true;
            rdbNota3.Text = "Regular";
            rdbNota3.UseVisualStyleBackColor = true;
            // 
            // rdbNota4
            // 
            rdbNota4.AutoSize = true;
            rdbNota4.Location = new Point(408, 24);
            rdbNota4.Name = "rdbNota4";
            rdbNota4.Size = new Size(54, 21);
            rdbNota4.TabIndex = 8;
            rdbNota4.TabStop = true;
            rdbNota4.Text = "Bom";
            rdbNota4.UseVisualStyleBackColor = true;
            // 
            // rdbNota5
            // 
            rdbNota5.AutoSize = true;
            rdbNota5.Location = new Point(488, 24);
            rdbNota5.Name = "rdbNota5";
            rdbNota5.Size = new Size(84, 21);
            rdbNota5.TabIndex = 9;
            rdbNota5.TabStop = true;
            rdbNota5.Text = "Excelente";
            rdbNota5.UseVisualStyleBackColor = true;
            // 
            // grpAvaliacao
            // 
            grpAvaliacao.BackColor = Color.Transparent;
            grpAvaliacao.Controls.Add(rdbNota5);
            grpAvaliacao.Controls.Add(rdbNota1);
            grpAvaliacao.Controls.Add(rdbNota4);
            grpAvaliacao.Controls.Add(rdbNota2);
            grpAvaliacao.Controls.Add(rdbNota3);
            grpAvaliacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAvaliacao.ForeColor = SystemColors.ButtonHighlight;
            grpAvaliacao.Location = new Point(88, 168);
            grpAvaliacao.Name = "grpAvaliacao";
            grpAvaliacao.Size = new Size(608, 56);
            grpAvaliacao.TabIndex = 10;
            grpAvaliacao.TabStop = false;
            grpAvaliacao.Text = "Nota";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(88, 272);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 21);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Professores";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = SystemColors.ButtonHighlight;
            checkBox2.Location = new Point(216, 272);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 21);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Conteúdo";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.ForeColor = SystemColors.ButtonHighlight;
            checkBox3.Location = new Point(320, 272);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(76, 21);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Material";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Transparent;
            checkBox4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox4.ForeColor = SystemColors.ButtonHighlight;
            checkBox4.Location = new Point(416, 272);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(86, 21);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "Ambiente";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Transparent;
            checkBox5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox5.ForeColor = SystemColors.Control;
            checkBox5.Location = new Point(520, 272);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(69, 21);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "Outros";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(88, 240);
            label1.Name = "label1";
            label1.Size = new Size(120, 16);
            label1.TabIndex = 16;
            label1.Text = "Pontos  Positivos :";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Bisque;
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(680, 40);
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
            btnEnviar.Location = new Point(672, 400);
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
            label2.Location = new Point(184, 32);
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
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
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
        private RadioButton rdbNota1;
        private RadioButton rdbNota2;
        private RadioButton rdbNota3;
        private RadioButton rdbNota4;
        private RadioButton rdbNota5;
        private GroupBox grpAvaliacao;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label1;
        private Button btnLimpar;
        private Button btnEnviar;
        private Label label2;
    }
}