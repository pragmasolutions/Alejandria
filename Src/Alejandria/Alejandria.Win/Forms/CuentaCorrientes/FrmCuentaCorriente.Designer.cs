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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ucFiltrosClientes = new Alejandria.Win.Forms.Clientes.UcFiltrosClientes();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.ucClienteDetalle = new Alejandria.Win.Forms.Clientes.UcClienteDetalle();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.GridCuotas = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).BeginInit();
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
<<<<<<< HEAD
            this.GridCuotas.MasterTemplate.AllowAddNewRow = false;
            this.GridCuotas.MasterTemplate.AllowColumnReorder = false;
            this.GridCuotas.MasterTemplate.AutoGenerateColumns = false;
            this.GridCuotas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaVencimiento";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Fecha de vencimiento";
            gridViewTextBoxColumn1.Name = "FechaVencimiento";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn1.Width = 180;
            gridViewTextBoxColumn2.FieldName = "Cuota";
            gridViewTextBoxColumn2.HeaderText = "Cuota";
            gridViewTextBoxColumn2.Name = "Cuota";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 180;
            gridViewTextBoxColumn3.FieldName = "Fecha";
            gridViewTextBoxColumn3.HeaderText = "Fecha Compra";
            gridViewTextBoxColumn3.Name = "Fecha";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 180;
            gridViewTextBoxColumn4.FieldName = "Importe";
            gridViewTextBoxColumn4.HeaderText = "Importe";
            gridViewTextBoxColumn4.Name = "Importe";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 180;
            gridViewCheckBoxColumn1.HeaderText = "Pagar";
            gridViewCheckBoxColumn1.Name = "Pagar";
            gridViewCheckBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn1.Width = 66;
            this.GridCuotas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1});
            this.GridCuotas.MasterTemplate.EnableGrouping = false;
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.Size = new System.Drawing.Size(804, 254);
            this.GridCuotas.TabIndex = 0;
            this.GridCuotas.ThemeName = "TelerikMetro";
            this.GridCuotas.ValueChanged += new System.EventHandler(this.GridCuotas_ValueChanged);
=======
            this.radPanel1.Controls.Add(this.ucFiltrosClientes);
            this.radPanel1.Location = new System.Drawing.Point(15, 13);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(391, 196);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "TelerikMetro";
>>>>>>> origin/master
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
            gridViewTextBoxColumn1.FieldName = "Cuota";
            gridViewTextBoxColumn1.HeaderText = "Cuota";
            gridViewTextBoxColumn1.Name = "Cuota";
            this.GridCuotas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1});
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.Size = new System.Drawing.Size(1062, 254);
            this.GridCuotas.TabIndex = 0;
            this.GridCuotas.ThemeName = "TelerikMetro";
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
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).EndInit();
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
    }
}