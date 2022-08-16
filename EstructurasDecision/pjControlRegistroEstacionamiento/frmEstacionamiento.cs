namespace pjControlRegistroEstacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        
        string dia;

        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            //MOSTRANDO LA FECHA ACTUAL
            lblFecha.Text = DateTime.Now.ToShortDateString();

            //DETERMINAR EL DIA
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            dia = fecha.ToString("dddd");

            double costo = 0;
            switch(dia)
            {

                case "domingo": costo = 2; break;
                case "lunes":
                case "martes":
                case "miércoles":
                case "jueves":
                    costo = 4; break;
                case "viernes":
                case "sábado":
                    costo = 7; break;
            }
            lblCosto.Text = costo.ToString("0.00");

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //CAPTURANDO LOS DATOS DEL FORMULARIO
            string placa = txtPlaca.Text;
            double costo = double.Parse(lblCosto.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaFin = DateTime.Parse(txtHoraFin.Text);

            //CALCULAR LA HORA
            TimeSpan hora = horaFin - horaInicio;

            //CALCULAR EL IMPORTE
            double importe = costo * (hora.TotalHours);

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(horaInicio.ToString("t"));
            fila.SubItems.Add(horaFin.ToString("t"));
            fila.SubItems.Add(hora.TotalHours.ToString());
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(importe.ToString("C"));
            lvRegistro.Items.Add(fila);
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtHoraInicio.Clear();
            txtHoraFin.Clear();
            txtPlaca.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Está seguro de salir",
                                             "Estacionamiento",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}