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

        private void mniPedro_Click(object sender, EventArgs e)
        {
            frmPedroMartins frmPedroMartins = new frmPedroMartins();
            frmPedroMartins.ShowDialog();

        }
    }
}
