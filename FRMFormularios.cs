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

        private void diegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiego frmDiego = new FrmDiego();
            frmDiego.ShowDialog();
            
        }
    }
}
