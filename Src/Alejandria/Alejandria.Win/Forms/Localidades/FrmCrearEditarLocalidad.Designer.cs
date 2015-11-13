namespace Alejandria.Win.Forms.Localidades
{
    partial class FrmCrearEditarLocalidad
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
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BrnGuardar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCP = new Telerik.WinControls.UI.RadTextBox();
            this.cbxProvincia = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(131, 70);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(195, 26);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(53, 70);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(72, 24);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Nombre: ";
            // 
            // BrnGuardar
            // 
            this.BrnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrnGuardar.Location = new System.Drawing.Point(196, 135);
            this.BrnGuardar.Name = "BrnGuardar";
            this.BrnGuardar.Size = new System.Drawing.Size(130, 30);
            this.BrnGuardar.TabIndex = 4;
            this.BrnGuardar.Text = "Guardar";
            this.BrnGuardar.ThemeName = "TelerikMetro";
            this.BrnGuardar.Click += new System.EventHandler(this.BrnGuardar_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(53, 102);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(69, 24);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "C. Postal:";
            // 
            // TxtCP
            // 
            this.TxtCP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCP.Location = new System.Drawing.Point(131, 102);
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.Size = new System.Drawing.Size(195, 26);
            this.TxtCP.TabIndex = 3;
            this.TxtCP.TabStop = false;
            this.TxtCP.ThemeName = "TelerikMetro";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProvincia.DropDownAnimationEnabled = true;
            this.cbxProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxProvincia.Location = new System.Drawing.Point(131, 37);
            this.cbxProvincia.MaxDropDownItems = 15;
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.ShowImageInEditorArea = true;
            this.cbxProvincia.Size = new System.Drawing.Size(195, 27);
            this.cbxProvincia.TabIndex = 1;
            this.cbxProvincia.ThemeName = "TelerikMetro";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(49, 40);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 24);
            this.metroLabel7.TabIndex = 87;
            this.metroLabel7.Text = "Provincia:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCrearEditarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 177);
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.TxtCP);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.BrnGuardar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.radLabel1);
            this.Name = "FrmCrearEditarLocalidad";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.FrmCrearEditarLocalidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtNombre;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton BrnGuardar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtCP;
        private Telerik.WinControls.UI.RadDropDownList cbxProvincia;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
    }
}