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
    public partial class frmMatheus : Form
    {
        public frmMatheus()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int numeroAleatorio = random.Next(0, 101); //gera de 0 a 101
            

            txtNumero.Text = numeroAleatorio.ToString();
        }
    }
}
