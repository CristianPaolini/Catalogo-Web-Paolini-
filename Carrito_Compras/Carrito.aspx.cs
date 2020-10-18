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

                if (Session["listaArtAgregados"] == null) //si no tiene nada, creo una lista Carrito
                {
                    listaCarrito = new List<Articulo>();
                    Session.Add("listaArtAgregados", listaCarrito);
                }

                if (Request.QueryString["idArticulo"] != null) //si no devuelve null, está todo bien, procede a añadirlo
                {
                    int idAux = Convert.ToInt32(Request.QueryString["idArticulo"]);
                    List<Articulo> listaArticulos = (List<Articulo>)Session["listaArticulos"];
                    listaCarrito = (List<Articulo>)Session["listaArtAgregados"];
                    listaCarrito.Add(listaAux.Find(i => i.Id == idAux)); //busco coincidencia del id traído por QueryString. Agrego el ID que matchea (si lo hay) 
                    Session["listaCarrito"] = listaCarrito;
                   

                }

                listaCarrito = (List<Articulo>)Session["listaCarrito"];
                lblTotal.Text = carrito.MontoTotal.ToString();  //si viene por botón, para que no rompa y muestre ceros en los campos
                lblCantidad.Text = carrito.CantidadArticulos.ToString();

                if (listaCarrito != null) //este if impide que rompa si intenta listar precios de una lista Carrito está con null, y de paso en el else aprovecho para crearla
                {

                    foreach (var articulo in listaCarrito)
                    {
                        carrito.MontoTotal += articulo.Precio;
                        carrito.CantidadArticulos++;
                    }
                    lblTotal.Text = carrito.MontoTotal.ToString();
                    lblCantidad.Text = carrito.CantidadArticulos.ToString();
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