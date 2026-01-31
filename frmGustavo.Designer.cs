namespace frmTesteGitForms
{
    partial class frmGustavo
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
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResultado = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblResultado = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(48, 224);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(160, 64);
            btnSoma.TabIndex = 0;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(232, 224);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(160, 64);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.Text = "Subtração";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(48, 304);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(160, 64);
            btnMultiplicacao.TabIndex = 2;
            btnMultiplicacao.Text = "Multiplicação";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(232, 304);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(160, 64);
            btnDivisao.TabIndex = 3;
            btnDivisao.Text = "Divisão";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 16F);
            txtNum1.Location = new Point(64, 88);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(80, 36);
            txtNum1.TabIndex = 4;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 16F);
            txtNum2.Location = new Point(296, 88);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(80, 36);
            txtNum2.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Segoe UI", 16F);
            txtResultado.Location = new Point(184, 160);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(80, 36);
            txtResultado.TabIndex = 6;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(72, 64);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 7;
            lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(304, 64);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 8;
            lblNum2.Text = "Número 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(192, 136);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(176, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Apagar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmGustavo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(btnClear);
            Controls.Add(lblResultado);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Name = "frmGustavo";
            Text = "frmGustavo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResultado;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblResultado;
        private Button btnClear;
    }
}