namespace pjBoletaVenta
{
    public partial class frmBoletaVenta : Form
    {
        public frmBoletaVenta()
        {
            InitializeComponent();
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
            mostrarFecha();
            mostrarMesActual();
        }
    }
}