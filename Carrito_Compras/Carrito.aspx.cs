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

                if (listaCarrito == null)
                {
                    listaCarrito = new List<Articulo>();
                }

                if (Session["listaArtAgregados"] == null) //si no tiene nada, creo una lista Carrito
                {
                    listaCarrito = new List<Articulo>();
                    Session.Add("listaArtAgregados", listaCarrito);
                }

                if (Request.QueryString["idArticulo"] != null) //si no devuelve null, está todo bien, procede a añadirlo
                {

                    listaCarrito = (List<Articulo>)Session["listaArtAgregados"];
                    listaCarrito.Add(listaAux.Find(i => i.Id == idAux));
                    Session["listaCarrito"] = listaCarrito;

                }

                listaCarrito = (List<Articulo>)Session["listaCarrito"];

                SqlMoney total = 0;
                foreach (var articulo in listaCarrito)
                {
                    total += articulo.Precio;
                }
                lblTotal.Text = total.ToString();

            }
            catch (Exception ex)
            {

                Session.Add("errorDetectado", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }
    }
}