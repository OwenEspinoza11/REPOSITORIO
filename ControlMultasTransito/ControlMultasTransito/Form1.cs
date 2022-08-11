namespace ControlMultasTransito
{
    public partial class FmrMultas : Form
    {
        public FmrMultas()
        {
            InitializeComponent();
        }

        private void FmrMultas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //CAPTURANDO LOS DATOS
            string placa = txtPlaca.Text;
            double velocidad = double.Parse(txtVelocidad.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime hora = DateTime.Parse(lblHora.Text);


            //PROCESANDO
            double multa = 0;
            if (velocidad <= 70)
                multa = 0;
            else if (velocidad >= 70 && velocidad <= 90)
                multa = 120;
            else if (velocidad > 90 && velocidad <= 100)
                multa = 240;
            else if (velocidad > 100)
                multa = 350;


            //IMPRIMIENDO RESULTADOS
            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(lblFecha.Text);
            fila.SubItems.Add(lblHora.Text);
            fila.SubItems.Add(velocidad.ToString("0.00"));
            fila.SubItems.Add(multa.ToString("C"));
            lvMultas.Items.Add(fila);
        }

        ListViewItem item;

        private void FmrMultas_MouseClick(object sender, MouseEventArgs e)
        {
            item = lvMultas.GetItemAt(e.X, e.Y);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                lvMultas.Items.Remove(item);
                MessageBox.Show("LA MULTA HA SIDO ELIMINADA");
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA MULTA DE LA LISTA");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Está seguro de salir?",
                                             "Control de multas de tránsito",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
                this.Close();
        }
    }
}