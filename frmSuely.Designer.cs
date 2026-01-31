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
            lblNome = new Label();
            lblAvaliacao = new Label();
            txtNome = new TextBox();
            lblTitulo = new Label();
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
            grpAvaliacao.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(136, 104);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 17);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblAvaliacao
            // 
            lblAvaliacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvaliacao.Location = new Point(232, 152);
            lblAvaliacao.Name = "lblAvaliacao";
            lblAvaliacao.Size = new Size(280, 32);
            lblAvaliacao.TabIndex = 1;
            lblAvaliacao.Text = "Como você avalia nosso curso?";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(192, 104);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(360, 23);
            txtNome.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(200, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(377, 47);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Pesquisa de Satisfação";
            // 
            // rdbNota1
            // 
            rdbNota1.AutoSize = true;
            rdbNota1.Location = new Point(8, 32);
            rdbNota1.Name = "rdbNota1";
            rdbNota1.Size = new Size(93, 21);
            rdbNota1.TabIndex = 5;
            rdbNota1.TabStop = true;
            rdbNota1.Text = "Muito Ruim";
            rdbNota1.UseVisualStyleBackColor = true;
            // 
            // rdbNota2
            // 
            rdbNota2.AutoSize = true;
            rdbNota2.Location = new Point(128, 32);
            rdbNota2.Name = "rdbNota2";
            rdbNota2.Size = new Size(55, 21);
            rdbNota2.TabIndex = 6;
            rdbNota2.TabStop = true;
            rdbNota2.Text = "Ruim";
            rdbNota2.UseVisualStyleBackColor = true;
            // 
            // rdbNota3
            // 
            rdbNota3.AutoSize = true;
            rdbNota3.Location = new Point(224, 32);
            rdbNota3.Name = "rdbNota3";
            rdbNota3.Size = new Size(71, 21);
            rdbNota3.TabIndex = 7;
            rdbNota3.TabStop = true;
            rdbNota3.Text = "Regular";
            rdbNota3.UseVisualStyleBackColor = true;
            // 
            // rdbNota4
            // 
            rdbNota4.AutoSize = true;
            rdbNota4.Location = new Point(328, 32);
            rdbNota4.Name = "rdbNota4";
            rdbNota4.Size = new Size(52, 21);
            rdbNota4.TabIndex = 8;
            rdbNota4.TabStop = true;
            rdbNota4.Text = "Bom";
            rdbNota4.UseVisualStyleBackColor = true;
            // 
            // rdbNota5
            // 
            rdbNota5.AutoSize = true;
            rdbNota5.Location = new Point(408, 32);
            rdbNota5.Name = "rdbNota5";
            rdbNota5.Size = new Size(80, 21);
            rdbNota5.TabIndex = 9;
            rdbNota5.TabStop = true;
            rdbNota5.Text = "Excelente";
            rdbNota5.UseVisualStyleBackColor = true;
            // 
            // grpAvaliacao
            // 
            grpAvaliacao.Controls.Add(rdbNota5);
            grpAvaliacao.Controls.Add(rdbNota1);
            grpAvaliacao.Controls.Add(rdbNota4);
            grpAvaliacao.Controls.Add(rdbNota2);
            grpAvaliacao.Controls.Add(rdbNota3);
            grpAvaliacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpAvaliacao.Location = new Point(144, 184);
            grpAvaliacao.Name = "grpAvaliacao";
            grpAvaliacao.Size = new Size(496, 72);
            grpAvaliacao.TabIndex = 10;
            grpAvaliacao.TabStop = false;
            grpAvaliacao.Text = "Nota";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(152, 312);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Professores";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(264, 312);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Conteúdo";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(368, 312);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(69, 19);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Material";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(472, 312);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(78, 19);
            checkBox4.TabIndex = 14;
            checkBox4.Text = "Ambiente";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(576, 312);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(62, 19);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "Outros";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(152, 280);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 16;
            label1.Text = "Pontos  Positivos :";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(456, 384);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(96, 23);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(616, 384);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(99, 23);
            btnEnviar.TabIndex = 18;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // frmSuely
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(lblTitulo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "frmSuely";
            Text = "frmSuely";
            grpAvaliacao.ResumeLayout(false);
            grpAvaliacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblAvaliacao;
        private TextBox txtNome;
        private Label lblTitulo;
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
    }
}