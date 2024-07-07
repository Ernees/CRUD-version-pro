namespace FrmPrincipal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCrear frmCrear = new FrmCrear();
            frmCrear.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
