﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace CarritoMasterPropia
{
    public partial class Index : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                
                listaArticulos = negocio.listar();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
   
}