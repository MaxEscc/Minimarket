using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimarketEntidades
{
    public class E_Clientes
    {
        public int codigo_cl { get; set; }
        public int codigo_pc { get; set; }
        public string nrodocumento_cl { get; set; }
        public string razon_social_cl { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int codigo_rb { get; set; }
        public int codigo_sx { get; set; }

        public string email_cl { get; set; }
        public string telefono_cl { get; set; }
        public string movil_cl { get; set; }

        public string direccion_cl { get; set; }

        public int codigo_dis { get; set; }
        public string observacion_cl { get; set; }



    }
}
