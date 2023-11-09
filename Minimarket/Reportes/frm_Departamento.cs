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
    public partial class frm_Departamento : Form
    {
        public frm_Departamento()
        {
            InitializeComponent();
        }

        private void frm_Departamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data.USP_Listado_de' Puede moverla o quitarla según sea necesario.
            this.USP_Listado_deTableAdapter.Fill(this.data.USP_Listado_de, cTexto: txt_Reportes.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
