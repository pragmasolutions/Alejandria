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
            this.BtnClientes = new Telerik.WinControls.UI.RadButton();
            this.BtnVentas = new Telerik.WinControls.UI.RadButton();
            this.BtnCobradores = new Telerik.WinControls.UI.RadButton();
            this.BtnCuotas = new Telerik.WinControls.UI.RadButton();
            this.BtnCuotasCobrador = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCuotasCobrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.Image = global::Alejandria.Win.Properties.Resources.CustomerAlejandria;
            this.BtnClientes.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnClientes.Location = new System.Drawing.Point(602, 37);
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
            this.BtnVentas.Location = new System.Drawing.Point(23, 37);
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
            this.BtnCobradores.Location = new System.Drawing.Point(602, 191);
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
            this.BtnCuotas.Location = new System.Drawing.Point(23, 191);
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
            this.BtnCuotasCobrador.Image = global::Alejandria.Win.Properties.Resources.pagoCuota;
            this.BtnCuotasCobrador.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCuotasCobrador.Location = new System.Drawing.Point(23, 354);
            this.BtnCuotasCobrador.Name = "BtnCuotasCobrador";
            this.BtnCuotasCobrador.Size = new System.Drawing.Size(156, 148);
            this.BtnCuotasCobrador.TabIndex = 5;
            this.BtnCuotasCobrador.Text = "Cuotas Cobrador";
            this.BtnCuotasCobrador.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCuotasCobrador.ThemeName = "TelerikMetro";
            this.BtnCuotasCobrador.Click += new System.EventHandler(this.BtnCuotasCobrador_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 534);
            this.Controls.Add(this.BtnCuotasCobrador);
            this.Controls.Add(this.BtnCuotas);
            this.Controls.Add(this.BtnCobradores);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.BtnClientes);
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
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnClientes;
        private Telerik.WinControls.UI.RadButton BtnVentas;
        private Telerik.WinControls.UI.RadButton BtnCobradores;
        private Telerik.WinControls.UI.RadButton BtnCuotas;
        private Telerik.WinControls.UI.RadButton BtnCuotasCobrador;
    }
}
