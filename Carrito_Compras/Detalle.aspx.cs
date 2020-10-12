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
        Dictionary<int, int> listaCarrito = new Dictionary<int, int>();
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux;
            try
            {
                listaAux = negocio.listar();
                int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                articuloDetalle = listaAux.Find(x => x.Id == idAux);

                if (listaCarrito == null)
                {
                    listaCarrito = new Dictionary<int, int>();
                }

            }
            catch (Exception ex)
            {
                Session.Add("Session_id_" + Session.SessionID + "_error", ex.Message);
                Response.Redirect("Error.aspx");
            }
        }
    }
}