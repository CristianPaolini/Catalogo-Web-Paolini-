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
    public partial class Detalle : System.Web.UI.Page
    {
        public Articulo articuloDetalle { get; set; }

        public List<Articulo> listaArticulosCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulosCarrito = negocio.listar();
                Session.Add("listadoArticulos", listaArticulosCarrito);
            }
            catch (Exception ex)
            {
                Session.Add("errorEncontrado", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}