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
        public List<Articulo> listaCarrito = new List<Articulo>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaOriginal;
            try
            {
                decimal total = 0;
                listaCarrito =(List<Articulo>) Session[Session.SessionID + "listaCarrito"];
                listaOriginal = negocio.listar();

                var quitar = Request.QueryString["idArticulo"];
                if (quitar != null)
                {
                    Articulo quitarArticulo = listaOriginal.Find(x => x.Id == int.Parse(quitar));
                    listaCarrito.Remove(quitarArticulo);
                    Session[Session.SessionID + "listaCarrito"] = listaCarrito;
                }
                else if(Request.QueryString["idArticulo"] != null)
                    {
                    List<Articulo> listaAux =(List<Articulo>) Session[Session.SessionID + "listaCarrito"];
                    int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                    Articulo articulo = listaAux.Find(i => i.Id == idAux);

                    if (listaCarrito == null)
                        listaCarrito = new List<Articulo>();

                    listaCarrito.Add(articulo);
                    Session[Session.SessionID + "listaCarrito"] = listaCarrito;

                }


                foreach (var item in listaCarrito)
                {
                    total += (decimal)item.Precio;
                }
                lblTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {

                Session.Add("errorEncontrado", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}