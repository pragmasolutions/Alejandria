using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alejandria.Business.Interfaces;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;
using Alejandria.Entities.Dto;
using Alejandria.Win;
using Alejandria.Win.Enums;
using Alejandria.Win.Forms;
using Alejandria.Win.Helpers;
using Telerik.WinControls.UI;

namespace Alejandria.Win.Forms.Vendedores
{
    public partial class FrmVendedoresListado : FormBaseListado
    {
        private readonly IVendedoresNegocio _vendedorNegocio;

        public FrmVendedoresListado(IFormFactory formFactory, IAlejandriaUow uow, IVendedoresNegocio vendedorNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;
            SortColumn = "Nombre";
            SortDirection = "ASC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["TipoDocumentoDi"] = "TiposDocumentosIdentidad.Abreviatura";

            _vendedorNegocio = vendedorNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.dgvClientes.CellFormatting += this.Grilla_CellFormatting;
            this.MainGrid = dgvClientes;
        //    this.MainPager = ClientesPager;
            this.Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            ClientesPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmVendedorListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            RefrescarListado();
            UcFiltrosVendedor.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;
            var nombre = UcFiltrosVendedor.Nombre;
            var cuit = UcFiltrosVendedor.Cuit;

            var vendedores = await Task.Run(() => _vendedorNegocio.Listado(SortColumn, SortDirection,
                                                                        nombre, cuit, true,
                                                                        ClientesPager.CurrentPage,
                                                                        ClientesPager.PageSize,
                                                                        out pageTotal));

            dgvClientes.DataSource = vendedores;

            ClientesPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarVendedor>(default(int), ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void dgvClientes_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.dgvClientes.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var vendedor = selectedRow.DataBoundItem as VendedoresDto;

            if (vendedor == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(vendedor.Id);
                    break;
                case "ColumnaEditar":
                    Editar(vendedor.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(vendedor.Id);
                    break;
            }
        }

        private void Detalle(int vendedorId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarVendedores>(vendedorId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

       

        private void Editar(int vendedorId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarVendedor>(vendedorId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(int vendedorId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarVendedores>(vendedorId, ActionFormMode.Delete))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }
    }
}
