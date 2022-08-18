namespace pjSegurosVida
{
    public partial class frmProforma : Form
    {
        public frmProforma()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturando los datos
            string razon = txtRazonSocial.Text;
            string tipo = cboTipo.Text;
            int cantidad = int.Parse(txtCantidad.Text);

            //Calculando el pago mensual por tipo de seguro
            double pagoMensual = 0;
            switch (tipo)

            {
                case "Inversión Clásica":
                    if (cantidad <= 10)
                        pagoMensual = 50 * cantidad;
                    else
                        pagoMensual = (50 * cantidad) + (10 * (cantidad - 10));
                    break;


                case "Inversión Platino":
                    if (cantidad <= 9)
                        pagoMensual = 80 * cantidad;
                    else
                        pagoMensual = (80 * cantidad) + (8 * (cantidad - 9));
                    break;


                case "Inversión Oro":
                    if (cantidad <= 6)
                        pagoMensual = 150 * cantidad;
                    else
                        pagoMensual = (150 * cantidad) + (15 * (cantidad - 6));
                    break;
            }

            // Imprimiendo detalle de la proforma
            ListViewItem fila = new ListViewItem(tipo);
            fila.SubItems.Add(cantidad.ToString());
            fila.SubItems.Add(pagoMensual.ToString("0.00"));
            lvProforma.Items.Add(fila);
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            // Determinar el total de personas aseguradas
            int totalAsegurados = 0;
            for (int i = 0; i < lvProforma.Items.Count; i++)
            {
                if (lvProforma.Items[i].SubItems[0].Text != "")
                    totalAsegurados += int.Parse(lvProforma.Items[i].SubItems[1].Text);
            }

            //Determinar el monto total acumulado a cancelar
            double total = 0;
            for (int i = 0; i < lvProforma.Items.Count; i++)
            {
                if (lvProforma.Items[i].SubItems[0].Text != "")
                    total += double.Parse(lvProforma.Items[i].SubItems[2].Text);
            }

            //Impresión de las estadísticas
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Total de personas aseguradas";
            elementosFila[1] = totalAsegurados.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto total a cancelar";
            elementosFila[1] = total.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Está seguro de anular la proforma?",
                                             "Seguros",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
            {
                txtRazonSocial.Clear();
                cboTipo.Text = "(Seleccione tipo)";
                txtCantidad.Clear();
                txtRazonSocial.Focus();
                lvProforma.Items.Clear();
                lvEstadisticas.Items.Clear();
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Está seguro de salir?",
                                             "Seguros",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}