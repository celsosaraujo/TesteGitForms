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
            picVerso = new PictureBox();
            btnVerificar = new Button();
            lblCVV = new Label();
            btnCancelar = new Button();
            txtNumero = new TextBox();
            txtCVV = new TextBox();
            txtValidade = new TextBox();
            lblInfoNum = new Label();
            lblInfoCVV = new Label();
            lblInfoVali = new Label();
            lblRespostaCVV = new Label();
            lblRespostaVal = new Label();
            picFrente = new PictureBox();
            lblRespostaNum = new Label();
            btnVerso = new Button();
            btnFrente = new Button();
            ((System.ComponentModel.ISupportInitialize)picVerso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFrente).BeginInit();
            SuspendLayout();
            // 
            // picVerso
            // 
            picVerso.BackColor = SystemColors.AppWorkspace;
            picVerso.Image = (Image)resources.GetObject("picVerso.Image");
            picVerso.Location = new Point(8, 32);
            picVerso.Name = "picVerso";
            picVerso.Size = new Size(424, 232);
            picVerso.SizeMode = PictureBoxSizeMode.CenterImage;
            picVerso.TabIndex = 1;
            picVerso.TabStop = false;
            picVerso.Visible = false;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(624, 304);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(123, 32);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.BackColor = Color.FromArgb(128, 128, 255);
            lblCVV.Location = new Point(43, 165);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(0, 15);
            lblCVV.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(472, 304);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 32);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            lblInfoNum.BackColor = Color.Transparent;
            lblInfoNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoNum.ForeColor = Color.White;
            lblInfoNum.Location = new Point(488, 48);
            lblInfoNum.Name = "lblInfoNum";
            lblInfoNum.Size = new Size(87, 17);
            lblInfoNum.TabIndex = 10;
            lblInfoNum.Text = "N° do Cartão";
            // 
            // lblInfoCVV
            // 
            lblInfoCVV.AutoSize = true;
            lblInfoCVV.BackColor = Color.Transparent;
            lblInfoCVV.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoCVV.ForeColor = Color.White;
            lblInfoCVV.Location = new Point(488, 120);
            lblInfoCVV.Name = "lblInfoCVV";
            lblInfoCVV.Size = new Size(34, 17);
            lblInfoCVV.TabIndex = 11;
            lblInfoCVV.Text = "CVV";
            // 
            // lblInfoVali
            // 
            lblInfoVali.AutoSize = true;
            lblInfoVali.BackColor = Color.Transparent;
            lblInfoVali.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoVali.ForeColor = Color.White;
            lblInfoVali.Location = new Point(632, 120);
            lblInfoVali.Name = "lblInfoVali";
            lblInfoVali.Size = new Size(61, 17);
            lblInfoVali.TabIndex = 12;
            lblInfoVali.Text = "Validade";
            // 
            // lblRespostaCVV
            // 
            lblRespostaCVV.AutoSize = true;
            lblRespostaCVV.BackColor = Color.LightGray;
            lblRespostaCVV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespostaCVV.Location = new Point(94, 195);
            lblRespostaCVV.Name = "lblRespostaCVV";
            lblRespostaCVV.Size = new Size(33, 20);
            lblRespostaCVV.TabIndex = 14;
            lblRespostaCVV.Text = "000";
            lblRespostaCVV.Visible = false;
            // 
            // lblRespostaVal
            // 
            lblRespostaVal.AutoSize = true;
            lblRespostaVal.BackColor = Color.LightGray;
            lblRespostaVal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespostaVal.Location = new Point(224, 195);
            lblRespostaVal.Name = "lblRespostaVal";
            lblRespostaVal.Size = new Size(47, 20);
            lblRespostaVal.TabIndex = 15;
            lblRespostaVal.Text = "00/00";
            lblRespostaVal.Visible = false;
            // 
            // picFrente
            // 
            picFrente.BackColor = SystemColors.AppWorkspace;
            picFrente.Image = (Image)resources.GetObject("picFrente.Image");
            picFrente.Location = new Point(8, 32);
            picFrente.Name = "picFrente";
            picFrente.Size = new Size(424, 232);
            picFrente.SizeMode = PictureBoxSizeMode.CenterImage;
            picFrente.TabIndex = 19;
            picFrente.TabStop = false;
            picFrente.Click += picFrente_Click;
            // 
            // lblRespostaNum
            // 
            lblRespostaNum.AutoSize = true;
            lblRespostaNum.BackColor = Color.LightGray;
            lblRespostaNum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRespostaNum.Location = new Point(104, 178);
            lblRespostaNum.Name = "lblRespostaNum";
            lblRespostaNum.Size = new Size(149, 20);
            lblRespostaNum.TabIndex = 20;
            lblRespostaNum.Text = "0000 0000 0000 0000";
            // 
            // btnVerso
            // 
            btnVerso.FlatAppearance.BorderSize = 0;
            btnVerso.FlatStyle = FlatStyle.Flat;
            btnVerso.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerso.ForeColor = Color.Black;
            btnVerso.Location = new Point(64, 272);
            btnVerso.Name = "btnVerso";
            btnVerso.Size = new Size(123, 32);
            btnVerso.TabIndex = 22;
            btnVerso.Text = "Verso";
            btnVerso.UseVisualStyleBackColor = true;
            btnVerso.Click += btnVerso_Click;
            // 
            // btnFrente
            // 
            btnFrente.BackColor = Color.MediumPurple;
            btnFrente.FlatAppearance.BorderSize = 0;
            btnFrente.FlatStyle = FlatStyle.Flat;
            btnFrente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrente.Location = new Point(216, 272);
            btnFrente.Name = "btnFrente";
            btnFrente.Size = new Size(123, 32);
            btnFrente.TabIndex = 21;
            btnFrente.Text = "Frente";
            btnFrente.UseVisualStyleBackColor = false;
            btnFrente.Click += btnFrente_Click;
            // 
            // frmAffonso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.building_background_kdftxs3qeo83kypr;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(769, 450);
            Controls.Add(btnVerso);
            Controls.Add(btnFrente);
            Controls.Add(lblRespostaNum);
            Controls.Add(picFrente);
            Controls.Add(lblRespostaVal);
            Controls.Add(lblRespostaCVV);
            Controls.Add(lblInfoVali);
            Controls.Add(lblInfoCVV);
            Controls.Add(lblInfoNum);
            Controls.Add(txtValidade);
            Controls.Add(txtCVV);
            Controls.Add(txtNumero);
            Controls.Add(btnCancelar);
            Controls.Add(lblCVV);
            Controls.Add(btnVerificar);
            Controls.Add(picVerso);
            Name = "frmAffonso";
            Text = "Verificação de Dados";
            Load += frmAffonso_Load;
            ((System.ComponentModel.ISupportInitialize)picVerso).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFrente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picVerso;
        private Button btnVerificar;
        private Label lblCVV;
        private Button btnCancelar;
        private TextBox txtNumero;
        private TextBox txtCVV;
        private TextBox txtValidade;
        private Label lblInfoNum;
        private Label lblInfoCVV;
        private Label lblInfoVali;
        private Label lblRespostaCVV;
        private Label lblRespostaVal;
        private PictureBox picFrente;
        private Label lblRespostaNum;
        private Button btnVerso;
        private Button btnFrente;
    }
}