using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace CarritoMasterPropia
{
    public partial class Detalle : System.Web.UI.Page
    {
        public Articulo articuloDetalle { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List < Articulo > listaAux;
            try
            {
                listaAux = negocio.listar();
                int idAux= Convert.ToInt32(Request.QueryString["IDArticulo"]);
                articuloDetalle = listaAux.Find(x => x.Id == idAux);
                
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}