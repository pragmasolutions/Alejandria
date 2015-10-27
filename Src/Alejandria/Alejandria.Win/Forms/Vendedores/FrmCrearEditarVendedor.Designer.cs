using System.Windows.Forms;

namespace Alejandria.Win.Forms.Vendedores
{
    partial class FrmCrearEditarVendedor
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
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.EpvCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxTipoDocumento = new Telerik.WinControls.UI.RadDropDownList();
            this.cbxLocalidad = new Telerik.WinControls.UI.RadDropDownList();
            this.txtMail = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.cbxProvincia = new Telerik.WinControls.UI.RadDropDownList();
            this.metroLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.txtCelular = new Telerik.WinControls.UI.RadTextBox();
            this.txtTelefono = new Telerik.WinControls.UI.RadTextBox();
            this.txtDomicilio = new Telerik.WinControls.UI.RadTextBox();
            this.txtDni = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtApellidoNombre = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtNroCliente = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(341, 379);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetro";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(228, 379);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 11;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetro";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // EpvCliente
            // 
            this.EpvCliente.ContainerControl = this;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTipoDocumento.DropDownAnimationEnabled = true;
            this.cbxTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxTipoDocumento.Location = new System.Drawing.Point(161, 58);
            this.cbxTipoDocumento.MaxDropDownItems = 15;
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.ShowImageInEditorArea = true;
            this.cbxTipoDocumento.Size = new System.Drawing.Size(61, 32);
            this.cbxTipoDocumento.TabIndex = 2;
            this.cbxTipoDocumento.ThemeName = "TelerikMetro";
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLocalidad.DropDownAnimationEnabled = true;
            this.cbxLocalidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxLocalidad.Location = new System.Drawing.Point(161, 334);
            this.cbxLocalidad.MaxDropDownItems = 15;
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.ShowImageInEditorArea = true;
            this.cbxLocalidad.Size = new System.Drawing.Size(277, 32);
            this.cbxLocalidad.TabIndex = 9;
            this.cbxLocalidad.ThemeName = "TelerikMetro";
            // 
            // txtMail
            // 
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(161, 250);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(277, 31);
            this.txtMail.TabIndex = 7;
            this.txtMail.TabStop = false;
            this.txtMail.ThemeName = "TelerikMetro";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel13.Location = new System.Drawing.Point(24, 255);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(59, 29);
            this.metroLabel13.TabIndex = 92;
            this.metroLabel13.Text = "Email:";
            this.metroLabel13.ThemeName = "TelerikMetroBlue";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProvincia.DropDownAnimationEnabled = true;
            this.cbxProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.cbxProvincia.Location = new System.Drawing.Point(161, 292);
            this.cbxProvincia.MaxDropDownItems = 15;
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.ShowImageInEditorArea = true;
            this.cbxProvincia.Size = new System.Drawing.Size(277, 32);
            this.cbxProvincia.TabIndex = 8;
            this.cbxProvincia.ThemeName = "TelerikMetro";
            this.cbxProvincia.SelectedValueChanged += new System.EventHandler(this.cbxProvincia_SelectedValueChanged);
            // 
            // metroLabel12
            // 
            this.metroLabel12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel12.Location = new System.Drawing.Point(24, 60);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(156, 29);
            this.metroLabel12.TabIndex = 90;
            this.metroLabel12.Text = "Tipo Documento:";
            this.metroLabel12.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel8.Location = new System.Drawing.Point(24, 334);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 29);
            this.metroLabel8.TabIndex = 86;
            this.metroLabel8.Text = "Localidad:";
            this.metroLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(161, 209);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(277, 31);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.TabStop = false;
            this.txtCelular.ThemeName = "TelerikMetro";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(161, 168);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(277, 31);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.ThemeName = "TelerikMetro";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(161, 127);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(277, 31);
            this.txtDomicilio.TabIndex = 4;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.ThemeName = "TelerikMetro";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(228, 58);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(210, 31);
            this.txtDni.TabIndex = 3;
            this.txtDni.TabStop = false;
            this.txtDni.ThemeName = "TelerikMetro";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(24, 292);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 29);
            this.metroLabel7.TabIndex = 85;
            this.metroLabel7.Text = "Provincia:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(24, 213);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 29);
            this.metroLabel6.TabIndex = 84;
            this.metroLabel6.Text = "Celular:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(24, 171);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 29);
            this.metroLabel5.TabIndex = 83;
            this.metroLabel5.Text = "Teléfono:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(24, 129);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 29);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Domicilio:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoNombre.Location = new System.Drawing.Point(161, 17);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(277, 31);
            this.txtApellidoNombre.TabIndex = 1;
            this.txtApellidoNombre.TabStop = false;
            this.txtApellidoNombre.ThemeName = "TelerikMetro";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(24, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 29);
            this.metroLabel1.TabIndex = 80;
            this.metroLabel1.Text = "Apellido, Nombre:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(24, 95);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(166, 29);
            this.radLabel2.TabIndex = 94;
            this.radLabel2.Text = "Número vendedor:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtNroCliente
            // 
            this.TxtNroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroCliente.Enabled = false;
            this.TxtNroCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroCliente.Location = new System.Drawing.Point(161, 93);
            this.TxtNroCliente.Name = "TxtNroCliente";
            this.TxtNroCliente.Size = new System.Drawing.Size(277, 31);
            this.TxtNroCliente.TabIndex = 5;
            this.TxtNroCliente.TabStop = false;
            this.TxtNroCliente.ThemeName = "TelerikMetro";
            // 
            // FrmCrearEditarVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 544);
            this.Controls.Add(this.TxtNroCliente);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.cbxTipoDocumento);
            this.Controls.Add(this.cbxLocalidad);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCrearEditarVendedor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.FrmCrearEditarVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private ErrorProvider EpvCliente;
        private Telerik.WinControls.UI.RadDropDownList cbxTipoDocumento;
        private Telerik.WinControls.UI.RadDropDownList cbxLocalidad;
        private Telerik.WinControls.UI.RadTextBox txtMail;
        private Telerik.WinControls.UI.RadLabel metroLabel13;
        private Telerik.WinControls.UI.RadDropDownList cbxProvincia;
        private Telerik.WinControls.UI.RadLabel metroLabel12;
        private Telerik.WinControls.UI.RadLabel metroLabel8;
        private Telerik.WinControls.UI.RadTextBox txtCelular;
        private Telerik.WinControls.UI.RadTextBox txtTelefono;
        private Telerik.WinControls.UI.RadTextBox txtDomicilio;
        private Telerik.WinControls.UI.RadTextBox txtDni;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadTextBox txtApellidoNombre;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtNroCliente;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}