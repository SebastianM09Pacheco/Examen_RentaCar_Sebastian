using System.Globalization;

namespace RentaCarExpress
{
    public partial class frmAlquiler : Form
    {
        private decimal subtotalAcumulado = 0m;
        private readonly CultureInfo cultura = CultureInfo.GetCultureInfo("en-US");

        public frmAlquiler()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            Text = "RentaCar Express - Alquileres";
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;
            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            nudDias.Value = 1;
            dtpSalida.Value = DateTime.Today;
            lblEncabezado.Text =
                "Días".PadRight(6) +
                "Vehículo".PadRight(25) +
                "Tarifa".PadLeft(12) +
                "Total".PadLeft(12);
            MostrarResultados(0m, 0m, 0m, 0m, 0m);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string vehiculo = txtVehiculo.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Escriba el nombre del cliente.", "Dato requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(vehiculo))
            {
                MessageBox.Show("Escriba el nombre del vehículo.", "Dato requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVehiculo.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text.Trim(), NumberStyles.Number,
                    cultura, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("Introduzca una tarifa diaria válida.", "Tarifa inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                return;
            }

            int dias = Decimal.ToInt32(nudDias.Value);
            decimal tarifaDiaria = tarifa;

            if (rbtCompleto.Checked)
                tarifaDiaria += 300m;

            if (chkGps.Checked)
                tarifaDiaria += 100m;

            decimal totalLinea = tarifaDiaria * dias;

            string servicios = rbtCompleto.Checked ? "Completo" : "Básico";
            if (chkGps.Checked)
                servicios += ", GPS";

            string descripcion = $"{vehiculo} ({servicios})";
            string linea =
                dias.ToString().PadRight(6) +
                descripcion.PadRight(25) +
                tarifaDiaria.ToString("N2", cultura).PadLeft(12) +
                totalLinea.ToString("N2", cultura).PadLeft(12);

            lstAlquileres.Items.Add(linea);
            subtotalAcumulado += totalLinea;
            lblSubtotal.Text = FormatearDinero(subtotalAcumulado);

            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un vehículo antes de calcular.",
                    "Sin alquileres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal descuento = chkCorporativo.Checked
                ? subtotalAcumulado * 0.15m
                : 0m;

            decimal domicilio = rbtDomicilio.Checked ? 500m : 0m;
            decimal baseImponible = subtotalAcumulado - descuento + domicilio;
            decimal itbis = baseImponible * 0.18m;
            decimal total = baseImponible + itbis;

            MostrarResultados(subtotalAcumulado, descuento, domicilio, itbis, total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();
            chkCorporativo.Checked = false;
            chkGps.Checked = false;
            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;
            nudDias.Value = 1;
            dtpSalida.Value = DateTime.Today;
            lstAlquileres.Items.Clear();
            subtotalAcumulado = 0m;
            MostrarResultados(0m, 0m, 0m, 0m, 0m);
            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Close();
        }

        private void MostrarResultados(decimal subtotal, decimal descuento,
            decimal domicilio, decimal itbis, decimal total)
        {
            lblSubtotal.Text = FormatearDinero(subtotal);
            lblDescuento.Text = FormatearDinero(descuento);
            lblDomicilio.Text = FormatearDinero(domicilio);
            lblItbis.Text = FormatearDinero(itbis);
            lblTotal.Text = FormatearDinero(total);
        }

        private string FormatearDinero(decimal cantidad)
        {
            return "RD$ " + cantidad.ToString("N2", cultura);
        }
    }
}
