using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimarketEntidades
{
    public class E_Productos
    {
        public int codigo_p { get; set; }
        public string descripcion_p{ get; set; }

        public int codigo_m { get; set; }

        public int codigo_um { get; set; }

        public int codigo_ca { get; set; }

        public decimal stock_min { get; set; }

        public decimal stock_max { get; set; }
    }
}
