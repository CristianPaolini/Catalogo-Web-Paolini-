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
            List<Articulo> listaAux;
            Dominio.Carrito carrito = new Dominio.Carrito();

            try
            {
                listaAux = negocio.listar();

                if (Session["listaCarrito"] == null)
                {
                    listaCarrito = new List<Articulo>();
                    Session.Add("listaCarrito", listaCarrito);
                }

                if (Request.QueryString["idArticulo"] != null)
                {
                    int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                    listaCarrito = (List<Articulo>)Session["listaCarrito"];
                    listaCarrito.Add(listaAux.Find(i => i.Id == idAux));
                    Session["listaCarrito"] = listaCarrito;

                }

                listaCarrito = (List<Articulo>)Session["listaCarrito"];
                lblTotal.Text = carrito.MontoTotal.ToString();
                lblCantidad.Text = carrito.CantidadArticulos.ToString();

                if (listaCarrito != null)
                {

                    foreach (var articulo in listaCarrito)
                    {
                        carrito.MontoTotal += articulo.Precio;

                    }
                    lblTotal.Text = carrito.MontoTotal.ToString();
                    List<Articulo> listaArtCarrito = new List<Articulo>();
                    listaArtCarrito = (List<Articulo>)Session["listaCarrito"];
                    Session["cantArticulos"] = listaArtCarrito.Count();
                    lblCantidad.Text = Session["cantArticulos"].ToString();
                }

                else
                {
                    listaCarrito = new List<Articulo>();
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