using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            conexion.setearQuery("Select A.ID, A.Codigo Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, Precio, C.Descripcion Categoria, C.Id IdCat, M.Id IdMarca, M.Descripcion Marca From ARTICULOS A join CATEGORIAS C on A.IdCategoria = C.Id join MARCAS M on A.IdMarca = M.Id");
            try
            {
                conexion.ejecutarLector();
                while (conexion.lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)conexion.lector["ID"];
                    aux.Codigo = (string)conexion.lector["Codigo"];
                    aux.Nombre = conexion.lector.GetString(2);
                    aux.Descripcion = conexion.lector.GetString(3);
                    aux.ImagenUrl = (string)conexion.lector["ImagenUrl"];
                    aux.Precio = conexion.lector.GetSqlMoney(5);

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)conexion.lector["Categoria"];
                    aux.Categoria.Id = (int)conexion.lector["IdCat"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)conexion.lector["Marca"];
                    aux.Marca.Id = (int)conexion.lector["IdMarca"];

                    lista.Add(aux);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }

        public void agregar(Articulo nuevo)
        {

            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearQuery("Insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdCategoria, IdMarca) Values (@Codigo, @Nombre, @Descripcion, @Precio, @ImagenUrl, @IdCategoria, @IdMarca)");
                conexion.agregarParametro("@Codigo", nuevo.Codigo);
                conexion.agregarParametro("@Nombre", nuevo.Nombre);
                conexion.agregarParametro("@Descripcion", nuevo.Descripcion);
                conexion.agregarParametro("@Precio", nuevo.Precio);
                conexion.agregarParametro("@ImagenUrl", nuevo.ImagenUrl);
                conexion.agregarParametro("@IdCategoria", nuevo.Categoria.Id);
                conexion.agregarParametro("@IdMarca", nuevo.Marca.Id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

        }

        public void modificar(Articulo artic)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearQuery("Update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio, ImagenUrl=@ImagenUrl, IdCategoria=@IdCategoria, IdMarca=@IdMarca where Id=@Id");
                conexion.agregarParametro("@Id", artic.Id);
                conexion.agregarParametro("@Codigo", artic.Codigo);
                conexion.agregarParametro("@Nombre", artic.Nombre);
                conexion.agregarParametro("@Descripcion", artic.Descripcion);
                conexion.agregarParametro("@Precio", artic.Precio);
                conexion.agregarParametro("@ImagenUrl", artic.ImagenUrl);
                conexion.agregarParametro("@IdCategoria", artic.Categoria.Id);
                conexion.agregarParametro("@IdMarca", artic.Marca.Id);
                conexion.ejecutarAccion();
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void eliminar(int id)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearQuery("Delete From ARTICULOS Where Id=@Id");
                conexion.agregarParametro("@Id", id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
