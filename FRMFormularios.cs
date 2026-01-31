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

        private void affonsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAffonso tela = new frmAffonso();
            tela.ShowDialog();
        }
    }
}
