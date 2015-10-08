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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new Telerik.WinControls.UI.RadMenu();
            this.TabsPrincipal = new Telerik.WinControls.UI.RadPageView();
            this.PageAccesos = new Telerik.WinControls.UI.RadPageViewPage();
            this.BtnCrearVenta = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabsPrincipal)).BeginInit();
            this.TabsPrincipal.SuspendLayout();
            this.PageAccesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenu.Location = new System.Drawing.Point(3, 3);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            // 
            // 
            // 
            this.MainMenu.RootElement.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.MainMenu.Size = new System.Drawing.Size(964, 24);
            this.MainMenu.TabIndex = 19;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.ThemeName = "TelerikMetroBlue";
            this.tableLayoutPanel1.Controls.Add(this.MainMenu, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 40);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // TabsPrincipal
            // 
            this.TabsPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabsPrincipal.Controls.Add(this.PageAccesos);
            this.TabsPrincipal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TabsPrincipal.Location = new System.Drawing.Point(12, 44);
            this.TabsPrincipal.Name = "TabsPrincipal";
            this.TabsPrincipal.SelectedPage = this.PageAccesos;
            this.TabsPrincipal.Size = new System.Drawing.Size(958, 462);
            this.TabsPrincipal.TabIndex = 16;
            this.TabsPrincipal.ThemeName = "TelerikMetroBlue";
            this.TabsPrincipal.SelectedPageChanging += new System.EventHandler<Telerik.WinControls.UI.RadPageViewCancelEventArgs>(this.TabsPrincipal_SelectedPageChanging);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.TabsPrincipal.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.Auto;
            // 
            // PageAccesos
            // 
            this.PageAccesos.Controls.Add(this.BtnCrearVenta);
            this.PageAccesos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageAccesos.ForeColor = System.Drawing.Color.White;
            this.PageAccesos.Location = new System.Drawing.Point(10, 48);
            this.PageAccesos.Name = "PageAccesos";
            this.PageAccesos.Size = new System.Drawing.Size(937, 403);
            this.PageAccesos.Text = "Accesos";
            // 
            // BtnCrearVenta
            // 
            this.BtnCrearVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrearVenta.Image")));
            this.BtnCrearVenta.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCrearVenta.Location = new System.Drawing.Point(15, 16);
            this.BtnCrearVenta.Name = "BtnCrearVenta";
            this.BtnCrearVenta.Size = new System.Drawing.Size(172, 167);
            this.BtnCrearVenta.TabIndex = 21;
            this.BtnCrearVenta.Text = "Venta";
            this.BtnCrearVenta.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCrearVenta.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCrearVenta.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCrearVenta.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCrearVenta.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCrearVenta.GetChildAt(0))).Text = "Venta";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BtnCrearVenta.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.SystemColors.Highlight;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BtnCrearVenta.GetChildAt(0).GetChildAt(0))).Opacity = 1D;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BtnCrearVenta.GetChildAt(0).GetChildAt(0))).Enabled = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.BtnCrearVenta.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.BtnCrearVenta.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.BtnCrearVenta.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0, -2, 0, 0);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.BtnCrearVenta.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TabsPrincipal);
            this.Name = "FrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Sistema de Gestión Libreria Alejandria";
            this.ThemeName = "ControlDefault";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabsPrincipal)).EndInit();
            this.TabsPrincipal.ResumeLayout(false);
            this.PageAccesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private Telerik.WinControls.UI.RadPageView TabsPrincipal;
        private Telerik.WinControls.UI.RadPageViewPage PageAccesos;
        private Telerik.WinControls.UI.RadButton BtnCrearVenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadMenu MainMenu;

    }
}