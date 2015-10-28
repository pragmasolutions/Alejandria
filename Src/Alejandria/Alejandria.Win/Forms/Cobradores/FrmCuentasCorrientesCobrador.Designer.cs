namespace Alejandria.Win.Forms.Cobradores
{
    partial class FrmCuentasCorrientesCobrador
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ucClienteDetalle1 = new Alejandria.Win.Forms.Clientes.UcClienteDetalle();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ucFiltrosCobradores = new Alejandria.Win.Forms.Cobradores.UcFiltrosCobradores();
            this.ucCobradorDetalle = new Alejandria.Win.Forms.Cobradores.UcCobradorDetalle();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.GridCuotas = new Telerik.WinControls.UI.RadGridView();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucClienteDetalle1
            // 
            this.ucClienteDetalle1.ClienteNombre = "";
            this.ucClienteDetalle1.Cuit = "";
            this.ucClienteDetalle1.Domicilio = "";
            this.ucClienteDetalle1.FormaPago = "";
            this.ucClienteDetalle1.Localidad = "";
            this.ucClienteDetalle1.Location = new System.Drawing.Point(629, 271);
            this.ucClienteDetalle1.Name = "ucClienteDetalle1";
            this.ucClienteDetalle1.Provincia = "";
            this.ucClienteDetalle1.Size = new System.Drawing.Size(8, 8);
            this.ucClienteDetalle1.TabIndex = 2;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucFiltrosCobradores);
            this.radPanel1.Location = new System.Drawing.Point(29, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(388, 160);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // ucFiltrosCobradores
            // 
            this.ucFiltrosCobradores.Cuit = "";
            this.ucFiltrosCobradores.Location = new System.Drawing.Point(3, 3);
            this.ucFiltrosCobradores.Name = "ucFiltrosCobradores";
            this.ucFiltrosCobradores.Nombre = "";
            this.ucFiltrosCobradores.Size = new System.Drawing.Size(371, 123);
            this.ucFiltrosCobradores.TabIndex = 0;
            // 
            // ucCobradorDetalle
            // 
            this.ucCobradorDetalle.CobradorNombre = "";
            this.ucCobradorDetalle.Cuit = "";
            this.ucCobradorDetalle.Domicilio = "";
            this.ucCobradorDetalle.Localidad = "";
            this.ucCobradorDetalle.Location = new System.Drawing.Point(12, 6);
            this.ucCobradorDetalle.Name = "ucCobradorDetalle";
            this.ucCobradorDetalle.Provincia = "";
            this.ucCobradorDetalle.Size = new System.Drawing.Size(335, 151);
            this.ucCobradorDetalle.TabIndex = 3;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.ucCobradorDetalle);
            this.radPanel2.Location = new System.Drawing.Point(432, 12);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(388, 160);
            this.radPanel2.TabIndex = 4;
            this.radPanel2.ThemeName = "TelerikMetro";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.GridCuotas);
            this.radPanel3.Location = new System.Drawing.Point(29, 178);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(791, 357);
            this.radPanel3.TabIndex = 5;
            this.radPanel3.ThemeName = "TelerikMetro";
            // 
            // GridCuotas
            // 
            this.GridCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCuotas.Location = new System.Drawing.Point(0, 0);
            // 
            // GridCuotas
            // 
            this.GridCuotas.MasterTemplate.AllowAddNewRow = false;
            this.GridCuotas.MasterTemplate.AllowColumnReorder = false;
            this.GridCuotas.MasterTemplate.AllowDeleteRow = false;
            this.GridCuotas.MasterTemplate.AllowDragToGroup = false;
            this.GridCuotas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaVencimiento";
            gridViewTextBoxColumn1.HeaderText = "FechaVencimiento";
            gridViewTextBoxColumn1.Name = "FechaVencimiento";
            gridViewTextBoxColumn1.Width = 237;
            gridViewTextBoxColumn2.FieldName = "FechaVencimientoHasta";
            gridViewTextBoxColumn2.HeaderText = "FechaVencimientoHasta";
            gridViewTextBoxColumn2.Name = "FechaVencimientoHasta";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "Cuota";
            gridViewTextBoxColumn3.HeaderText = "Cuota";
            gridViewTextBoxColumn3.Name = "Cuota";
            gridViewTextBoxColumn3.Width = 94;
            gridViewTextBoxColumn4.FieldName = "Importe";
            gridViewTextBoxColumn4.HeaderText = "Importe";
            gridViewTextBoxColumn4.Name = "Importe";
            gridViewTextBoxColumn4.Width = 94;
            gridViewTextBoxColumn5.FieldName = "Cliente.Denominacion";
            gridViewTextBoxColumn5.HeaderText = "Cliente";
            gridViewTextBoxColumn5.Name = "Cliente";
            gridViewTextBoxColumn5.Width = 97;
            gridViewCheckBoxColumn1.HeaderText = "Pagar";
            gridViewCheckBoxColumn1.Name = "Pagar";
            gridViewCheckBoxColumn1.Width = 43;
            gridViewTextBoxColumn6.Expression = "Venta.NroComprobante";
            gridViewTextBoxColumn6.HeaderText = "NroVenta";
            gridViewTextBoxColumn6.Name = "NroVenta";
            gridViewTextBoxColumn6.Width = 43;
            gridViewTextBoxColumn7.FieldName = "Fecha";
            gridViewTextBoxColumn7.HeaderText = "Fecha";
            gridViewTextBoxColumn7.Name = "Fecha";
            gridViewTextBoxColumn7.Width = 48;
            this.GridCuotas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.Size = new System.Drawing.Size(791, 357);
            this.GridCuotas.TabIndex = 0;
            this.GridCuotas.ThemeName = "TelerikMetro";
            this.GridCuotas.ValueChanged += new System.EventHandler(this.GridCuotas_ValueChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(690, 541);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 42);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetro";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(565, 551);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(119, 32);
            this.TxtTotal.TabIndex = 7;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(489, 553);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(61, 30);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Total:";
            // 
            // FrmCuentasCorrientesCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 591);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.ucClienteDetalle1);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmCuentasCorrientesCobrador";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Cuotas por cobrador";
            this.Load += new System.EventHandler(this.FrmCuentasCorrientesCobrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UcFiltrosCobradores ucFiltrosCobradores;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Clientes.UcClienteDetalle ucClienteDetalle1;
        private UcCobradorDetalle ucCobradorDetalle;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadGridView GridCuotas;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}