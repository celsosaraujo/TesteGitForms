namespace frmTesteGitForms
{
    partial class FRMHanna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMHanna));
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtCVV = new TextBox();
            lblCVV = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtcardNome = new TextBox();
            txtcardCVV = new TextBox();
            txtcardNumero = new TextBox();
            gbxDadosPessoais = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnFinalizar = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbxDadosPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "inter.png");
            imageList1.Images.SetKeyName(1, "tela azul.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(25, 32);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(21, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "N°";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(49, 32);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(136, 23);
            txtNumero.TabIndex = 2;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(272, 32);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(56, 23);
            txtCVV.TabIndex = 4;
            txtCVV.TextChanged += txtCVV_TextChanged;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Location = new Point(240, 32);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(29, 15);
            lblCVV.TabIndex = 3;
            lblCVV.Text = "CVV";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(48, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(208, 23);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(8, 88);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtcardNome
            // 
            txtcardNome.BackColor = Color.Silver;
            txtcardNome.BorderStyle = BorderStyle.None;
            txtcardNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtcardNome.Location = new Point(40, 195);
            txtcardNome.Name = "txtcardNome";
            txtcardNome.ReadOnly = true;
            txtcardNome.Size = new Size(224, 16);
            txtcardNome.TabIndex = 9;
            // 
            // txtcardCVV
            // 
            txtcardCVV.BackColor = Color.Silver;
            txtcardCVV.BorderStyle = BorderStyle.None;
            txtcardCVV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtcardCVV.Location = new Point(304, 138);
            txtcardCVV.Name = "txtcardCVV";
            txtcardCVV.ReadOnly = true;
            txtcardCVV.Size = new Size(48, 16);
            txtcardCVV.TabIndex = 8;
            // 
            // txtcardNumero
            // 
            txtcardNumero.BackColor = Color.Silver;
            txtcardNumero.BorderStyle = BorderStyle.None;
            txtcardNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtcardNumero.Location = new Point(40, 138);
            txtcardNumero.Name = "txtcardNumero";
            txtcardNumero.ReadOnly = true;
            txtcardNumero.Size = new Size(136, 16);
            txtcardNumero.TabIndex = 7;
            // 
            // gbxDadosPessoais
            // 
            gbxDadosPessoais.BackColor = Color.Transparent;
            gbxDadosPessoais.Controls.Add(txtNome);
            gbxDadosPessoais.Controls.Add(lblNome);
            gbxDadosPessoais.Controls.Add(txtCVV);
            gbxDadosPessoais.Controls.Add(lblCVV);
            gbxDadosPessoais.Controls.Add(txtNumero);
            gbxDadosPessoais.Controls.Add(lblNumero);
            gbxDadosPessoais.Location = new Point(400, 32);
            gbxDadosPessoais.Name = "gbxDadosPessoais";
            gbxDadosPessoais.Size = new Size(352, 128);
            gbxDadosPessoais.TabIndex = 10;
            gbxDadosPessoais.TabStop = false;
            gbxDadosPessoais.Text = "Dados Pessoais";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(40, 178);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(304, 122);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 8;
            label2.Text = "CVV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(40, 121);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 7;
            label3.Text = "N°";
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(255, 128, 0);
            btnFinalizar.Enabled = false;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Location = new Point(520, 184);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(112, 40);
            btnFinalizar.TabIndex = 11;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1920, 1080);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // FRMHanna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(781, 300);
            Controls.Add(pictureBox2);
            Controls.Add(btnFinalizar);
            Controls.Add(label1);
            Controls.Add(gbxDadosPessoais);
            Controls.Add(label2);
            Controls.Add(txtcardNome);
            Controls.Add(label3);
            Controls.Add(txtcardCVV);
            Controls.Add(txtcardNumero);
            Controls.Add(pictureBox1);
            Name = "FRMHanna";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbxDadosPessoais.ResumeLayout(false);
            gbxDadosPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtCVV;
        private Label lblCVV;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtcardNome;
        private TextBox txtcardCVV;
        private TextBox txtcardNumero;
        private GroupBox gbxDadosPessoais;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnFinalizar;
        private PictureBox pictureBox2;
    }
}