using Alejandria.Win.Forms.Cobradores;

namespace Alejandria.Win.Forms.CuentaCorrientes
{
    partial class FrmProximosVencimientosCobrador
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
            this.ucClienteDetalle1 = new Alejandria.Win.Forms.Clientes.UcClienteDetalle();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ucCobradorDetalle = new Alejandria.Win.Forms.Cobradores.UcCobradorDetalle();
            this.BtnRefrescar = new Telerik.WinControls.UI.RadButton();
            this.DdlCobradores = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.RvProximas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlCobradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
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
            this.radPanel1.Controls.Add(this.ucCobradorDetalle);
            this.radPanel1.Controls.Add(this.BtnRefrescar);
            this.radPanel1.Controls.Add(this.DdlCobradores);
            this.radPanel1.Controls.Add(this.radLabel8);
            this.radPanel1.Location = new System.Drawing.Point(29, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(970, 201);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.ThemeName = "TelerikMetro";
            // 
            // ucCobradorDetalle
            // 
            this.ucCobradorDetalle.CobradorNombre = "";
            this.ucCobradorDetalle.Cuit = "";
            this.ucCobradorDetalle.Domicilio = "";
            this.ucCobradorDetalle.Localidad = "";
            this.ucCobradorDetalle.Location = new System.Drawing.Point(20, 52);
            this.ucCobradorDetalle.Name = "ucCobradorDetalle";
            this.ucCobradorDetalle.Provincia = "";
            this.ucCobradorDetalle.Size = new System.Drawing.Size(675, 125);
            this.ucCobradorDetalle.TabIndex = 3;
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescar.Location = new System.Drawing.Point(743, 143);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(126, 34);
            this.BtnRefrescar.TabIndex = 7;
            this.BtnRefrescar.Text = "Buscar";
            this.BtnRefrescar.ThemeName = "TelerikMetro";
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // DdlCobradores
            // 
            this.DdlCobradores.DropDownAnimationEnabled = true;
            this.DdlCobradores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DdlCobradores.Location = new System.Drawing.Point(131, 6);
            this.DdlCobradores.MaxDropDownItems = 0;
            this.DdlCobradores.Name = "DdlCobradores";
            this.DdlCobradores.ShowImageInEditorArea = true;
            this.DdlCobradores.Size = new System.Drawing.Size(273, 27);
            this.DdlCobradores.TabIndex = 5;
            this.DdlCobradores.ThemeName = "TelerikMetro";
            this.DdlCobradores.SelectedValueChanged += new System.EventHandler(this.DdlCobradores_SelectedValueChanged);
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(35, 9);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(75, 24);
            this.radLabel8.TabIndex = 6;
            this.radLabel8.Text = "Cobrador:";
            // 
            // radPanel3
            // 
            this.radPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radPanel3.Controls.Add(this.RvProximas);
            this.radPanel3.Location = new System.Drawing.Point(29, 222);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(970, 357);
            this.radPanel3.TabIndex = 5;
            this.radPanel3.ThemeName = "TelerikMetro";
            // 
            // RvProximas
            // 
            this.RvProximas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvProximas.Location = new System.Drawing.Point(0, 0);
            this.RvProximas.Name = "RvProximas";
            this.RvProximas.Size = new System.Drawing.Size(970, 357);
            this.RvProximas.TabIndex = 0;
            // 
            // FrmProximosVencimientosCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 591);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.ucClienteDetalle1);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmProximosVencimientosCobrador";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proximos Vencimientos";
            this.Load += new System.EventHandler(this.FrmCuentasCorrientesCobrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlCobradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Clientes.UcClienteDetalle ucClienteDetalle1;
        private UcCobradorDetalle ucCobradorDetalle;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Microsoft.Reporting.WinForms.ReportViewer RvProximas;
        private Telerik.WinControls.UI.RadDropDownList DdlCobradores;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadButton BtnRefrescar;
    }
}