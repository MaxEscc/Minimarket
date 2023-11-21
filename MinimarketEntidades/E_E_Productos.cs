using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimarketEntidades
{
   public class E_E_Productos
    {

        public int codigo_ep { get; set; }

        public  int codigo_ed { get; set; }

        public string nrodocumento_ep { get; set; } 

        public int codigo_pv { get; set; }

        public DateTime fecha_ep { get; set; }
        public int codigo_al { get; set; }
        public string observacion_pv { get; set; }

        public decimal subtotal { get; set; }

        public decimal iva { get; set; }

        public decimal total_importe { get; set; }


    }
}
