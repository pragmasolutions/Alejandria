﻿using Alejandria.Win.Forms.Cobradores;

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
            this.ucFiltrosCobradores = new Alejandria.Win.Forms.Cobradores.UcFiltrosCobradores();
            this.ucCobradorDetalle = new Alejandria.Win.Forms.Cobradores.UcCobradorDetalle();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.RvProximas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
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
            this.ucCobradorDetalle.Size = new System.Drawing.Size(552, 151);
            this.ucCobradorDetalle.TabIndex = 3;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.ucCobradorDetalle);
            this.radPanel2.Location = new System.Drawing.Point(432, 12);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(567, 160);
            this.radPanel2.TabIndex = 4;
            this.radPanel2.ThemeName = "TelerikMetro";
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.RvProximas);
            this.radPanel3.Location = new System.Drawing.Point(29, 178);
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
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.ucClienteDetalle1);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmProximosVencimientosCobrador";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Proximos Vencimientos";
            this.Load += new System.EventHandler(this.FrmCuentasCorrientesCobrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcFiltrosCobradores ucFiltrosCobradores;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Clientes.UcClienteDetalle ucClienteDetalle1;
        private UcCobradorDetalle ucCobradorDetalle;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Microsoft.Reporting.WinForms.ReportViewer RvProximas;
    }
}