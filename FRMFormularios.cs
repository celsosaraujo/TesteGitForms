namespace frmTesteGitForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void celsoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PauloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaulo frmPaulo = new frmPaulo();
            frmPaulo.Show();
        }
    }
}
