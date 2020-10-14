using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Marca> lista = new List<Marca>();

            conexion.setearQuery("Select Id, Descripcion From MARCAS");
            conexion.ejecutarLector();

            while (conexion.lector.Read())
            {
                lista.Add(new Marca((int)conexion.lector["Id"], (string)conexion.lector["Descripcion"]));
            }
            conexion.cerrarConexion();
            return lista;
        }
    }
}
