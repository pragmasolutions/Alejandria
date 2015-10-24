namespace Alejandria.Win.Forms.Cobradores
{
    partial class FrmSeleccionarCobrador
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.GrillaSeleccionar = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionar.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaSeleccionar
            // 
            this.GrillaSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaSeleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaSeleccionar.Location = new System.Drawing.Point(23, 12);
            // 
            // GrillaSeleccionar
            // 
            this.GrillaSeleccionar.MasterTemplate.AllowAddNewRow = false;
            this.GrillaSeleccionar.MasterTemplate.AllowColumnReorder = false;
            this.GrillaSeleccionar.MasterTemplate.AllowColumnResize = false;
            this.GrillaSeleccionar.MasterTemplate.AllowDeleteRow = false;
            this.GrillaSeleccionar.MasterTemplate.AllowDragToGroup = false;
            this.GrillaSeleccionar.MasterTemplate.AllowEditRow = false;
            this.GrillaSeleccionar.MasterTemplate.AllowRowResize = false;
            this.GrillaSeleccionar.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaSeleccionar.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Denominacion";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.Name = "Nombre";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 184;
            gridViewTextBoxColumn2.FieldName = "Cuit";
            gridViewTextBoxColumn2.HeaderText = "DNI";
            gridViewTextBoxColumn2.Name = "Cuit";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 129;
            gridViewCommandColumn1.DefaultText = "Seleccionar";
            gridViewCommandColumn1.FieldName = "Seleccionar";
            gridViewCommandColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.MinWidth = 100;
            gridViewCommandColumn1.Name = "Seleccionar";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 100;
            this.GrillaSeleccionar.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            this.GrillaSeleccionar.MasterTemplate.EnableGrouping = false;
            this.GrillaSeleccionar.Name = "GrillaSeleccionar";
            this.GrillaSeleccionar.ReadOnly = true;
            this.GrillaSeleccionar.Size = new System.Drawing.Size(433, 417);
            this.GrillaSeleccionar.TabIndex = 40;
            this.GrillaSeleccionar.ThemeName = "TelerikMetro";
            this.GrillaSeleccionar.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaSeleccionar_CommandCellClick);
            this.GrillaSeleccionar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GrillaSeleccionar_KeyUp);
            // 
            // FrmSeleccionarCobrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 441);
            this.Controls.Add(this.GrillaSeleccionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionarCobrador";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Seleccionar Cobrador";
            this.Load += new System.EventHandler(this.FrmSeleccionarCobrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionar.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrillaSeleccionar;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Nombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuit;
    }
}