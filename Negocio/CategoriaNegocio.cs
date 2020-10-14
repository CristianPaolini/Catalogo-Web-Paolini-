using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Categoria> lista = new List<Categoria>();

            conexion.setearQuery("Select Id, Descripcion From CATEGORIAS");
            conexion.ejecutarLector();

            while (conexion.lector.Read())
            {
                lista.Add(new Categoria((int)conexion.lector["Id"], (string)conexion.lector["Descripcion"]));
            }
            conexion.cerrarConexion();
            return lista;
        }
    }
}
