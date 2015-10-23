namespace Alejandria.Win.Forms.CuentaCorrientes
{
    partial class FrmCuentaCorriente
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.ucFiltrosClientes = new Alejandria.Win.Forms.Clientes.UcFiltrosClientes();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.ucClienteDetalle = new Alejandria.Win.Forms.Clientes.UcClienteDetalle();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.GridCuotas = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucFiltrosClientes
            // 
            this.ucFiltrosClientes.Cuit = "";
            this.ucFiltrosClientes.Denominacion = "";
            this.ucFiltrosClientes.Location = new System.Drawing.Point(12, 45);
            this.ucFiltrosClientes.Name = "ucFiltrosClientes";
            this.ucFiltrosClientes.Size = new System.Drawing.Size(371, 123);
            this.ucFiltrosClientes.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucFiltrosClientes);
            this.radPanel1.Location = new System.Drawing.Point(15, 13);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(391, 196);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.ucClienteDetalle);
            this.radPanel2.Location = new System.Drawing.Point(412, 13);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(684, 196);
            this.radPanel2.TabIndex = 2;
            this.radPanel2.ThemeName = "TelerikMetro";
            // 
            // ucClienteDetalle
            // 
            this.ucClienteDetalle.ClienteNombre = "";
            this.ucClienteDetalle.Cuit = "";
            this.ucClienteDetalle.Domicilio = "";
            this.ucClienteDetalle.FormaPago = "";
            this.ucClienteDetalle.Localidad = "";
            this.ucClienteDetalle.Location = new System.Drawing.Point(3, 3);
            this.ucClienteDetalle.Name = "ucClienteDetalle";
            this.ucClienteDetalle.Provincia = "";
            this.ucClienteDetalle.Size = new System.Drawing.Size(674, 181);
            this.ucClienteDetalle.TabIndex = 0;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.BtnGuardar);
            this.radPanel3.Controls.Add(this.TxtTotal);
            this.radPanel3.Controls.Add(this.radLabel1);
            this.radPanel3.Controls.Add(this.GridCuotas);
            this.radPanel3.Location = new System.Drawing.Point(15, 216);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(1081, 297);
            this.radPanel3.TabIndex = 3;
            this.radPanel3.ThemeName = "TelerikMetro";
            // 
            // GridCuotas
            // 
            this.GridCuotas.Location = new System.Drawing.Point(12, 15);
            // 
            // GridCuotas
            // 
            this.GridCuotas.MasterTemplate.AllowAddNewRow = false;
            this.GridCuotas.MasterTemplate.AllowColumnReorder = false;
            this.GridCuotas.MasterTemplate.AutoGenerateColumns = false;
            this.GridCuotas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "FechaVencimiento";
            gridViewTextBoxColumn5.HeaderText = "Fecha Vencimiento";
            gridViewTextBoxColumn5.Name = "FechaVencimiento";
            gridViewTextBoxColumn5.Width = 192;
            gridViewTextBoxColumn6.FieldName = "Cuota";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Cuota";
            gridViewTextBoxColumn6.Name = "Cuota";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 148;
            gridViewTextBoxColumn7.Expression = "";
            gridViewTextBoxColumn7.FieldName = "Importe";
            gridViewTextBoxColumn7.HeaderText = "Importe";
            gridViewTextBoxColumn7.Name = "Importe";
            gridViewTextBoxColumn7.Width = 148;
            gridViewTextBoxColumn8.FieldName = "Fecha";
            gridViewTextBoxColumn8.HeaderText = "FechaCompra";
            gridViewTextBoxColumn8.Name = "Fecha";
            gridViewTextBoxColumn8.Width = 148;
            gridViewCheckBoxColumn2.HeaderText = "Pagar";
            gridViewCheckBoxColumn2.MaxWidth = 60;
            gridViewCheckBoxColumn2.MinWidth = 60;
            gridViewCheckBoxColumn2.Name = "Pagar";
            gridViewCheckBoxColumn2.Width = 60;
            this.GridCuotas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewCheckBoxColumn2});
            this.GridCuotas.MasterTemplate.EnableGrouping = false;
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.Size = new System.Drawing.Size(714, 254);
            this.GridCuotas.TabIndex = 0;
            this.GridCuotas.ThemeName = "TelerikMetro";
            this.GridCuotas.ValueChanged += new System.EventHandler(this.GridCuotas_ValueChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(850, 193);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 24);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Total:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(914, 193);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 26);
            this.TxtTotal.TabIndex = 2;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetro";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(884, 225);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(130, 42);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetro";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // FrmCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 551);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmCuentaCorriente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Pago de Cuotas";
            this.Load += new System.EventHandler(this.FrmCuentaCorriente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Clientes.UcFiltrosClientes ucFiltrosClientes;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Clientes.UcClienteDetalle ucClienteDetalle;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadGridView GridCuotas;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}