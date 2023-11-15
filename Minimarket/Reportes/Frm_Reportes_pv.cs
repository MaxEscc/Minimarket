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
    public partial class Frm_Reportes_pv : Form
    {
        public Frm_Reportes_pv()
        {
            InitializeComponent();
        }

        private void Frm_Reportes_pv_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data.USP_Listado_pv' Puede moverla o quitarla según sea necesario.
            this.USP_Listado_pvTableAdapter.Fill(this.data.USP_Listado_pv, cTexto: txt_reportes.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
