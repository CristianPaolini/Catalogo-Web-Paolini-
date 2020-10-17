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
    public partial class Calcs : System.Web.UI.Page
    {
        public Articulo articuloSelec { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.QueryString["id"] == null || Request.QueryString["op"] == null) Response.Redirect("~/");

            List<Articulo> listaCarrito = (List<Articulo>)Session[Session.SessionID + "listaArtAgregados"];
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux;
            try
            {
                listaAux = negocio.listar();
                int idSeleccionado = Convert.ToInt32(Request.QueryString["id"]);
                articuloSelec = listaAux.Find(i => i.Id == idSeleccionado);

                if (articuloSelec == null)
                {
                    Response.Redirect("CatalogoArticulos.aspx");
                }
                else
                {
                    listaCarrito.Remove(articuloSelec);
                    Session["listaArtAgregados"] = listaCarrito;
                }
                
            }
            catch (Exception ex)
            {

                Session.Add("errorDetectado", ex.ToString());
                Response.Redirect("Error.aspx");
            }


        }
    }
}
           