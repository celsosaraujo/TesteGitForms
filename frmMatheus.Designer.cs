namespace frmTesteGitForms
{
    partial class frmMatheus
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
            lblGeradorDeNumeros = new Label();
            btnSortear = new Button();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // lblGeradorDeNumeros
            // 
            lblGeradorDeNumeros.AutoSize = true;
            lblGeradorDeNumeros.Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGeradorDeNumeros.Location = new Point(195, 68);
            lblGeradorDeNumeros.Name = "lblGeradorDeNumeros";
            lblGeradorDeNumeros.Size = new Size(432, 26);
            lblGeradorDeNumeros.TabIndex = 0;
            lblGeradorDeNumeros.Text = "Sorteio de Rifas 0 a 100";
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(341, 181);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(82, 37);
            btnSortear.TabIndex = 1;
            btnSortear.Text = "Sortear";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnGerar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(315, 125);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(145, 23);
            txtNumero.TabIndex = 2;
            // 
            // frmMatheus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumero);
            Controls.Add(btnSortear);
            Controls.Add(lblGeradorDeNumeros);
            Name = "frmMatheus";
            Text = "frmMatheus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGeradorDeNumeros;
        private Button btnSortear;
        private TextBox txtNumero;
    }
}