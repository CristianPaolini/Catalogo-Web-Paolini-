using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ItemCarrito
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public int Cantidad { get; set; }
        public SqlMoney PrecioUnitario { get; set; }
    }
}
