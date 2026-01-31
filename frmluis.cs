using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTesteGitForms
{
    public partial class frmluis : Form
    {
        public frmluis()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;


        }

        private void frmluis_Load(object sender, EventArgs e)
        {
            int hora = DateTime.Now.Hour;

            if (hora < 12)
                lblMenssagem.Text = "🌅 Bom dia, seja bem-vindo!";
            else if (hora < 18)
                lblMenssagem.Text = "🌤 Boa tarde, seja bem-vindo!";
            else
                lblMenssagem.Text = "🌙 Boa noite, seja bem-vindo!";
        }

        private void lblMenssagem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
