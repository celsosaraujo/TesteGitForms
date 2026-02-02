namespace frmTesteGitForms
{
    partial class frmThiago
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
            txtNome = new TextBox();
            pictureBox1 = new PictureBox();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(8, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(352, 480);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(136, 33);
            txtNome.TabIndex = 1;
            txtNome.Text = "Thiago Freitas";
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_2_de_fev__de_2026__19_49_43;
            pictureBox1.Location = new Point(0, 488);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(384, 16);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(104, 23);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar imagem";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // frmThiago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.status_deus_1;
            ClientSize = new Size(496, 541);
            Controls.Add(btnMostrar);
            Controls.Add(txtNome);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Name = "frmThiago";
            Text = "Formulário  do Thiago";
            Load += frmThiago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private TextBox txtNome;
        private PictureBox pictureBox1;
        private Button btnMostrar;
    }
}