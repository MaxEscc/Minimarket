﻿using System;
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
    public partial class Frm_Reportes_Almacen : Form
    {
        public Frm_Reportes_Almacen()
        {
            InitializeComponent();
        }

        private void Frm_Reportes_Almacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'data.USP_Listado_al' Puede moverla o quitarla según sea necesario.
            this.uSP_Listado_alTableAdapter.Fill(this.data.USP_Listado_al, cTexto: txt_Reportes.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
