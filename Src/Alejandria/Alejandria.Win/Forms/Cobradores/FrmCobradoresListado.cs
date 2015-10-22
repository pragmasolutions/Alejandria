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

namespace Alejandria.Win.Forms.Cobradores
{
    public partial class FrmCobradoresListado : FormBaseListado
    {
        private readonly ICobradoresNegocio _conbradorNegocio;

        public FrmCobradoresListado(IFormFactory formFactory, IAlejandriaUow uow, ICobradoresNegocio cobradorNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;
            SortColumn = "Nombre";
            SortDirection = "ASC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["TipoDocumentoDi"] = "TiposDocumentosIdentidad.Abreviatura";

            _conbradorNegocio = cobradorNegocio;

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

        private void FrmClienteListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            RefrescarListado();
            UcFiltrosCobradores.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;
            var nombre = UcFiltrosCobradores.Nombre;
            var cuit = UcFiltrosCobradores.Cuit;

            var clientes = await Task.Run(() => _conbradorNegocio.Listado(SortColumn, SortDirection,
                                                                        nombre, cuit, true,
                                                                        ClientesPager.CurrentPage,
                                                                        ClientesPager.PageSize,
                                                                        out pageTotal));

            dgvClientes.DataSource = clientes;

            ClientesPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCobrador>(default(int), ActionFormMode.Create))
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

            var cliente = selectedRow.DataBoundItem as ClienteDto;

            if (cliente == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(cliente.Id);
                    break;
                case "ColumnaEditar":
                    Editar(cliente.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(cliente.Id);
                    break;
            }
        }

        private void Detalle(Guid clientId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarCobrador>(clientId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(Guid clienteId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCobrador>(clienteId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(Guid clienteId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarCobrador>(clienteId, ActionFormMode.Delete))
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
