using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket.Reportes
{
    public partial class Frm_Productos_re : Form
    {
        public Frm_Productos_re()
        {
            InitializeComponent();
        }

        private void Frm_Productos_re_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data.USP_Listado_p' Puede moverla o quitarla según sea necesario.
            this.USP_Listado_pTableAdapter.Fill(this.data.USP_Listado_p, cTexto: txt_Reportes.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
