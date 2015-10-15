namespace Alejandria.Win.Forms.Ventas
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.TxtMontoVenta = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtAnticipo = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtAdeuda = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtCuotas = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtMontoCuota = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.ucFiltrosClientes = new Alejandria.Win.Forms.Clientes.UcFiltrosClientes();
            this.DtpVencimiento = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.ucClienteDetalle = new Alejandria.Win.Forms.Clientes.UcClienteDetalle();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMontoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdeuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMontoCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(31, 242);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(98, 24);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Monto Cuota";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(65, 119);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(60, 24);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Adeuda";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(65, 79);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(64, 24);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Anticipo";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(74, 159);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(55, 24);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "Cuotas";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(32, 39);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(97, 24);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Monto Venta";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(10, 199);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(119, 24);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "1er Vencimiento";
            // 
            // TxtMontoVenta
            // 
            this.TxtMontoVenta.AceptaNegativos = false;
            this.TxtMontoVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoVenta.Location = new System.Drawing.Point(135, 39);
            this.TxtMontoVenta.Name = "TxtMontoVenta";
            this.TxtMontoVenta.Size = new System.Drawing.Size(241, 26);
            this.TxtMontoVenta.TabIndex = 3;
            this.TxtMontoVenta.TabStop = false;
            this.TxtMontoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMontoVenta.ThemeName = "TelerikMetro";
            this.TxtMontoVenta.TextChanged += new System.EventHandler(this.TxtMontoVenta_TextChanged);
            // 
            // TxtAnticipo
            // 
            this.TxtAnticipo.AceptaNegativos = false;
            this.TxtAnticipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnticipo.Location = new System.Drawing.Point(135, 79);
            this.TxtAnticipo.Name = "TxtAnticipo";
            this.TxtAnticipo.Size = new System.Drawing.Size(241, 26);
            this.TxtAnticipo.TabIndex = 4;
            this.TxtAnticipo.TabStop = false;
            this.TxtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtAnticipo.ThemeName = "TelerikMetro";
            this.TxtAnticipo.TextChanged += new System.EventHandler(this.TxtAnticipo_TextChanged);
            // 
            // TxtAdeuda
            // 
            this.TxtAdeuda.AceptaNegativos = false;
            this.TxtAdeuda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdeuda.Location = new System.Drawing.Point(135, 119);
            this.TxtAdeuda.Name = "TxtAdeuda";
            this.TxtAdeuda.Size = new System.Drawing.Size(241, 26);
            this.TxtAdeuda.TabIndex = 4;
            this.TxtAdeuda.TabStop = false;
            this.TxtAdeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtAdeuda.ThemeName = "TelerikMetro";
            // 
            // TxtCuotas
            // 
            this.TxtCuotas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuotas.Location = new System.Drawing.Point(135, 159);
            this.TxtCuotas.Name = "TxtCuotas";
            this.TxtCuotas.Size = new System.Drawing.Size(241, 26);
            this.TxtCuotas.TabIndex = 5;
            this.TxtCuotas.TabStop = false;
            this.TxtCuotas.ThemeName = "TelerikMetro";
            this.TxtCuotas.TextChanged += new System.EventHandler(this.TxtCuotas_TextChanged);
            // 
            // TxtMontoCuota
            // 
            this.TxtMontoCuota.AceptaNegativos = false;
            this.TxtMontoCuota.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoCuota.Location = new System.Drawing.Point(135, 242);
            this.TxtMontoCuota.Name = "TxtMontoCuota";
            this.TxtMontoCuota.Size = new System.Drawing.Size(241, 26);
            this.TxtMontoCuota.TabIndex = 5;
            this.TxtMontoCuota.TabStop = false;
            this.TxtMontoCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMontoCuota.ThemeName = "TelerikMetro";
            // 
            // ucFiltrosClientes
            // 
            this.ucFiltrosClientes.Cuit = "";
            this.ucFiltrosClientes.Denominacion = "";
            this.ucFiltrosClientes.Location = new System.Drawing.Point(22, 3);
            this.ucFiltrosClientes.Name = "ucFiltrosClientes";
            this.ucFiltrosClientes.Size = new System.Drawing.Size(371, 123);
            this.ucFiltrosClientes.TabIndex = 6;
            // 
            // DtpVencimiento
            // 
            this.DtpVencimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DtpVencimiento.Location = new System.Drawing.Point(135, 199);
            this.DtpVencimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpVencimiento.MinDate = new System.DateTime(((long)(0)));
            this.DtpVencimiento.Name = "DtpVencimiento";
            this.DtpVencimiento.NullableValue = new System.DateTime(2015, 10, 15, 17, 3, 19, 724);
            this.DtpVencimiento.NullDate = new System.DateTime(((long)(0)));
            this.DtpVencimiento.Size = new System.Drawing.Size(241, 29);
            this.DtpVencimiento.TabIndex = 7;
            this.DtpVencimiento.TabStop = false;
            this.DtpVencimiento.Text = "jueves, 15 de octubre de 2015";
            this.DtpVencimiento.ThemeName = "TelerikMetro";
            this.DtpVencimiento.Value = new System.DateTime(2015, 10, 15, 17, 3, 19, 724);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.radLabel5);
            this.radPanel1.Controls.Add(this.DtpVencimiento);
            this.radPanel1.Controls.Add(this.radLabel1);
            this.radPanel1.Controls.Add(this.radLabel6);
            this.radPanel1.Controls.Add(this.TxtMontoCuota);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.TxtCuotas);
            this.radPanel1.Controls.Add(this.radLabel3);
            this.radPanel1.Controls.Add(this.TxtAdeuda);
            this.radPanel1.Controls.Add(this.radLabel4);
            this.radPanel1.Controls.Add(this.TxtAnticipo);
            this.radPanel1.Controls.Add(this.TxtMontoVenta);
            this.radPanel1.Location = new System.Drawing.Point(692, 180);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(442, 364);
            this.radPanel1.TabIndex = 8;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(246, 289);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 33);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Guardar";
            this.radButton1.ThemeName = "TelerikMetro";
            // 
            // ucClienteDetalle
            // 
            this.ucClienteDetalle.ClienteNombre = "";
            this.ucClienteDetalle.Cuit = "";
            this.ucClienteDetalle.Domicilio = "";
            this.ucClienteDetalle.FormaPago = "";
            this.ucClienteDetalle.Localidad = "";
            this.ucClienteDetalle.Location = new System.Drawing.Point(4, 5);
            this.ucClienteDetalle.Name = "ucClienteDetalle";
            this.ucClienteDetalle.Provincia = "";
            this.ucClienteDetalle.Size = new System.Drawing.Size(674, 181);
            this.ucClienteDetalle.TabIndex = 9;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.ucFiltrosClientes);
            this.radPanel2.Location = new System.Drawing.Point(692, 40);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(442, 134);
            this.radPanel2.TabIndex = 10;
            this.radPanel2.ThemeName = "TelerikMetro";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.ucClienteDetalle);
            this.radPanel3.Location = new System.Drawing.Point(4, 180);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(682, 204);
            this.radPanel3.TabIndex = 11;
            this.radPanel3.ThemeName = "TelerikMetro";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.radLabel7);
            this.radPanel4.Location = new System.Drawing.Point(4, 40);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(682, 134);
            this.radPanel4.TabIndex = 12;
            this.radPanel4.ThemeName = "TelerikMetro";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(17, 25);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(130, 24);
            this.radLabel7.TabIndex = 3;
            this.radLabel7.Text = "Número de venta:";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 583);
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmVentas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMontoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdeuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMontoCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            this.radPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtMontoVenta;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtAnticipo;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtAdeuda;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCuotas;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtMontoCuota;
        private Clientes.UcFiltrosClientes ucFiltrosClientes;
        private Telerik.WinControls.UI.RadDateTimePicker DtpVencimiento;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Clientes.UcClienteDetalle ucClienteDetalle;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadLabel radLabel7;

    }
}
