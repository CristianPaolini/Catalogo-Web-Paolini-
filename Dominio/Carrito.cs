using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public SqlMoney MontoTotal { get; set; }

        public int CantidadArticulos { get; set; }

        public Carrito()
        {
            MontoTotal = 0;
        }

    }

}
