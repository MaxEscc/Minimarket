    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimarketEntidades
{
   public class E_Proveedores
    {
        public int codigo_pv { get; set; }
        public int codigo_pc { get; set; }
        public string nrodocumentopv { get; set; }
        public string razon_social_pv { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int codigo_rb { get; set; }
        public int codigo_sx { get; set; }

        public string email_pv { get; set; }
        public string telefono_pv { get; set; }
        public string movil_pv { get; set; }

        public string direccion_pv { get; set; }

        public int codigo_dis { get; set; }
        public string observacion_pv { get; set; }



    }
}
