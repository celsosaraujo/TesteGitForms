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
            // frmluis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.ChatGPT_Image_30_de_jan__de_2026__21_17_46;
            ClientSize = new Size(799, 594);
            Controls.Add(lblMenssagem);
            Controls.Add(lblHora);
            Controls.Add(dateTimePicker1);
            Name = "frmluis";
            Text = "Formulário do Luis";
            Load += frmluis_Load;
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lblHora;
        private Label lblMenssagem;
    }
}