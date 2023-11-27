using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinimarketEntidades;
using MinimarketNegocio;


namespace Minimarket
{
    public partial class Frm_E_Productos : Form
    {
        public Frm_E_Productos()
        {
            //Desabiliatar casilla de mantenimiento 
            InitializeComponent();
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Estado_BotonesProcesos(false);


        }

        #region "Variables"
        int codigo_ep = 0;
        int codigo_ed = 0;
        int codigo_pv = 0;
        int codigo_al = 0;
        int EstadoGuarda = 0;
        DataTable TablaDetalle = new DataTable();

        #endregion

        #region"Metodos"
        private void Formato_ep()
        {
            dataGridViewListado.Columns[0].Width = 30;
            dataGridViewListado.Columns[0].HeaderText = "CODIGO_EP";
            dataGridViewListado.Columns[1].Width = 30;
            dataGridViewListado.Columns[1].HeaderText = "TIPO DOC.";
            dataGridViewListado.Columns[2].Width = 50;
            dataGridViewListado.Columns[2].HeaderText = "nro documento";
            dataGridViewListado.Columns[3].Width = 50;
            dataGridViewListado.Columns[3].HeaderText = "FECHA DOC.";
            dataGridViewListado.Columns[4].Width = 50;
            dataGridViewListado.Columns[4].HeaderText = "PROVEEDOR";
            dataGridViewListado.Columns[5].Width = 30;
            dataGridViewListado.Columns[5].HeaderText = "ALMACEN";
            dataGridViewListado.Columns[6].Width = 100;
            dataGridViewListado.Columns[6].HeaderText = "TOTAL IMPORTE";
            dataGridViewListado.Columns[7].Visible = false;
            dataGridViewListado.Columns[8].Visible = false;
            dataGridViewListado.Columns[9].Visible = false;
            dataGridViewListado.Columns[10].Visible = false;
            dataGridViewListado.Columns[11].Visible = false;
            dataGridViewListado.Columns[12].Visible = false;



        }
        private void Listado_ep(string cTexto)
        {
            try
            {
                dataGridViewListado.DataSource = N_E_Productos.Listado_ep(cTexto);
                this.Formato_ep();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        #endregion

        private void Formato_ed()
        {
            dataGridViewTD.Columns[0].Width = 200;
            dataGridViewTD.Columns[0].HeaderText = "TIPO DOCUMENTO";
            dataGridViewTD.Columns[1].Visible = false;

        }
        private void Listado_ed()
        {
            try
            {
                dataGridViewTD.DataSource = N_E_Productos.Listado_ed();
                this.Formato_ed();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_ed()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewTD.CurrentRow.Cells["codigo_ed"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_ed = Convert.ToInt32(dataGridViewTD.CurrentRow.Cells["codigo_ed"].Value);
                txt_E_TD.Text = Convert.ToString(dataGridViewTD.CurrentRow.Cells["descripcion_d"].Value);
            }
        }


        
        private void Formato_al()
        {
            data_Almacen.Columns[0].Width = 50;
            data_Almacen.Columns[0].HeaderText = "ALMACEN";
            data_Almacen.Columns[1].Visible = false;
         


        }
        private void Listado_al()
        {
            try
            {
                data_Almacen.DataSource = N_E_Productos.Listado_e_al();
                this.Formato_al();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_al()
        {
            if (string.IsNullOrEmpty(Convert.ToString(data_Almacen.CurrentRow.Cells["codigo_al"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_al = Convert.ToInt32(data_Almacen.CurrentRow.Cells["codigo_al"].Value);
                txt_e_al.Text = Convert.ToString(data_Almacen.CurrentRow.Cells["descripcion_al"].Value);
            }
        }
       
        private void Formato_pv()
        {
            dataGridViewPV.Columns[0].Width = 100;
            dataGridViewPV.Columns[0].HeaderText = "PROVEEDOR";
            dataGridViewPV.Columns[1].Width = 100;
            dataGridViewPV.Columns[1].HeaderText = "TIPO DOC.";
            dataGridViewPV.Columns[2].Width = 100;
            dataGridViewPV.Columns[2].HeaderText = "DNI";
            dataGridViewPV.Columns[3].Visible = false;


        }
        private void Listado_pv(string cTexto)
        {
            try
            {
                dataGridViewPV.DataSource = N_E_Productos.Listado_epv(cTexto);
                this.Formato_pv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_pv()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewPV.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_pv = Convert.ToInt32(dataGridViewPV.CurrentRow.Cells["codigo_pv"].Value);
                txt_E_pv.Text = Convert.ToString(dataGridViewPV.CurrentRow.Cells["razon_social_pv"].Value);
                             
            }
        }

        private void agregar_item(string cdescripcion_p,
                                  string cdescripcion_m,
                                   string cdescripcion_um,
                                   decimal ncantidad,
                                   decimal npu_compra,
                                   decimal ntotal,
                                   int ncodigo_p)
        {
            DataRow xFila = TablaDetalle.NewRow();
            xFila["descripcion_p"] = cdescripcion_p;
            xFila["descripcion_m"] = cdescripcion_m;
            xFila["descripcion_um"] = cdescripcion_um;
            xFila["cantidad"] = ncantidad;
            xFila["pu_compra"] = npu_compra;
            xFila["total"] = ntotal;
            xFila["codigo_p"] = ncodigo_p;
            this.TablaDetalle.Rows.Add(xFila);
            TablaDetalle.AcceptChanges();

        }




        private void Formato_Eproductos()
        {
            dataGridView_Productos.Columns[0].Width = 100;
            dataGridView_Productos.Columns[0].HeaderText = "PRODUCTO";
            dataGridView_Productos.Columns[1].Width = 100;
            dataGridView_Productos.Columns[1].HeaderText = "MARCA";
            dataGridView_Productos.Columns[2].Width = 100;
            dataGridView_Productos.Columns[2].HeaderText = "U.MEDIDA";
            dataGridView_Productos.Columns[3].Width = 100;
            dataGridView_Productos.Columns[3].HeaderText = "CATEGORIA";
            dataGridView_Productos.Columns[4].Visible = false;




        }
        private void Listado_Eproductos(string cTexto)
        {
            try
            {
                dataGridView_Productos.DataSource = N_E_Productos.Listado_Eproductos(cTexto);
                this.Formato_Eproductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_Eproductos()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridView_Productos.CurrentRow.Cells["codigo_p"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string xdescripcion_p;
                string xdescripcion_m;
                string xdescripcion_um;
                decimal xcantidad;
                decimal xpu_compra;
                decimal xtotal;
                int xcodigo_p;

                bool Agregar = true;

                xcodigo_p = Convert.ToInt32(dataGridView_Productos.CurrentRow.Cells["codigo_p"].Value);
                foreach(DataRow Filatemp in TablaDetalle.Rows)
                {
                    if (Convert.ToInt32(Filatemp["codigo_p"]) == xcodigo_p)
                    {
                        Agregar = false;
                        MessageBox.Show("El producto ya se encuentra registrado","Aviso del sistema");
                    }
                }
                if (Agregar==true)
                {

                    xdescripcion_p = Convert.ToString(dataGridView_Productos.CurrentRow.Cells["descripcion_p"].Value);
                    xdescripcion_m = Convert.ToString(dataGridView_Productos.CurrentRow.Cells["descripcion_m"].Value);
                    xdescripcion_um = Convert.ToString(dataGridView_Productos.CurrentRow.Cells["descripcion_um"].Value);
                    xcantidad =Convert.ToDecimal(0.00);
                    xpu_compra = Convert.ToDecimal(0.00);
                    xtotal = Convert.ToDecimal(0.00);

                    this.agregar_item(xdescripcion_p,
                                      xdescripcion_m,
                                      xdescripcion_um,
                                      xcantidad,
                                      xpu_compra,
                                      xtotal,
                                      xcodigo_p);
                }
            }
        }


        private void Frm_E_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_ep("%");
            this.Listado_ed();
            this.Listado_pv("%");
            this.Listado_al();
            this.Listado_Eproductos("%");


            txt_Buscar.Text = "Buscar";

            txt_Buscar.GotFocus += TextBox1_GotFocus;
            txt_Buscar.LostFocus += txt1_LostFocus;
            txt_Buscar.ForeColor = Color.Gray; // Cambia el color del texto a gris
            txt_Buscar.BackColor = Color.White;

            //Manita boton de buscar
            btn_buscar.Cursor = Cursors.Hand;
            btn_nuevo.Cursor = Cursors.Hand;
            btn_anular.Cursor = Cursors.Hand;
        
            btn_report.Cursor = Cursors.Hand;
            btn_salir.Cursor = Cursors.Hand;
            //botones de procesos
            btn_cancelar.Cursor = Cursors.Hand;
            btn_guardar.Cursor = Cursors.Hand;
            btn_regresar.Cursor = Cursors.Hand;

        }


        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.btn_nuevo.Enabled = lEstado;
   
            this.btn_anular.Enabled = lEstado;
            this.btn_report.Enabled = lEstado;
            this.btn_salir.Enabled = lEstado;

        }


        private void Estado_BotonesProcesos(bool lEstado)
        {
            this.btn_cancelar.Visible = lEstado;
            this.btn_guardar.Visible = lEstado;
            this.btn_regresar.Visible = !lEstado;

            this.btn_Agregar.Visible = lEstado;
            this.BTN_QUITAR.Visible = lEstado;

            this.btn_lupa_TD.Visible = lEstado;
            this.btn_lupa_ALMACN.Visible = lEstado;
            this.btn_lupa_PV.Visible = lEstado;
        }

        //metodo para seleccionar el item 
        private void Seleciona_item()
        {
           if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_ep"].Value)))
            {
                
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
            }
            else
            {
          
                this.codigo_ep = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_ep"].Value);
                this.codigo_ed = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_ed"].Value);
                this.codigo_pv = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_pv"].Value);
                this.codigo_al = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_al"].Value);
                txt_E_TD.Text = dataGridViewListado.CurrentRow.Cells["descripcion_d"].Value.ToString();
                txt_E_ND.Text = dataGridViewListado.CurrentRow.Cells["nrodocumento_ep"].Value.ToString();
                dateTimePickerF.Value = Convert.ToDateTime(dataGridViewListado.CurrentRow.Cells["fecha_ep"].Value);
                txt_E_pv.Text = dataGridViewListado.CurrentRow.Cells["razon_social_pv"].Value.ToString();
                txt_e_al.Text = dataGridViewListado.CurrentRow.Cells["descripcion_al"].Value.ToString();
                TXT_E_COMENT.Text = dataGridViewListado.CurrentRow.Cells["observacion_ep"].Value.ToString();
                txt_subTotal.Text = dataGridViewListado.CurrentRow.Cells["subtotal"].Value.ToString();
                txt_iva.Text = dataGridViewListado.CurrentRow.Cells["iva"].Value.ToString();
                txt_importeT.Text = dataGridViewListado.CurrentRow.Cells["total_importe"].Value.ToString();
                dataGridViewD.DataSource = N_E_Productos.Listado_detalle_ep(this.codigo_ep);
                this.Formato_Detalle();

            }
        }

        //
        private void Crear_TablaDetalle()
        {
            this.TablaDetalle = new DataTable("TablaDetalle");
            this.TablaDetalle.Columns.Add("descripcion_p", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("descripcion_m", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("descripcion_um", System.Type.GetType("System.String"));
            this.TablaDetalle.Columns.Add("cantidad", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("pu_compra", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("total", System.Type.GetType("System.Decimal"));
            this.TablaDetalle.Columns.Add("codigo_p", System.Type.GetType("System.Int32"));
            this.TablaDetalle.AcceptChanges();

            dataGridViewD.DataSource = this.TablaDetalle;
            this.Formato_Detalle();

         
  

        }

        private void Formato_Detalle()
        {
            dataGridViewD.Columns [0].Width = 190;
            dataGridViewD.Columns [0].HeaderText = "Producto";
            dataGridViewD.Columns [1].Width = 190;
            dataGridViewD.Columns [1].HeaderText = "Marca";
            dataGridViewD.Columns [2].Width = 190;
            dataGridViewD.Columns [2].HeaderText = "U.MEDIDA";
            dataGridViewD.Columns [3].Width = 190;
            dataGridViewD.Columns [3].HeaderText = "CANTIDAD";
            dataGridViewD.Columns [4].Width = 190;
            dataGridViewD.Columns [4].HeaderText = "PU.COMPRA";
            dataGridViewD.Columns [5].Width = 190;
            dataGridViewD.Columns [5].HeaderText = "TOTAL";
            dataGridViewD.Columns [6].Visible = false;
            dataGridViewD.Columns[0].ReadOnly = true;
            dataGridViewD.Columns[1].ReadOnly = true;
            dataGridViewD.Columns[2].ReadOnly = true;
            dataGridViewD.Columns[3].ReadOnly = true;
            dataGridViewD.Columns[4].ReadOnly = true;
            dataGridViewD.Columns[5].ReadOnly = true;
        }

     
        private void  EstadoTexto(bool lestado)
        {
            txt_E_ND.ReadOnly = !lestado;
            TXT_E_COMENT.ReadOnly = !lestado;
            dateTimePickerF.Enabled = lestado;
        }

        private void LimpiaTexto()
        {
            txt_E_ND.Text = "";
            TXT_E_COMENT.Text = "";
            txt_subTotal.Text = "";
            txt_iva.Text = "";
            txt_importeT.Text = "";

            txt_E_TD.Text = "";
            txt_E_pv.Text = "";
            txt_e_al.Text = "";


            this.Crear_TablaDetalle();
        }



        private void CalcularTotal()
        {
            decimal nsubtotal = 0;
            decimal niva = 0;
            decimal ntotal_importe = 0;

            if (dataGridViewD.Rows.Count == 0)
            {
                nsubtotal = 0;
                niva = 0;
                ntotal_importe = 0;
            }
            else
            {
                
                foreach (DataRow Filatemp in TablaDetalle.Rows)
                {
                    ntotal_importe += Convert.ToDecimal(Filatemp["total"]); // Sumar el total de cada fila
                }

                nsubtotal = ntotal_importe / (1 + Convert.ToDecimal("0.16")); // Calcular el subtotal
                niva = ntotal_importe - nsubtotal; // Calcular el IVA

                txt_subTotal.Text = decimal.Round(nsubtotal, 2).ToString("#0.00"); // Mostrar el subtotal redondeado a 2 decimales
                txt_iva.Text = decimal.Round(niva, 2).ToString("#0.00"); // Mostrar el IVA redondeado a 2 decimales
                txt_importeT.Text = decimal.Round(ntotal_importe, 2).ToString("#0.00"); // Mostrar el total redondeado a 2 decimales


            }
        }




        //boton agregar nuevo registro
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1;
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.LimpiaTexto();

            dataGridViewD.Columns[3].ReadOnly = false;
            dataGridViewD.Columns[4].ReadOnly = false;

            this.EstadoTexto(true);
 
            Tc_Marcas.SelectedIndex = 1;

            
        }


        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           this.codigo_ep = 0;
            this.codigo_ed = 0;
            this.codigo_pv = 0;
            this.codigo_al = 0;

            this.EstadoGuarda = 0;
 
            this.EstadoTexto(false);
            this.LimpiaTexto();

            dataGridViewD.Columns[3].ReadOnly = true;
            dataGridViewD.Columns[4].ReadOnly = true                                                                                    ;

            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProcesos(false);
            Tc_Marcas.SelectedIndex = 0;
        
            }

        //Doble clic en el DataGrid para visualizar un registro
        private void dataGridViewListado_DoubleClick(object sender, EventArgs e)
        {
          
            this.Seleciona_item();
            this.Estado_BotonesProcesos(false);
            Tc_Marcas.SelectedIndex = 1;
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            btn_regresar.Enabled = true;
        }

        //boton de regreso
        private void btn_regresar_Click(object sender, EventArgs e)
        {

            this.Estado_BotonesProcesos(false);
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Tc_Marcas.SelectedIndex = 0;
               this.LimpiaTexto();
       
        }

        //boton para eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_ep"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Estas seguro que deseas anular este registro", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string respuesta = "";
                    this.codigo_ep = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_ep"].Value);
                    respuesta = N_E_Productos.Eliminar_ep(this.codigo_ep);

                    if (respuesta.Equals("OK"))
                    {
                        this.Listado_ep("%");
                        this.codigo_ep = 0;
                        MessageBox.Show("Registro anulado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        //buscar por palabra clave 
        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {

            string palabraClave = txt_Buscar.Text;
        }


        //metodo para agregar la palabra buscar en el textbox
        private void TextBox1_GotFocus(object sender, EventArgs e)
        {

            // Cuando la caja de texto recibe el foco (haciendo clic en ella), borra el mensaje predeterminado y restaura la opacidad
            if (txt_Buscar.Text == "Buscar")
            {
                txt_Buscar.Text = "";
                txt_Buscar.ForeColor = SystemColors.WindowText; // Restaura el color del texto
            }
        }

        private void txt1_LostFocus(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_Buscar.Text))
            {

                txt_Buscar.Text = "Buscar";
                txt_Buscar.ForeColor = Color.Gray; // Cambia el color del texto a gris
                txt_Buscar.BackColor = Color.White;

            }
        }

        //generar reportes
        private void btn_report_Click(object sender, EventArgs e)
        {
             Reportes.Frm_E_Productos oReporte_EP = new Reportes.Frm_E_Productos();
             oReporte_EP.txt_Reportes.Text = dataGridViewListado.Text;
              oReporte_EP.ShowDialog();

        }

        //Buscar 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ep(txt_Buscar.Text.Trim());
        }

        //Refrescar los registros en el dataGrid
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Listado_ep(dataGridViewListado.Text.Trim());
        }

        //boton para cerrar el sistema
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //tipo de documento
        private void btn_lupa_Click(object sender, EventArgs e)
        {
            
            this.panel_listado_td.Location = btn_lupa_TD.Location;
            this.panel_listado_td.Visible = true;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

 

        private void dataGridViewListado_Click(object sender, EventArgs e)
        {
     
            btn_anular.Enabled = true;
        }

        
        
        private void btn_lupa_SX_Click(object sender, EventArgs e)
        {
            // Definir la posición del panel a la izquierda del botón
             int panelWidth = PANELPV.Width; // Ancho del panel
             int panelX = btn_lupa_PV.Location.X - panelWidth - 5; // Ajuste de 5 píxeles para separación
             int panelY = btn_lupa_PV.Location.Y;

            // Ubicar el panel al lado izquierdo del botón
             PANELPV.Location = new Point(panelX, panelY);

            // Hacer visible el panel
              PANELPV.Visible = true;


            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }


        private void btn_lupa_rubro_Click(object sender, EventArgs e)
        {
            // Definir la posición del panel a la izquierda del botón
            int panelWidth = panel_AL.Width; // Ancho del panel
            int panelX = btn_lupa_ALMACN.Location.X - panelWidth - 5; // Ajuste de 5 píxeles para separación
            int panelY = btn_lupa_ALMACN.Location.Y;

            // Ubicar el panel al lado izquierdo del botón
            panel_AL.Location = new Point(panelX, panelY);

            // Hacer visible el panel
            panel_AL.Visible = true;


            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }


        private void dataGridViewTD_DoubleClick_1(object sender, EventArgs e)
        {
            this.Seleciona_ed();
            panel_listado_td.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_m_regredar_ca_Click_1(object sender, EventArgs e)
        {
            panel_listado_td.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void dataGridViewPV_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_pv();
             PANELPV.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_regresar_pv_Click(object sender, EventArgs e)
        {
             PANELPV.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void data_Almacen_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_al();
             panel_AL.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_regresar_al_Click(object sender, EventArgs e)
        {
            panel_AL.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            panel_Productos.Location = btn_Agregar.Location;
            panel_Productos.Visible = true;

        }

        private void btn_regresar_p_Click(object sender, EventArgs e)
        {
            panel_Productos.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void dataGridView_Productos_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_Eproductos();
            panel_Productos.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void dataGridViewD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (this.EstadoGuarda==1)
            {

          
            DataRow yFila = (DataRow)TablaDetalle.Rows[e.RowIndex];
            decimal ycantidad = Convert.ToDecimal(yFila["cantidad"]);
            decimal y_pu_compra = Convert.ToDecimal(yFila["pu_compra"]);

            yFila["TOTAL"]=decimal.Round(ycantidad * y_pu_compra,2).ToString("#0.00");
            this.CalcularTotal();

            }
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (txt_E_TD.Text==string.Empty ||
                txt_E_ND.Text==string.Empty ||
                txt_E_pv.Text==string.Empty ||
                txt_e_al.Text==string.Empty ||
                txt_importeT.Text==string.Empty)
            {
                MessageBox.Show("No se ha ingresado ningun dato (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Registrar informacion
            {

                string respuesta = "";
                E_E_Productos oEp = new E_E_Productos();
                oEp.codigo_ep = this.codigo_ep;
                oEp.codigo_ed = this.codigo_ed;
                oEp.nrodocumento_ep = txt_E_ND.Text.Trim();
                oEp.codigo_pv = this.codigo_pv;
                oEp.fecha_ep = dateTimePickerF.Value;
                oEp.codigo_al = this.codigo_al;
                oEp.observacion_pv = TXT_E_COMENT.Text.Trim();
                oEp.subtotal =Convert.ToDecimal(txt_subTotal.Text.Trim());
                oEp.iva = Convert.ToDecimal(txt_iva.Text.Trim());
                oEp.total_importe = Convert.ToDecimal(txt_importeT.Text.Trim());

                this.TablaDetalle.AcceptChanges();

                  respuesta = N_E_Productos.Guardar_ep(oEp, TablaDetalle);
                if (respuesta.Equals("OK"))
                {
                  this.Listado_ep("%");
                    MessageBox.Show("Datos guardados Corresctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    this.Estado_BotonesPrincipales(true);
                    Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
                    this.Estado_BotonesProcesos(false);

                    EstadoTexto(false);

                    dataGridViewD.Columns[3].ReadOnly = true;
                    dataGridViewD.Columns[4].ReadOnly = true;
                    Tc_Marcas.SelectedIndex = 0;
                    this.codigo_ep = 0;
                    this.codigo_ed = 0;
                    this.codigo_pv = 0;
                    this.codigo_al = 0;
                    this.LimpiaTexto();
                    this.EstadoGuarda = 0;

                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BTN_QUITAR_Click(object sender, EventArgs e)
        {
            if (dataGridViewD.Rows.Count>0)
            {
                dataGridViewD.Rows.Remove(dataGridViewD.CurrentRow);
                dataGridViewD.Refresh();
                TablaDetalle.AcceptChanges();
                this.CalcularTotal();
                  
            }
        }
    }
}

