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

        private void suelyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuely frmSuely = new frmSuely();
            frmSuely.ShowDialog();

        }
    }
}
