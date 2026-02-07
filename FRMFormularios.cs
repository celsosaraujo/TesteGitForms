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

        private void mniElias_Click(object sender, EventArgs e)
        {
            FRMFElias batalha = new FRMFElias();
            batalha.Owner = this;
            batalha.Show();
            this.Hide();
        }
    }
}