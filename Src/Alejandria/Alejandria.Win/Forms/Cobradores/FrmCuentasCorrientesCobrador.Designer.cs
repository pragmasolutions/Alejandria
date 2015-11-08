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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.ucClienteDetalle1 = new Alejandria.Win.Forms.Clientes.UcClienteDetalle();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.ucCobradorDetalle = new Alejandria.Win.Forms.Cobradores.UcCobradorDetalle();
            this.DdlCobradores = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.GridCuotas = new Telerik.WinControls.UI.RadGridView();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
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
            this.ucClienteDetalle1.Location = new System.Drawing.Point(629, 292);
            this.ucClienteDetalle1.Name = "ucClienteDetalle1";
            this.ucClienteDetalle1.Provincia = "";
            this.ucClienteDetalle1.Size = new System.Drawing.Size(8, 8);
            this.ucClienteDetalle1.TabIndex = 2;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.BtnBuscar);
            this.radPanel1.Controls.Add(this.ucCobradorDetalle);
            this.radPanel1.Controls.Add(this.DdlCobradores);
            this.radPanel1.Controls.Add(this.radLabel8);
            this.radPanel1.Location = new System.Drawing.Point(29, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(921, 204);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(778, 155);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(130, 35);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetro";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucCobradorDetalle
            // 
            this.ucCobradorDetalle.CobradorNombre = "";
            this.ucCobradorDetalle.Cuit = "";
            this.ucCobradorDetalle.Domicilio = "";
            this.ucCobradorDetalle.Localidad = "";
            this.ucCobradorDetalle.Location = new System.Drawing.Point(3, 44);
            this.ucCobradorDetalle.Name = "ucCobradorDetalle";
            this.ucCobradorDetalle.Provincia = "";
            this.ucCobradorDetalle.Size = new System.Drawing.Size(892, 126);
            this.ucCobradorDetalle.TabIndex = 3;
            // 
            // DdlCobradores
            // 
            this.DdlCobradores.DropDownAnimationEnabled = true;
            this.DdlCobradores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DdlCobradores.Location = new System.Drawing.Point(110, 11);
            this.DdlCobradores.MaxDropDownItems = 0;
            this.DdlCobradores.Name = "DdlCobradores";
            this.DdlCobradores.ShowImageInEditorArea = true;
            this.DdlCobradores.Size = new System.Drawing.Size(273, 27);
            this.DdlCobradores.TabIndex = 7;
            this.DdlCobradores.ThemeName = "TelerikMetro";
            this.DdlCobradores.SelectedValueChanged += new System.EventHandler(this.DdlCobradores_SelectedValueChanged);
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(14, 14);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(75, 24);
            this.radLabel8.TabIndex = 8;
            this.radLabel8.Text = "Cobrador:";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.GridCuotas);
            this.radPanel3.Location = new System.Drawing.Point(29, 237);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(921, 303);
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
            gridViewTextBoxColumn1.Width = 129;
            gridViewTextBoxColumn2.FieldName = "FechaVencimientoHasta";
            gridViewTextBoxColumn2.HeaderText = "FechaVencimientoHasta";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "FechaVencimientoHasta";
            gridViewTextBoxColumn2.Width = 132;
            gridViewTextBoxColumn3.FieldName = "Venta.NumeroComprobante";
            gridViewTextBoxColumn3.HeaderText = "Venta";
            gridViewTextBoxColumn3.Name = "Venta";
            gridViewTextBoxColumn3.Width = 58;
            gridViewTextBoxColumn4.FieldName = "Fecha";
            gridViewTextBoxColumn4.HeaderText = "Fecha";
            gridViewTextBoxColumn4.Name = "Fecha";
            gridViewTextBoxColumn4.Width = 96;
            gridViewTextBoxColumn5.FieldName = "Cliente.Denominacion";
            gridViewTextBoxColumn5.HeaderText = "Cliente";
            gridViewTextBoxColumn5.Name = "Cliente";
            gridViewTextBoxColumn5.Width = 198;
            gridViewTextBoxColumn6.FieldName = "Venta.Concepto";
            gridViewTextBoxColumn6.HeaderText = "Obra";
            gridViewTextBoxColumn6.Name = "Concepto";
            gridViewTextBoxColumn6.Width = 197;
            gridViewTextBoxColumn7.FieldName = "Cuota";
            gridViewTextBoxColumn7.HeaderText = "Cuota";
            gridViewTextBoxColumn7.Name = "Cuota";
            gridViewTextBoxColumn7.Width = 87;
            gridViewTextBoxColumn8.FieldName = "Importe";
            gridViewTextBoxColumn8.HeaderText = "Importe";
            gridViewTextBoxColumn8.Name = "Importe";
            gridViewTextBoxColumn8.Width = 91;
            gridViewCheckBoxColumn1.HeaderText = "Pagar";
            gridViewCheckBoxColumn1.MaxWidth = 50;
            gridViewCheckBoxColumn1.MinWidth = 30;
            gridViewCheckBoxColumn1.Name = "Pagar";
            this.GridCuotas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewCheckBoxColumn1});
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.Size = new System.Drawing.Size(921, 303);
            this.GridCuotas.TabIndex = 0;
            this.GridCuotas.ThemeName = "TelerikMetro";
            this.GridCuotas.ValueChanged += new System.EventHandler(this.GridCuotas_ValueChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(820, 553);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 35);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetro";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(684, 556);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(119, 28);
            this.TxtTotal.TabIndex = 7;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(617, 558);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(52, 25);
            this.radLabel1.TabIndex = 6;
            this.radLabel1.Text = "Total:";
            // 
            // FrmCuentasCorrientesCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 603);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radPanel3);
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
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
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

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Clientes.UcClienteDetalle ucClienteDetalle1;
        private UcCobradorDetalle ucCobradorDetalle;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadGridView GridCuotas;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList DdlCobradores;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
    }
}