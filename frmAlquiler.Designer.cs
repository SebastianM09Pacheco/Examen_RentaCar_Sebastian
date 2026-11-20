using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentaCarExpress
{
    partial class frmAlquiler
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCliente = new Label();
            txtCliente = new TextBox();
            chkCorporativo = new CheckBox();
            lblSalida = new Label();
            dtpSalida = new DateTimePicker();
            lblVehiculo = new Label();
            txtVehiculo = new TextBox();
            lblTarifa = new Label();
            txtTarifa = new TextBox();
            lblDias = new Label();
            nudDias = new NumericUpDown();
            gbSeguro = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            gbEntrega = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            chkGps = new CheckBox();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            lstAlquileres = new ListBox();
            lblTextoSubtotal = new Label();
            lblSubtotal = new Label();
            lblTextoDescuento = new Label();
            lblDescuento = new Label();
            lblTextoDomicilio = new Label();
            lblDomicilio = new Label();
            lblTextoItbis = new Label();
            lblItbis = new Label();
            lblTextoTotal = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            gbSeguro.SuspendLayout();
            gbEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // frmAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 590);
            MinimumSize = new Size(1056, 629);
            Name = "frmAlquiler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentaCar Express - Alquileres";
            // 
            // Cliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(42, 42);
            lblCliente.Text = "Cliente:";
            txtCliente.Location = new Point(135, 37);
            txtCliente.Size = new Size(245, 23);
            txtCliente.Name = "txtCliente";
            // 
            // Corporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(42, 82);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Text = "Cliente corporativo";
            chkCorporativo.Size = new Size(137, 19);
            // 
            // Salida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(42, 128);
            lblSalida.Text = "Salida:";
            dtpSalida.Location = new Point(135, 122);
            dtpSalida.Size = new Size(300, 23);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Format = DateTimePickerFormat.Short;
            // 
            // Vehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(42, 177);
            lblVehiculo.Text = "Vehículo:";
            txtVehiculo.Location = new Point(135, 171);
            txtVehiculo.Size = new Size(245, 23);
            txtVehiculo.Name = "txtVehiculo";
            // 
            // Tarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(42, 226);
            lblTarifa.Text = "Tarifa:";
            txtTarifa.Location = new Point(135, 220);
            txtTarifa.Size = new Size(245, 23);
            txtTarifa.Name = "txtTarifa";
            // 
            // Dias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(42, 274);
            lblDias.Text = "Días:";
            nudDias.Location = new Point(135, 268);
            nudDias.Size = new Size(145, 23);
            nudDias.Name = "nudDias";
            nudDias.Minimum = 1;
            nudDias.Maximum = 30;
            nudDias.Value = 1;
            // 
            // Seguro
            // 
            gbSeguro.Location = new Point(32, 322);
            gbSeguro.Name = "gbSeguro";
            gbSeguro.Size = new Size(250, 116);
            gbSeguro.Text = "Seguro";
            rbtBasico.AutoSize = true;
            rbtBasico.Location = new Point(15, 29);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Text = "Básico";
            rbtBasico.Checked = true;
            rbtCompleto.AutoSize = true;
            rbtCompleto.Location = new Point(15, 68);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Text = "Completo (+RD$300)";
            gbSeguro.Controls.Add(rbtBasico);
            gbSeguro.Controls.Add(rbtCompleto);
            // 
            // Entrega
            // 
            gbEntrega.Location = new Point(300, 322);
            gbEntrega.Name = "gbEntrega";
            gbEntrega.Size = new Size(250, 116);
            gbEntrega.Text = "Entrega";
            rbtSucursal.AutoSize = true;
            rbtSucursal.Location = new Point(15, 29);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.Checked = true;
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Location = new Point(15, 68);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            gbEntrega.Controls.Add(rbtSucursal);
            gbEntrega.Controls.Add(rbtDomicilio);
            // 
            // GPS
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(42, 455);
            chkGps.Name = "chkGps";
            chkGps.Text = "GPS (+RD$100 por día)";
            chkGps.Size = new Size(170, 19);
            // 
            // Agregar
            // 
            btnAgregar.Location = new Point(650, 38);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(310, 65);
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Encabezado
            // 
            lblEncabezado.Location = new Point(625, 125);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(365, 22);
            lblEncabezado.Font = new Font("Consolas", 9F, FontStyle.Bold);
            // 
            // Lista
            // 
            lstAlquileres.Location = new Point(625, 151);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(365, 184);
            lstAlquileres.HorizontalScrollbar = true;
            lstAlquileres.Font = new Font("Consolas", 9F);
            // 
            // Resultados
            // 
            lblTextoSubtotal.AutoSize = true;
            lblTextoSubtotal.Location = new Point(625, 360);
            lblTextoSubtotal.Text = "Subtotal:";
            lblSubtotal.Location = new Point(790, 357);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(200, 23);
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotal.Text = "RD$ 0.00";

            lblTextoDescuento.AutoSize = true;
            lblTextoDescuento.Location = new Point(625, 395);
            lblTextoDescuento.Text = "Descuento:";
            lblDescuento.Location = new Point(790, 392);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(200, 23);
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            lblDescuento.Text = "RD$ 0.00";

            lblTextoDomicilio.AutoSize = true;
            lblTextoDomicilio.Location = new Point(625, 430);
            lblTextoDomicilio.Text = "Domicilio:";
            lblDomicilio.Location = new Point(790, 427);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(200, 23);
            lblDomicilio.TextAlign = ContentAlignment.MiddleRight;
            lblDomicilio.Text = "RD$ 0.00";

            lblTextoItbis.AutoSize = true;
            lblTextoItbis.Location = new Point(625, 465);
            lblTextoItbis.Text = "ITBIS (18 %):";
            lblItbis.Location = new Point(790, 462);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(200, 23);
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            lblItbis.Text = "RD$ 0.00";

            lblTextoTotal.AutoSize = true;
            lblTextoTotal.Location = new Point(625, 505);
            lblTextoTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoTotal.Text = "TOTAL A PAGAR:";
            lblTotal.Location = new Point(790, 500);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 28);
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.Text = "RD$ 0.00";
            // 
            // Botones inferiores
            // 
            btnCalcular.Location = new Point(32, 510);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(165, 48);
            btnCalcular.Text = "Calcular total";
            btnCalcular.Click += btnCalcular_Click;

            btnLimpiar.Location = new Point(215, 510);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(165, 48);
            btnLimpiar.Text = "Nuevo alquiler";
            btnLimpiar.Click += btnLimpiar_Click;

            btnSalir.Location = new Point(398, 510);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 48);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // Agregar controles al formulario
            // 
            Controls.AddRange(new Control[]
            {
                lblCliente, txtCliente, chkCorporativo,
                lblSalida, dtpSalida, lblVehiculo, txtVehiculo,
                lblTarifa, txtTarifa, lblDias, nudDias,
                gbSeguro, gbEntrega, chkGps, btnAgregar,
                lblEncabezado, lstAlquileres,
                lblTextoSubtotal, lblSubtotal,
                lblTextoDescuento, lblDescuento,
                lblTextoDomicilio, lblDomicilio,
                lblTextoItbis, lblItbis,
                lblTextoTotal, lblTotal,
                btnCalcular, btnLimpiar, btnSalir
            });

            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            gbSeguro.ResumeLayout(false);
            gbSeguro.PerformLayout();
            gbEntrega.ResumeLayout(false);
            gbEntrega.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblCliente;
        private TextBox txtCliente;
        private CheckBox chkCorporativo;
        private Label lblSalida;
        private DateTimePicker dtpSalida;
        private Label lblVehiculo;
        private TextBox txtVehiculo;
        private Label lblTarifa;
        private TextBox txtTarifa;
        private Label lblDias;
        private NumericUpDown nudDias;
        private GroupBox gbSeguro;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private GroupBox gbEntrega;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private CheckBox chkGps;
        private Button btnAgregar;
        private Label lblEncabezado;
        private ListBox lstAlquileres;
        private Label lblTextoSubtotal;
        private Label lblSubtotal;
        private Label lblTextoDescuento;
        private Label lblDescuento;
        private Label lblTextoDomicilio;
        private Label lblDomicilio;
        private Label lblTextoItbis;
        private Label lblItbis;
        private Label lblTextoTotal;
        private Label lblTotal;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
