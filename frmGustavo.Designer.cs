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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGustavo));
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
            btnSoma.BackColor = Color.DodgerBlue;
            btnSoma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSoma.ForeColor = Color.White;
            btnSoma.Location = new Point(48, 224);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(160, 64);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.DodgerBlue;
            btnSubtracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.ForeColor = Color.White;
            btnSubtracao.Location = new Point(232, 224);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(160, 64);
            btnSubtracao.TabIndex = 4;
            btnSubtracao.Text = "Subtração";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.DodgerBlue;
            btnMultiplicacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = Color.White;
            btnMultiplicacao.Location = new Point(48, 304);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(160, 64);
            btnMultiplicacao.TabIndex = 5;
            btnMultiplicacao.Text = "Multiplicação";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.DodgerBlue;
            btnDivisao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(232, 304);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(160, 64);
            btnDivisao.TabIndex = 6;
            btnDivisao.Text = "Divisão";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 16F);
            txtNum1.Location = new Point(56, 88);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(88, 36);
            txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 16F);
            txtNum2.Location = new Point(304, 88);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(88, 36);
            txtNum2.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 16F);
            txtResultado.Location = new Point(176, 160);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(104, 36);
            txtResultado.TabIndex = 6;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNum1.ForeColor = Color.White;
            lblNum1.Location = new Point(56, 64);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(86, 21);
            lblNum1.TabIndex = 7;
            lblNum1.Text = "Número 1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNum2.ForeColor = Color.White;
            lblNum2.Location = new Point(304, 64);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(86, 21);
            lblNum2.TabIndex = 8;
            lblNum2.Text = "Número 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblResultado.ForeColor = Color.White;
            lblResultado.Location = new Point(184, 136);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(86, 21);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "Resultado";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(168, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 32);
            btnClear.TabIndex = 7;
            btnClear.Text = "Apagar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmGustavo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
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
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmGustavo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gustavo";
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