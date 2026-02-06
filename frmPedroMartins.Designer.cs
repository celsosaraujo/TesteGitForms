namespace frmTesteGitForms
{
    partial class frmPedroMartins
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
            picCartaz = new PictureBox();
            lblTitulo = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            groupBox1 = new GroupBox();
            cbHorario = new ComboBox();
            lblHorario = new Label();
            cbFilme = new ComboBox();
            lblFilme = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            lblGenero = new Label();
            lblGenerofixo = new Label();
            groupBox2 = new GroupBox();
            lblTotal = new Label();
            btnLimpar = new Button();
            numQtd = new NumericUpDown();
            lblQuantidade = new Label();
            rbIMAX = new RadioButton();
            rb3D = new RadioButton();
            rb2D = new RadioButton();
            btnConfirmar = new Button();
            btnSair = new Button();
            lblTituloFilme = new Label();
            ((System.ComponentModel.ISupportInitialize)picCartaz).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQtd).BeginInit();
            SuspendLayout();
            // 
            // picCartaz
            // 
            picCartaz.Location = new Point(47, 56);
            picCartaz.Name = "picCartaz";
            picCartaz.Size = new Size(330, 471);
            picCartaz.SizeMode = PictureBoxSizeMode.Zoom;
            picCartaz.TabIndex = 0;
            picCartaz.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AllowDrop = true;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveCaptionText;
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(12, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(172, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Escolha sua sessão";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(61, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(316, 25);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 255);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(316, 25);
            txtNome.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbHorario);
            groupBox1.Controls.Add(lblHorario);
            groupBox1.Controls.Add(cbFilme);
            groupBox1.Controls.Add(lblFilme);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(58, 554);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 343);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados da Sessão";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // cbHorario
            // 
            cbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHorario.FormattingEnabled = true;
            cbHorario.Location = new Point(436, 255);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(136, 25);
            cbHorario.TabIndex = 10;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.ForeColor = SystemColors.ControlLight;
            lblHorario.Location = new Point(436, 217);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(55, 19);
            lblHorario.TabIndex = 9;
            lblHorario.Text = "Horário";
            // 
            // cbFilme
            // 
            cbFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilme.FormattingEnabled = true;
            cbFilme.Location = new Point(436, 122);
            cbFilme.Name = "cbFilme";
            cbFilme.Size = new Size(136, 25);
            cbFilme.TabIndex = 7;
            cbFilme.SelectedIndexChanged += cbFilme_SelectedIndexChanged;
            cbFilme.DropDownStyleChanged += cbFilme_SelectedIndexChanged;
            // 
            // lblFilme
            // 
            lblFilme.AutoSize = true;
            lblFilme.ForeColor = SystemColors.ControlLight;
            lblFilme.Location = new Point(436, 102);
            lblFilme.Name = "lblFilme";
            lblFilme.Size = new Size(41, 19);
            lblFilme.TabIndex = 6;
            lblFilme.Text = "Filme";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.ForeColor = SystemColors.ControlLight;
            lblNome.Location = new Point(61, 235);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 19);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ActiveCaptionText;
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(61, 102);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.ForeColor = SystemColors.ControlLightLight;
            lblGenero.Location = new Point(483, 219);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(0, 19);
            lblGenero.TabIndex = 11;
            // 
            // lblGenerofixo
            // 
            lblGenerofixo.AutoSize = true;
            lblGenerofixo.ForeColor = SystemColors.ControlLight;
            lblGenerofixo.Location = new Point(415, 219);
            lblGenerofixo.Name = "lblGenerofixo";
            lblGenerofixo.Size = new Size(57, 19);
            lblGenerofixo.TabIndex = 8;
            lblGenerofixo.Text = "Genêro:";
            lblGenerofixo.Click += lblGenerofixo_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotal);
            groupBox2.Controls.Add(btnLimpar);
            groupBox2.Controls.Add(numQtd);
            groupBox2.Controls.Add(lblQuantidade);
            groupBox2.Controls.Add(rbIMAX);
            groupBox2.Controls.Add(rb3D);
            groupBox2.Controls.Add(rb2D);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(766, 554);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 343);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de Sessão";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(207, 303);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(91, 19);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "total: R$ 0,00";
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = SystemColors.ControlText;
            btnLimpar.Location = new Point(17, 303);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 28);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // numQtd
            // 
            numQtd.Location = new Point(17, 187);
            numQtd.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numQtd.Name = "numQtd";
            numQtd.Size = new Size(120, 25);
            numQtd.TabIndex = 4;
            numQtd.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQtd.ValueChanged += numQtd_ValueChanged;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(17, 146);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(81, 19);
            lblQuantidade.TabIndex = 3;
            lblQuantidade.Text = "Quantidade";
            // 
            // rbIMAX
            // 
            rbIMAX.AutoSize = true;
            rbIMAX.Location = new Point(218, 80);
            rbIMAX.Name = "rbIMAX";
            rbIMAX.Size = new Size(61, 23);
            rbIMAX.TabIndex = 2;
            rbIMAX.TabStop = true;
            rbIMAX.Text = "IMAX";
            rbIMAX.UseVisualStyleBackColor = true;
            rbIMAX.CheckedChanged += rbIMAX_CheckedChanged;
            // 
            // rb3D
            // 
            rb3D.AutoSize = true;
            rb3D.Location = new Point(119, 80);
            rb3D.Name = "rb3D";
            rb3D.Size = new Size(45, 23);
            rb3D.TabIndex = 1;
            rb3D.TabStop = true;
            rb3D.Text = "3D";
            rb3D.UseVisualStyleBackColor = true;
            rb3D.CheckedChanged += rb3D_CheckedChanged;
            // 
            // rb2D
            // 
            rb2D.AutoSize = true;
            rb2D.Location = new Point(29, 80);
            rb2D.Name = "rb2D";
            rb2D.Size = new Size(45, 23);
            rb2D.TabIndex = 0;
            rb2D.TabStop = true;
            rb2D.Text = "2D";
            rb2D.UseVisualStyleBackColor = true;
            rb2D.CheckedChanged += rb2D_CheckedChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(1133, 906);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(125, 29);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar Sessão";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(1174, 14);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(69, 29);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lblTituloFilme
            // 
            lblTituloFilme.AutoSize = true;
            lblTituloFilme.Font = new Font("Times New Roman", 33F);
            lblTituloFilme.ForeColor = SystemColors.ControlLight;
            lblTituloFilme.Location = new Point(427, 128);
            lblTituloFilme.Name = "lblTituloFilme";
            lblTituloFilme.Size = new Size(0, 51);
            lblTituloFilme.TabIndex = 9;
            // 
            // frmPedroMartins
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1270, 947);
            Controls.Add(lblGenero);
            Controls.Add(lblTituloFilme);
            Controls.Add(btnSair);
            Controls.Add(btnConfirmar);
            Controls.Add(lblGenerofixo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Controls.Add(picCartaz);
            Font = new Font("Segoe UI", 10F);
            Name = "frmPedroMartins";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPedroMartins";
            Load += frmPedroMartins_Load;
            ((System.ComponentModel.ISupportInitialize)picCartaz).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCartaz;
        private Label lblTitulo;
        private TextBox txtEmail;
        private TextBox txtNome;
        private GroupBox groupBox1;
        private Label lblNome;
        private Label lblEmail;
        private Label lblGenerofixo;
        private ComboBox cbFilme;
        private Label lblFilme;
        private ComboBox cbHorario;
        private Label lblHorario;
        private GroupBox groupBox2;
        private NumericUpDown numQtd;
        private Label lblQuantidade;
        private RadioButton rbIMAX;
        private RadioButton rb3D;
        private RadioButton rb2D;
        private Label lblTotal;
        private Button btnConfirmar;
        private Button btnLimpar;
        private Button btnSair;
        private Label lblGenero;
        private Label lblTituloFilme;
    }
}