namespace frmTesteGitForms
{
    partial class frmAffonso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAffonso));
            pictureBox1 = new PictureBox();
            btnVerificar = new Button();
            lblNumero = new Label();
            lblCVV = new Label();
            lblValidade = new Label();
            btnCancelar = new Button();
            txtNumero = new TextBox();
            txtCVV = new TextBox();
            txtValidade = new TextBox();
            lblInfoNum = new Label();
            lblInfoCVV = new Label();
            lblInfoVali = new Label();
            lblRespostaNum = new Label();
            lblRespostaCVV = new Label();
            lblRespostaVal = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(624, 304);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(123, 32);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
          
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = Color.FromArgb(128, 128, 255);
            lblNumero.Location = new Point(43, 101);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(76, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "N° do Cartão";
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.BackColor = Color.FromArgb(128, 128, 255);
            lblCVV.Location = new Point(43, 165);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(29, 15);
            lblCVV.TabIndex = 4;
            lblCVV.Text = "CVV";
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.BackColor = Color.FromArgb(128, 128, 255);
            lblValidade.Location = new Point(176, 165);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(51, 15);
            lblValidade.TabIndex = 5;
            lblValidade.Text = "Validade";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(472, 304);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 32);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(488, 72);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(248, 23);
            txtNumero.TabIndex = 7;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(488, 144);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(104, 23);
            txtCVV.TabIndex = 8;
            // 
            // txtValidade
            // 
            txtValidade.Location = new Point(624, 144);
            txtValidade.Name = "txtValidade";
            txtValidade.Size = new Size(112, 23);
            txtValidade.TabIndex = 9;
            // 
            // lblInfoNum
            // 
            lblInfoNum.AutoSize = true;
            lblInfoNum.Location = new Point(488, 48);
            lblInfoNum.Name = "lblInfoNum";
            lblInfoNum.Size = new Size(76, 15);
            lblInfoNum.TabIndex = 10;
            lblInfoNum.Text = "N° do Cartão";
            // 
            // lblInfoCVV
            // 
            lblInfoCVV.AutoSize = true;
            lblInfoCVV.Location = new Point(488, 120);
            lblInfoCVV.Name = "lblInfoCVV";
            lblInfoCVV.Size = new Size(29, 15);
            lblInfoCVV.TabIndex = 11;
            lblInfoCVV.Text = "CVV";
            // 
            // lblInfoVali
            // 
            lblInfoVali.AutoSize = true;
            lblInfoVali.Location = new Point(632, 120);
            lblInfoVali.Name = "lblInfoVali";
            lblInfoVali.Size = new Size(51, 15);
            lblInfoVali.TabIndex = 12;
            lblInfoVali.Text = "Validade";
            // 
            // lblRespostaNum
            // 
            lblRespostaNum.AutoSize = true;
            lblRespostaNum.BackColor = Color.LightGray;
            lblRespostaNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespostaNum.Location = new Point(57, 125);
            lblRespostaNum.Name = "lblRespostaNum";
            lblRespostaNum.Size = new Size(149, 20);
            lblRespostaNum.TabIndex = 13;
            lblRespostaNum.Text = "0000 0000 0000 0000";
            // 
            // lblRespostaCVV
            // 
            lblRespostaCVV.AutoSize = true;
            lblRespostaCVV.BackColor = Color.LightGray;
            lblRespostaCVV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespostaCVV.Location = new Point(57, 190);
            lblRespostaCVV.Name = "lblRespostaCVV";
            lblRespostaCVV.Size = new Size(33, 20);
            lblRespostaCVV.TabIndex = 14;
            lblRespostaCVV.Text = "000";
            // 
            // lblRespostaVal
            // 
            lblRespostaVal.AutoSize = true;
            lblRespostaVal.BackColor = Color.LightGray;
            lblRespostaVal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespostaVal.Location = new Point(184, 190);
            lblRespostaVal.Name = "lblRespostaVal";
            lblRespostaVal.Size = new Size(47, 20);
            lblRespostaVal.TabIndex = 15;
            lblRespostaVal.Text = "00/00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 384);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 16;
            label1.Text = "*OBS: Apenas para o entreterimento de Vocês \r\nNão levar a serio.\r\n";
            // 
            // frmAffonso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(769, 450);
            Controls.Add(label1);
            Controls.Add(lblRespostaVal);
            Controls.Add(lblRespostaCVV);
            Controls.Add(lblRespostaNum);
            Controls.Add(lblInfoVali);
            Controls.Add(lblInfoCVV);
            Controls.Add(lblInfoNum);
            Controls.Add(txtValidade);
            Controls.Add(txtCVV);
            Controls.Add(txtNumero);
            Controls.Add(btnCancelar);
            Controls.Add(lblValidade);
            Controls.Add(lblCVV);
            Controls.Add(lblNumero);
            Controls.Add(btnVerificar);
            Controls.Add(pictureBox1);
            Name = "frmAffonso";
            Text = "Verificação de Dados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnVerificar;
        private Label lblNumero;
        private Label lblCVV;
        private Label lblValidade;
        private Button btnCancelar;
        private TextBox txtNumero;
        private TextBox txtCVV;
        private TextBox txtValidade;
        private Label lblInfoNum;
        private Label lblInfoCVV;
        private Label lblInfoVali;
        private Label lblRespostaNum;
        private Label lblRespostaCVV;
        private Label lblRespostaVal;
        private Label label1;
    }
}