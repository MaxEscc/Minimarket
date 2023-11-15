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
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            //Desabiliatar casilla de mantenimiento 
            InitializeComponent();
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Estado_BotonesProcesos(false);


        }

        #region "Variables"
        int codigo_p = 0;
        int codigo_m = 0;
        int codigo_um = 0;
        int codigo_ca = 0;
        int EstadoGuarda = 0; //
        #endregion

        #region"Metodos"
        private void Formato_p()
        {
            dataGridViewListado.Columns[0].Width = 50;
            dataGridViewListado.Columns[0].HeaderText = "CODIGO_P";
            dataGridViewListado.Columns[1].Width = 100;
            dataGridViewListado.Columns[1].HeaderText = "PRODUCTOS";
            //
            dataGridViewListado.Columns[2].Width = 100;
            dataGridViewListado.Columns[2].HeaderText = "MARCA";
            dataGridViewListado.Columns[3].Width = 100;
            dataGridViewListado.Columns[3].HeaderText = "UM";
            dataGridViewListado.Columns[4].Width = 100;
            dataGridViewListado.Columns[4].HeaderText = "CATEGORIA";
            dataGridViewListado.Columns[5].Width = 70;
            dataGridViewListado.Columns[5].HeaderText = "STOCK_MIN";
            dataGridViewListado.Columns[6].Width = 70;
            dataGridViewListado.Columns[6].HeaderText = "STOCK_MAX";
            dataGridViewListado.Columns[7].Visible = false;

            dataGridViewListado.Columns[8].Visible = false;
            dataGridViewListado.Columns[9].Visible = false;
        }
        private void Listado_p(string cTexto)
        {
            try
            {
                dataGridViewListado.DataSource = N_Productos.Listado_p(cTexto);
                this.Formato_p();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        #endregion

        private void Formato_m()
        {
            dataGridViewMarcas.Columns[0].Width = 200;
            dataGridViewMarcas.Columns[0].HeaderText = "MARCA";

            dataGridViewMarcas.Columns[1].Visible = false;

        }
        private void Listado_m(string cTexto)
        {
            try
            {
                dataGridViewMarcas.DataSource = N_Productos.Listado_m_p(cTexto);
                this.Formato_m();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Formato_stock_actual()
        {
            dataGridViewStock_actual.Columns[0].Width = 200;
            dataGridViewStock_actual.Columns[0].HeaderText = "ALMACEN";
            dataGridViewStock_actual.Columns[1].Width = 200;
            dataGridViewStock_actual.Columns[1].HeaderText = "STOCK ACTUAL";
            dataGridViewStock_actual.Columns[2].Width = 200;
            dataGridViewStock_actual.Columns[2].HeaderText = "PRECIO UNITARIO";

        }
        private void Listado_stock_actual(int nCodigo_p)
        {
            try
            {
                dataGridViewStock_actual.DataSource = N_Productos.Listado_stock_actual(nCodigo_p);
                this.Formato_stock_actual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }



        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_p("%");
            this.Listado_m("%");
            this.Listado_um_p("%");
            this.Listado_ca_p("%");


            txt_Buscar.Text = "Buscar";

            txt_Buscar.GotFocus += TextBox1_GotFocus;
            txt_Buscar.LostFocus += txt1_LostFocus;
            txt_Buscar.ForeColor = Color.Gray; // Cambia el color del texto a gris
            txt_Buscar.BackColor = Color.White;

            //Manita boton de buscar
            btn_buscar.Cursor = Cursors.Hand;
            btn_nuevo.Cursor = Cursors.Hand;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_actualizar.Cursor = Cursors.Hand;
            btn_report.Cursor = Cursors.Hand;
            btn_salir.Cursor = Cursors.Hand;
            //botones de procesos
            btn_cancelar.Cursor = Cursors.Hand;
            btn_guardar.Cursor = Cursors.Hand;
            btn_regresar.Cursor = Cursors.Hand;


            //

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_m_descripcion.Text == String.Empty ||
                txt_marca.Text == String.Empty ||
                txt_m_um.Text == String.Empty ||
                txt_m_ca.Text == String.Empty)
            {
                MessageBox.Show("No se ha ingresado ningun dato (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Registrar informacion
            {
                E_Productos oPr = new E_Productos();
                string respuesta = "";
                oPr.codigo_p = this.codigo_p;
                oPr.descripcion_p = txt_m_descripcion.Text.Trim();

                oPr.codigo_m = this.codigo_m;
                oPr.codigo_um = this.codigo_um;
                oPr.codigo_ca = this.codigo_ca;
                oPr.stock_min = Convert.ToDecimal(txt_StockMin.Text);
                oPr.stock_max = Convert.ToDecimal(txt_StockMax.Text);

                respuesta = N_Productos.Guardar_p(EstadoGuarda, oPr);
                if (respuesta == "OK")
                {
                    this.Listado_p("%");
                    MessageBox.Show("Datos guardados Corresctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;//no hace nada al cumplir la tarea
                    this.Estado_BotonesPrincipales(true);
                    Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
                    this.Estado_BotonesProcesos(false);
                    txt_m_descripcion.Text = "";
                    txt_StockMin.Text = "0";
                    txt_StockMax.Text = "0";
                    txt_StockMin.ReadOnly = true;
                    txt_StockMax.ReadOnly = true;
                    txt_m_descripcion.ReadOnly = true;
                    Tc_Marcas.SelectedIndex = 0;
                    this.codigo_p = 0;
                    groupBox_Detalle.Visible = false;

                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.btn_nuevo.Enabled = lEstado;
            this.btn_actualizar.Enabled = lEstado;
            this.btn_eliminar.Enabled = lEstado;
            this.btn_report.Enabled = lEstado;
            this.btn_salir.Enabled = lEstado;

        }


        private void Estado_BotonesProcesos(bool lEstado)
        {
            this.btn_cancelar.Visible = lEstado;
            this.btn_guardar.Visible = lEstado;
            this.btn_regresar.Visible = !lEstado;
        }

        //metodo para seleccionar el item 
        private void Seleciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_p"].Value)))
            {
                
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
            }
            else
            {
                this.codigo_p = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_p"].Value);
                txt_m_descripcion.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_p"].Value);
                //
                this.codigo_m = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_m"].Value);
                txt_marca.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_m"].Value);
                //
                this.codigo_um = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_um"].Value);
                txt_m_um.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_um"].Value);
                //
                this.codigo_ca = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_ca"].Value);
                txt_m_ca.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_ca"].Value);
                //
                txt_StockMin.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["stock_min"].Value);
                txt_StockMax.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["stock_max"].Value);
                //
                groupBox_Detalle.Visible = true;

            }
        }

        //
        private void Seleciona_item_m_p()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewMarcas.CurrentRow.Cells["codigo_m"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_m = Convert.ToInt32(dataGridViewMarcas.CurrentRow.Cells["codigo_m"].Value);
            txt_marca.Text = Convert.ToString(dataGridViewMarcas.CurrentRow.Cells["descripcion_m"].Value);
            }
        }

        //
        private void Formato_um()
        {
            dataGridViewUnidades.Columns[0].Width = 200;
            dataGridViewUnidades.Columns[0].HeaderText = "Medidas";

            dataGridViewUnidades.Columns[1].Visible = false;

        }
        private void Listado_um_p(string cTexto)
        {
            try
            {
                dataGridViewUnidades.DataSource = N_Productos.Listado_um_p(cTexto);
                this.Formato_um();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Seleciona_item_um_p()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewUnidades.CurrentRow.Cells["codigo_um"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_um = Convert.ToInt32(dataGridViewUnidades.CurrentRow.Cells["codigo_um"].Value);
                txt_m_um.Text = Convert.ToString(dataGridViewUnidades.CurrentRow.Cells["descripcion_um"].Value);
            }
        }

        private void Formato_ca_p()
        {
            dataGridViewMcATEGORIAS.Columns[0].Width = 200;
            dataGridViewMcATEGORIAS.Columns[0].HeaderText = "CATEGORIAS";

            dataGridViewMcATEGORIAS.Columns[1].Visible = false;

        }
        private void Listado_ca_p(string cTexto)
        {
            try
            {
                dataGridViewMcATEGORIAS.DataSource = N_Productos.Listado_ca_p(cTexto);
                this.Formato_ca_p();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        private void Seleciona_item_ca_p()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewMcATEGORIAS.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_ca = Convert.ToInt32(dataGridViewMcATEGORIAS.CurrentRow.Cells["codigo_ca"].Value);
                txt_m_ca.Text = Convert.ToString(dataGridViewMcATEGORIAS.CurrentRow.Cells["descripcion_ca"].Value);
            }
        }



        //boton agregar nuevo registro
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            groupBox_Detalle.Visible = false;

            EstadoGuarda = 1; //nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);

            txt_m_descripcion.Text = "";
            txt_StockMin.Text = "0";
            txt_StockMax.Text = "0";
            txt_m_descripcion.ReadOnly = false;
            txt_StockMin.ReadOnly = false;
            txt_StockMax.ReadOnly = false;
            Tc_Marcas.SelectedIndex = 1;
            txt_m_descripcion.Focus();
        }

        //boton actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
         
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            groupBox_Detalle.Visible = false;
            EstadoGuarda = 2; //actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            Tc_Marcas.SelectedIndex = 1;
            this.Seleciona_item();
            txt_m_descripcion.ReadOnly = false;
            txt_m_descripcion.Focus();
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0; //no hace nada 
            this.codigo_p = 0;
            txt_m_descripcion.Text = "";
            txt_marca.Text= "";

            txt_StockMin.Text = "0";
            txt_StockMax.Text = "0";
       
            txt_StockMin.ReadOnly = true;
            txt_StockMax.ReadOnly = true;

            groupBox_Detalle.Visible = false;

            txt_m_descripcion.ReadOnly = true;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProcesos(false);
            Tc_Marcas.SelectedIndex = 0;
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
        }

        //Doble clic en el DataGrid para visualizar un registro
        private void dataGridViewListado_DoubleClick(object sender, EventArgs e)
        {
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            this.Seleciona_item();
            this.Estado_BotonesProcesos(false);
            this.Tc_Marcas.SelectedIndex = 1;
            this.Listado_stock_actual(this.codigo_p);
            groupBox_Detalle.Visible = true;
        }

        //boton de regreso
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesProcesos(false);
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Tc_Marcas.SelectedIndex = 0;
            this.codigo_p = 0;
            groupBox_Detalle.Visible = false;
        }

        //boton para eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_p"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Estas seguro que deseas eliminar este registro", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string respuesta = "";
                    this.codigo_p = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_p"].Value);
                    respuesta = N_Productos.Eliminar_p(this.codigo_p);

                    if (respuesta.Equals("OK"))
                    {
                        this.Listado_p("%");
                        this.codigo_p = 0;
                        MessageBox.Show("Registro eliminado", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
             Reportes.Frm_Productos_re oReporte_p = new Reportes.Frm_Productos_re();
             oReporte_p.txt_Reportes.Text = dataGridViewListado.Text;
              oReporte_p.ShowDialog();

        }

        //Buscar 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_p(txt_Buscar.Text.Trim());
        }

        //Refrescar los registros en el dataGrid
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Listado_p(dataGridViewListado.Text.Trim());
        }

        //boton para cerrar el sistema
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            this.panel_Listado_marca.Visible = true;
            this.panel_Listado_marca.Location = btn_lupa.Location;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void dataGridViewMarcas_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_item_m_p();
            panel_Listado_marca.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_lupa_medida_Click(object sender, EventArgs e)
        {
            this.panel_listado_um.Visible = true;
            this.panel_listado_um.Location = btn_lupa_medida.Location;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            this.Listado_m(txt_m_l_marca.Text);
        }

        private void btn_buscar_um_Click(object sender, EventArgs e)
        {
            this.Listado_um_p(txt_m_b_um.Text);
        }

        private void btn_marca_retornar_Click(object sender, EventArgs e)
        {
            panel_Listado_marca.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

        }

        private void btn_um_retornar_Click(object sender, EventArgs e)
        {
            panel_listado_um.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void dataGridViewUnidades_DoubleClick(object sender, EventArgs e)
        {
               this.Seleciona_item_um_p();
            panel_listado_um.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel_listado_ca.Visible = true;
            this.panel_listado_ca.Location = btn_lupa_medida.Location;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void dataGridViewMcATEGORIAS_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_item_ca_p();
            panel_listado_ca.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }


        //retornar panel categorias
        private void btn_m_regredar_ca_Click(object sender, EventArgs e)
        {
            panel_listado_ca.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_b_m_ca_Click(object sender, EventArgs e)
        {
            this.Listado_ca_p(txt_m_b_um.Text);
        }

        private void dataGridViewListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewListado_Click(object sender, EventArgs e)
        {
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
        }
    }
}

