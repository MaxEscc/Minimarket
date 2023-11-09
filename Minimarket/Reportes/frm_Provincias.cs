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
    public partial class frm_Provincias : Form
    {
        public frm_Provincias()
        {
            InitializeComponent();
        }

        private void frm_Provincias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data.USP_Listado_po' Puede moverla o quitarla según sea necesario.
            this.USP_Listado_poTableAdapter.Fill(this.data.USP_Listado_po, cTexto: txt_reportes.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
