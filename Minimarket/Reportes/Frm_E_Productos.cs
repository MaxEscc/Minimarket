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
    public partial class Frm_E_Productos : Form
    {
        public Frm_E_Productos()
        {
            InitializeComponent();
        }

        private void Frm_E_Productos_Load(object sender, EventArgs e)
        {
            this.USP_Listado_epTableAdapter.Fill(this.data.USP_Listado_ep, cTexto: txt_Reportes.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
