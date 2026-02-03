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

        private void mnuCelso_Click(object sender, EventArgs e)
        {
            frmCelso tela = new frmCelso();
            tela.ShowDialog();
        }

        private void mnuThiago_Click(object sender, EventArgs e)
        {
            frmThiago tela = new frmThiago();
            tela.ShowDialog();
        }
    }
}
