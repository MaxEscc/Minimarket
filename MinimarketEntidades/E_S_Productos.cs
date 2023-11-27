using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimarketEntidades
{
    public class E_S_Productos
    {

        public int codigo_sp{ get; set; }

        public int codigo_ed { get; set; }

        public string nrodocumento_sp { get; set; }

        public int codigo_cl { get; set; }

        public string nrodocumento_cl { get; set; }

        public string razon_social_cl { get; set; }

        public DateTime fecha_sp { get; set; }
   
        public string observacion_sp { get; set; }

        public decimal subtotal { get; set; }

        public decimal iva { get; set; }

        public decimal total_importe { get; set; }


    }
}
