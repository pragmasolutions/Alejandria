namespace Alejandria.Win.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnClientes = new Telerik.WinControls.UI.RadButton();
            this.BtnVentas = new Telerik.WinControls.UI.RadButton();
            this.BtnCobradores = new Telerik.WinControls.UI.RadButton();
            this.BtnCuotas = new Telerik.WinControls.UI.RadButton();
            this.BtnCuotasCobrador = new Telerik.WinControls.UI.RadButton();
            this.BtnVendedores = new Telerik.WinControls.UI.RadButton();
            this.BtnImprimir = new Telerik.WinControls.UI.RadButton();
            this.BtnProximos = new Telerik.WinControls.UI.RadButton();
            this.BtnAnular = new Telerik.WinControls.UI.RadButton();
            this.BtnLocalidad = new Telerik.WinControls.UI.RadButton();
            this.BtnProvincia = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCuotasCobrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProximos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.Image = global::Alejandria.Win.Properties.Resources.CustomerAlejandria;
            this.BtnClientes.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnClientes.Location = new System.Drawing.Point(3, 311);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(156, 148);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnClientes.ThemeName = "TelerikMetro";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.Image = global::Alejandria.Win.Properties.Resources.Sales_Order;
            this.BtnVentas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVentas.Location = new System.Drawing.Point(3, 3);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(156, 148);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVentas.ThemeName = "TelerikMetro";
            this.BtnVentas.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // BtnCobradores
            // 
            this.BtnCobradores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCobradores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCobradores.Image = global::Alejandria.Win.Properties.Resources.cobradores;
            this.BtnCobradores.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCobradores.Location = new System.Drawing.Point(3, 157);
            this.BtnCobradores.Name = "BtnCobradores";
            this.BtnCobradores.Size = new System.Drawing.Size(156, 148);
            this.BtnCobradores.TabIndex = 3;
            this.BtnCobradores.Text = "Cobradores";
            this.BtnCobradores.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCobradores.ThemeName = "TelerikMetro";
            this.BtnCobradores.Click += new System.EventHandler(this.BtnCobradores_Click);
            // 
            // BtnCuotas
            // 
            this.BtnCuotas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuotas.Image = global::Alejandria.Win.Properties.Resources.pagoCuota;
            this.BtnCuotas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCuotas.Location = new System.Drawing.Point(189, 311);
            this.BtnCuotas.Name = "BtnCuotas";
            this.BtnCuotas.Size = new System.Drawing.Size(156, 148);
            this.BtnCuotas.TabIndex = 4;
            this.BtnCuotas.Text = "Cuotas Cliente";
            this.BtnCuotas.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCuotas.ThemeName = "TelerikMetro";
            this.BtnCuotas.Click += new System.EventHandler(this.BtnCuotas_Click);
            // 
            // BtnCuotasCobrador
            // 
            this.BtnCuotasCobrador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuotasCobrador.Image = global::Alejandria.Win.Properties.Resources.pagoCuotaCobradores;
            this.BtnCuotasCobrador.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCuotasCobrador.Location = new System.Drawing.Point(189, 157);
            this.BtnCuotasCobrador.Name = "BtnCuotasCobrador";
            this.BtnCuotasCobrador.Size = new System.Drawing.Size(156, 148);
            this.BtnCuotasCobrador.TabIndex = 5;
            this.BtnCuotasCobrador.Text = "Cuotas Cobrador";
            this.BtnCuotasCobrador.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCuotasCobrador.ThemeName = "TelerikMetro";
            this.BtnCuotasCobrador.Click += new System.EventHandler(this.BtnCuotasCobrador_Click);
            // 
            // BtnVendedores
            // 
            this.BtnVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVendedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVendedores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVendedores.Image = global::Alejandria.Win.Properties.Resources.cobradores;
            this.BtnVendedores.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVendedores.Location = new System.Drawing.Point(794, 3);
            this.BtnVendedores.Name = "BtnVendedores";
            this.BtnVendedores.Size = new System.Drawing.Size(135, 148);
            this.BtnVendedores.TabIndex = 4;
            this.BtnVendedores.Text = "Vendedores";
            this.BtnVendedores.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVendedores.ThemeName = "TelerikMetro";
            this.BtnVendedores.Click += new System.EventHandler(this.BtnVendedores_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::Alejandria.Win.Properties.Resources.Printer;
            this.BtnImprimir.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnImprimir.Location = new System.Drawing.Point(189, 3);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(156, 148);
            this.BtnImprimir.TabIndex = 6;
            this.BtnImprimir.Text = "Ventas del dia";
            this.BtnImprimir.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnImprimir.TextWrap = true;
            this.BtnImprimir.ThemeName = "TelerikMetro";
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnProximos
            // 
            this.BtnProximos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProximos.Image = global::Alejandria.Win.Properties.Resources.ProximosVencimientos;
            this.BtnProximos.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnProximos.Location = new System.Drawing.Point(378, 157);
            this.BtnProximos.Name = "BtnProximos";
            this.BtnProximos.Size = new System.Drawing.Size(156, 148);
            this.BtnProximos.TabIndex = 7;
            this.BtnProximos.Text = "Próximos Vencimientos";
            this.BtnProximos.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProximos.ThemeName = "TelerikMetro";
            this.BtnProximos.Click += new System.EventHandler(this.BtnProximos_Click);
            // 
            // BtnAnular
            // 
            this.BtnAnular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.Image = global::Alejandria.Win.Properties.Resources.Anul_venta;
            this.BtnAnular.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAnular.Location = new System.Drawing.Point(564, 3);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(156, 148);
            this.BtnAnular.TabIndex = 8;
            this.BtnAnular.Text = "Anular Venta";
            this.BtnAnular.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAnular.ThemeName = "TelerikMetro";
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // BtnLocalidad
            // 
            this.BtnLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLocalidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLocalidad.Image = global::Alejandria.Win.Properties.Resources.cobradores;
            this.BtnLocalidad.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLocalidad.Location = new System.Drawing.Point(794, 157);
            this.BtnLocalidad.Name = "BtnLocalidad";
            this.BtnLocalidad.Size = new System.Drawing.Size(135, 148);
            this.BtnLocalidad.TabIndex = 9;
            this.BtnLocalidad.Text = "Nueva Localidad";
            this.BtnLocalidad.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLocalidad.ThemeName = "TelerikMetro";
            this.BtnLocalidad.Click += new System.EventHandler(this.BtnLocalidad_Click);
            // 
            // BtnProvincia
            // 
            this.BtnProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProvincia.Image = global::Alejandria.Win.Properties.Resources.cobradores;
            this.BtnProvincia.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProvincia.Location = new System.Drawing.Point(794, 311);
            this.BtnProvincia.Name = "BtnProvincia";
            this.BtnProvincia.Size = new System.Drawing.Size(135, 148);
            this.BtnProvincia.TabIndex = 10;
            this.BtnProvincia.Text = "Nueva Provincia";
            this.BtnProvincia.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnProvincia.ThemeName = "TelerikMetro";
            this.BtnProvincia.Click += new System.EventHandler(this.BtnProvincia_Click);
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Image = global::Alejandria.Win.Properties.Resources.RePrint;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(378, 3);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(156, 148);
            this.radButton1.TabIndex = 11;
            this.radButton1.Text = "Reimpresion";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click_1);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(985, 597);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.Color.DarkRed;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -1;
            this.lineShape2.X2 = 986;
            this.lineShape2.Y1 = 529;
            this.lineShape2.Y2 = 529;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.DarkRed;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -4;
            this.lineShape1.X2 = 983;
            this.lineShape1.Y1 = 13;
            this.lineShape1.Y2 = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Image = global::Alejandria.Win.Properties.Resources.devlights1;
            this.linkLabel1.Location = new System.Drawing.Point(552, 534);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 25);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.Tag = " ";
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.radButton2.Enabled = false;
            this.radButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton2.Image = global::Alejandria.Win.Properties.Resources.devlights;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton2.Location = new System.Drawing.Point(751, 534);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(231, 63);
            this.radButton2.TabIndex = 14;
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton2.ThemeName = "TelerikMetro";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42007F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.07001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.48658F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.30338F));
            this.tableLayoutPanel1.Controls.Add(this.BtnVendedores, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnProvincia, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnLocalidad, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnAnular, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.radButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnProximos, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnClientes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnVentas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCobradores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCuotas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnImprimir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCuotasCobrador, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 472);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Alejandria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCuotasCobrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProximos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnClientes;
        private Telerik.WinControls.UI.RadButton BtnVentas;
        private Telerik.WinControls.UI.RadButton BtnCobradores;
        private Telerik.WinControls.UI.RadButton BtnCuotas;
        private Telerik.WinControls.UI.RadButton BtnCuotasCobrador;
        private Telerik.WinControls.UI.RadButton BtnVendedores;
        private Telerik.WinControls.UI.RadButton BtnImprimir;
        private Telerik.WinControls.UI.RadButton BtnProximos;
        private Telerik.WinControls.UI.RadButton BtnAnular;
        private Telerik.WinControls.UI.RadButton BtnLocalidad;
        private Telerik.WinControls.UI.RadButton BtnProvincia;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
