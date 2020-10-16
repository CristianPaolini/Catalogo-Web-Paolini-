using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Carrito_Compras
{
    public partial class CatalogoArticulos : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            Session[Session.SessionID + "listaArticulos"] = listaArticulos;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux;
            Articulo buscado = new Articulo();
            try
            {
                listaAux = negocio.listar();
                buscado = listaAux.Find(i => i.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                if (buscado == null)
                {
                    string msgErrorBusqueda = "No se han encontrado coincidencias";
                    lblError.Text = msgErrorBusqueda;
                }
                else if (txtBuscar.Text.Length == 0)
                {
                    string msgSinIngreso = "No ha ingresado nada para buscar";
                    lblError.Text = msgSinIngreso;
                }
                else
                {
                    Response.Redirect("Detalle.aspx?idArticulo=" + buscado.Id.ToString());
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}