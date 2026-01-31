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

        private void gustavoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            using (frmGustavo frmGustavo = new frmGustavo())
            {
                frmGustavo.ShowDialog();
            }
            this.ShowDialog();
            
        }
    }
}
