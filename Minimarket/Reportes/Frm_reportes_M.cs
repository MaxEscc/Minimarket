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
    public partial class Frm_reportes_M : Form
    {
        public Frm_reportes_M()
        {
            InitializeComponent();
        }

        private void Frm_reportes_M_Load(object sender, EventArgs e)
        {
            this.USP_Listado_maTableAdapter.Fill(this.data.USP_Listado_ma, cTexto: txt_reportes.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
