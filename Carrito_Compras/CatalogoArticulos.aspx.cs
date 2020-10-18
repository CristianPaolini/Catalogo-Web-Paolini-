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
            try
            {
                if (Session["listaBuscados"] == null)
                {
                    listaArticulos = negocio.listar();
                    Session.Add("listaArticulos", listaArticulos); //guardo en Session la lista de artículos entera, para luego realizar la búsqueda sobre la misma
                }
                else
                {

                    listaArticulos = (List<Articulo>)Session["listaBuscados"]; //si no es null la Session, los artículos a mostrar en el Load de la página son los asignados a la Session "listaBuscados"
                    Session["listaBuscados"] = null; //se setea nuevamente en null, para dejarlo preparado para una nueva búsqueda
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaBuscados = new List<Articulo>();
            if (Session["listaBuscados"] == null)
            {
                Session.Add("listaBuscados", listaBuscados);
            }
            listaBuscados = (List<Articulo>)Session["listaArticulos"];
            Session["listaBuscados"] = listaBuscados.FindAll(i => i.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()) || i.Marca.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper()) || i.Categoria.Descripcion.ToUpper().Contains(txtBuscar.Text.ToUpper())); //asigno todos los matches

            Session["listaArticulos"] = Session["listaBuscados"]; //me paso todos los que matchearon en Session "listaBuscados", a la Session "listaArticulos", para luego hacer un redirect y mostrar los matches
            Response.Redirect("CatalogoArticulos.aspx");

        }

    }
}