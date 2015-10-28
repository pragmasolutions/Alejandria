using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Common.Extentensions;
using Framework.Ioc;
using Alejandria.Data.Interfaces;
using Alejandria.Entities;

namespace Alejandria.Win.Forms.Cobradores
{
    public partial class UcFiltrosCobradores : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosCobradores()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<IAlejandriaUow>();
            }

            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        public event EventHandler<List<Cobrador>> BuscarFinished;
        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        //public int? ProvinciaId
        //{
        //    get { return (int?)(CbxProvincia.SelectedIndex != 0 ? CbxProvincia.SelectedValue : null); }
        //    set { CbxProvincia.SelectedValue = value ?? 0; }
        //}

        //public int? LocalidadId
        //{
        //    get { return (int?)(CbxLocalidad.SelectedIndex != 0 ? CbxLocalidad.SelectedValue : null); }
        //    set { CbxLocalidad.SelectedValue = value ?? 0; }
        //}

        #endregion

        #region Metodos

       private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;
            TxtTextoBuscar.Text = string.Empty;
            TxtCuit.Text = string.Empty;
            _limpiandoFiltros = false;

           // OnFiltered();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
            //BuscarCobrador();
        }

        //private void BuscarCobrador()
        //{
        //    var textBuscarNombre = TxtTextoBuscar.Text;
        //    var textBuscarCuit = TxtCuit.Text.PadLeft(11, '0');

        //    //Expression<Func<Cliente, bool>> where =
        //    //    x => SqlFunctions.PatIndex(textBuscarCuit, x.Cuit) > 0 || SqlFunctions.PatIndex(textBuscarDenominacion, x.Denominacion) > 0;

        //    Expression<Func<Cobrador, bool>> where =
        //        x =>
        //        (string.IsNullOrEmpty(textBuscarNombre)
        //         || x.Nombre.Contains(textBuscarNombre)
        //        )
        //        && (string.IsNullOrEmpty(textBuscarCuit)
        //            || x.Cuit.Contains(textBuscarCuit)
        //           )
        //        ;

        //    Cursor.Current = Cursors.WaitCursor;

        //    var cobrador = Uow.Cobradores.Listado(x => x.Localidad, x => x.Provincia)
        //        .Where(@where)
        //        .ToList();


        //    Cursor.Current = Cursors.Default;

        //    OnBuscarFinished(cobrador);
        //    OnFiltered();
        //}

        private void BuscarCobrador()
        {
            var textBuscarCuit = TxtTextoBuscar.Text.PadLeft(11, '0');
            var textBuscarDenominacion = TxtTextoBuscar.Text.ToStringSearch();

            Expression<Func<Cobrador, bool>> where =
                x =>
                SqlFunctions.PatIndex(textBuscarCuit, x.Cuit) > 0 ||
                SqlFunctions.PatIndex(textBuscarDenominacion, x.Nombre) > 0;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var cobradores = Uow.Cobradores.Listado( x => x.Localidad, x => x.Provincia)
                .Where(@where)
                .OrderBy(c => c.Nombre)
                .ToList();

                Cursor.Current = Cursors.Default;
                OnBuscarFinished(cobradores);
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void OnBuscarFinished(List<Cobrador> clientes)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, clientes);
            }
        }


        #endregion

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtCuit_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }
        }



    }
}
