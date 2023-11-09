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
    public partial class Frm_Reportes_ca : Form
    {
        public Frm_Reportes_ca()
        {
            InitializeComponent();
        }

        private void Frm_Reportes_ca_Load(object sender, EventArgs e)
        {
            this.USP_Listado_caTableAdapter.Fill(this.data.USP_Listado_ca, cTexto: txt_reportes.Text);
       
            this.reportViewer1.RefreshReport();
        }
    }
}
