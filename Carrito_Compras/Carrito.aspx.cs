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
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos = new List<Articulo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux = new List<Articulo>();
            try
            {
                listaArticulos = negocio.listar();
                foreach (Articulo var in listaArticulos)
                {
                    if (var.Id == Convert.ToInt32(Request.QueryString["idArticulo"]))
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("errorEncontrado", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}