namespace frmTesteGitForms
{
    partial class frmluis
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
            dateTimePicker1 = new DateTimePicker();
            lblHora = new Label();
            lblMenssagem = new Label();
            btnSigno = new Button();
            dtNascimento = new DateTimePicker();
            lblResultado = new Label();
            lblDigiteseusigno = new Label();
            lblPergunta = new Label();
            btnVerificar = new Button();
            txtResposta = new TextBox();
            lblResultadoPuzzle = new Label();
            btnNovaPergunta = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Dock = DockStyle.Bottom;
            dateTimePicker1.Location = new Point(0, 571);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(799, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // lblHora
            // 
            lblHora.BackColor = Color.White;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ControlText;
            lblHora.Location = new Point(700, 577);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(66, 14);
            lblHora.TabIndex = 1;
            lblHora.Text = "00:00:00";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMenssagem
            // 
            lblMenssagem.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblMenssagem.Location = new Point(340, 571);
            lblMenssagem.Name = "lblMenssagem";
            lblMenssagem.Size = new Size(202, 20);
            lblMenssagem.TabIndex = 2;
            lblMenssagem.TextAlign = ContentAlignment.MiddleCenter;
            lblMenssagem.Click += lblMenssagem_Click;
            // 
            // btnSigno
            // 
            btnSigno.BackColor = Color.MediumPurple;
            btnSigno.Font = new Font("Segoe UI", 21.75F);
            btnSigno.Location = new Point(12, 277);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(192, 47);
            btnSigno.TabIndex = 3;
            btnSigno.Text = "Resultado";
            btnSigno.UseVisualStyleBackColor = false;
            btnSigno.Click += button1_Click;
            // 
            // dtNascimento
            // 
            dtNascimento.Font = new Font("Segoe UI", 21.75F);
            dtNascimento.Location = new Point(12, 225);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(279, 46);
            dtNascimento.TabIndex = 4;
            dtNascimento.ValueChanged += dtNascimento_ValueChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 21.75F);
            lblResultado.Location = new Point(210, 280);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 40);
            lblResultado.TabIndex = 5;
            lblResultado.Click += lblResultado_Click;
            // 
            // lblDigiteseusigno
            // 
            lblDigiteseusigno.AutoSize = true;
            lblDigiteseusigno.BackColor = Color.MediumSlateBlue;
            lblDigiteseusigno.Font = new Font("Segoe UI", 21.75F);
            lblDigiteseusigno.Location = new Point(12, 182);
            lblDigiteseusigno.Name = "lblDigiteseusigno";
            lblDigiteseusigno.Size = new Size(677, 40);
            lblDigiteseusigno.TabIndex = 6;
            lblDigiteseusigno.Text = "Digite sua data de nascimento e descubra seu signo";
            // 
            // lblPergunta
            // 
            lblPergunta.AutoSize = true;
            lblPergunta.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(142, 415);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(131, 40);
            lblPergunta.TabIndex = 7;
            lblPergunta.Text = "Pergunta";
            lblPergunta.Click += lblPergunta_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(11, 511);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(261, 45);
            btnVerificar.TabIndex = 8;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtResposta
            // 
            txtResposta.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResposta.Location = new Point(287, 461);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(255, 46);
            txtResposta.TabIndex = 9;
            // 
            // lblResultadoPuzzle
            // 
            lblResultadoPuzzle.AutoSize = true;
            lblResultadoPuzzle.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultadoPuzzle.Location = new Point(287, 513);
            lblResultadoPuzzle.Name = "lblResultadoPuzzle";
            lblResultadoPuzzle.Size = new Size(0, 40);
            lblResultadoPuzzle.TabIndex = 10;
            // 
            // btnNovaPergunta
            // 
            btnNovaPergunta.Location = new Point(12, 411);
            btnNovaPergunta.Name = "btnNovaPergunta";
            btnNovaPergunta.Size = new Size(124, 44);
            btnNovaPergunta.TabIndex = 11;
            btnNovaPergunta.Text = "Nova Pergunta";
            btnNovaPergunta.UseVisualStyleBackColor = true;
            btnNovaPergunta.Click += btnNovaPergunta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 464);
            label1.Name = "label1";
            label1.Size = new Size(260, 40);
            label1.TabIndex = 12;
            label1.Text = "Digite sua resposta";
            label1.Click += label1_Click;
            // 
            // frmluis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.ChatGPT_Image_30_de_jan__de_2026__21_17_46;
            ClientSize = new Size(799, 594);
            Controls.Add(label1);
            Controls.Add(btnNovaPergunta);
            Controls.Add(lblResultadoPuzzle);
            Controls.Add(txtResposta);
            Controls.Add(btnVerificar);
            Controls.Add(lblPergunta);
            Controls.Add(lblDigiteseusigno);
            Controls.Add(lblResultado);
            Controls.Add(dtNascimento);
            Controls.Add(btnSigno);
            Controls.Add(lblMenssagem);
            Controls.Add(lblHora);
            Controls.Add(dateTimePicker1);
            Name = "frmluis";
            Text = "Formulário do Luis";
            Load += frmluis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblHora;
        private Label lblMenssagem;
        private Button btnSigno;
        private DateTimePicker dtNascimento;
        private Label lblResultado;
        private Label lblDigiteseusigno;
        private Label lblPergunta;
        private Button btnVerificar;
        private TextBox txtResposta;
        private Label lblResultadoPuzzle;
        private Button btnNovaPergunta;
        private Label label1;
    }
}