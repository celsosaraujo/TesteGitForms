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

        private void hannaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMHanna frmHanna = new FRMHanna();
            frmHanna.ShowDialog();
        }
    }
}
