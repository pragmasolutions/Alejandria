namespace Alejandria.Win.Forms.Ventas
{
    partial class FrmComprobantes
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
            this.RvComprobantes = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RvComprobantes
            // 
            this.RvComprobantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RvComprobantes.Location = new System.Drawing.Point(0, 0);
            this.RvComprobantes.Name = "RvComprobantes";
            this.RvComprobantes.Size = new System.Drawing.Size(858, 395);
            this.RvComprobantes.TabIndex = 0;
            // 
            // FrmComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 395);
            this.Controls.Add(this.RvComprobantes);
            this.Name = "FrmComprobantes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Impresión de comprobantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmComprobantes_FormClosed);
            this.Load += new System.EventHandler(this.FrmComprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RvComprobantes;
    }
}