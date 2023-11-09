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
    public partial class Frm_Rubro : Form
    {
        public Frm_Rubro()
        {
            InitializeComponent();
        }

        private void Frm_Rubro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data.USP_Listado_rb' Puede moverla o quitarla según sea necesario.
            this.USP_Listado_rbTableAdapter.Fill(this.data.USP_Listado_rb, cTexto: txt_reportes.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
