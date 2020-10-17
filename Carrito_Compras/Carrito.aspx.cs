using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public Articulo articuloSelec { get; set; }
        public List<Articulo> listaCarrito { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaAux = new List<Articulo>();

            try
            {
                listaAux = negocio.listar();
                int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                articuloSelec = listaAux.Find(i => i.Id == idAux);

                if (articuloSelec == null) Response.Redirect("CatalogoArticulos.aspx");

                if (Session["listaArtAgregados"] == null)
                {
                    listaCarrito = new List<Articulo>();
                    listaCarrito.Add(articuloSelec);
                    Session.Add("listaArtAgregados", listaCarrito);
                }
                else
                {
                    listaCarrito = (List<Articulo>)Session["listaArtAgregados"];
                    listaCarrito.Add(articuloSelec);
                    Session["listaArtAgregados"] = listaCarrito;
                }
                if(listaCarrito != null)
                {
                    SqlMoney total = 0;
                    foreach (var articulo in listaCarrito)
                    {
                        total += articulo.Precio;
                    }
                    lblTotal.Text = total.ToString();
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