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
    public partial class Frm_Proveedores : Form
    {
        public Frm_Proveedores()
        {
            //Desabiliatar casilla de mantenimiento 
            InitializeComponent();
            //Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Estado_BotonesProcesos(false);


        }

        #region "Variables"
        int codigo_pv = 0;
        int codigo_pc = 0;
        int codigo_sx = 0;
        int codigo_rb = 0;
        int codigo_dis = 0;



        int EstadoGuarda = 0; //
        #endregion

        #region"Metodos"
        private void Formato_pv()
        {
            dataGridViewListado.Columns[0].Width = 50;
            dataGridViewListado.Columns[0].HeaderText = "CODIGO_Pv";
            dataGridViewListado.Columns[1].Width = 100;
            dataGridViewListado.Columns[1].HeaderText = "TIPO DOC";
            //
            dataGridViewListado.Columns[2].Width = 100;
            dataGridViewListado.Columns[2].HeaderText = "NRO DOC";
            dataGridViewListado.Columns[3].Width = 100;
            dataGridViewListado.Columns[3].HeaderText = "RAZON SOCIAL";
            dataGridViewListado.Columns[4].Width = 100;
            dataGridViewListado.Columns[4].HeaderText = "NOMBRES";
            dataGridViewListado.Columns[5].Width = 70;
            dataGridViewListado.Columns[5].HeaderText = "APELLIDOS";
            dataGridViewListado.Columns[6].Width = 70;
            dataGridViewListado.Columns[6].HeaderText = "RUBRO";
            dataGridViewListado.Columns[7].Visible = false;

            dataGridViewListado.Columns[8].Visible = false;
            dataGridViewListado.Columns[9].Visible = false;
            dataGridViewListado.Columns[10].Visible = false;
            dataGridViewListado.Columns[11].Visible = false;
            dataGridViewListado.Columns[12].Visible = false;
            dataGridViewListado.Columns[13].Visible = false;
            dataGridViewListado.Columns[14].Visible = false;
            dataGridViewListado.Columns[15].Visible = false;
            dataGridViewListado.Columns[16].Visible = false;
            dataGridViewListado.Columns[17].Visible = false;
        }
        private void Listado_pv(string cTexto)
        {
            try
            {
                dataGridViewListado.DataSource = N_Proveedores.Listado_pv(cTexto);
                this.Formato_pv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        #endregion

        private void Estado_texto(bool lestado)
        {
            txt_nd.ReadOnly = !lestado;
            txt_rs.ReadOnly = !lestado;
            txt_n.ReadOnly = !lestado;
            txt_a.ReadOnly = !lestado;
            txt_email.ReadOnly = !lestado;
            txt_telefono.ReadOnly = !lestado;
            txt_cel.ReadOnly = !lestado;
            txt_direccion.ReadOnly = !lestado;
            txt_comentario.ReadOnly = !lestado;
        }

        private void Limpia_texto()
        {
            txt_nd.Text = "";
            txt_rs.Text = ""; ;
            txt_n.Text = ""; ;
            txt_a.Text = ""; ;
            txt_email.Text = ""; 
            txt_telefono.Text = ""; 
            txt_telefono.Text = ""; 
            txt_direccion.Text = "" ;
            txt_comentario.Text = "";
        }


        private void Formato_pc()
        {
            dataGridView_td.Columns[0].Width = 200;
            dataGridView_td.Columns[0].HeaderText = "Tipo de documento";

            dataGridView_td.Columns[1].Visible = false;

        }
        private void Listado_pc()
        {
            try
            {
                dataGridView_td.DataSource = N_Proveedores.Listado_pc();
                this.Formato_pc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_item_pc()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridView_td.CurrentRow.Cells["codigo_pc"].Value)))
            {

                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_pc = Convert.ToInt32(dataGridView_td.CurrentRow.Cells["codigo_pc"].Value);
                txt_td.Text = Convert.ToString(dataGridView_td.CurrentRow.Cells["descripcion_pc"].Value);

            }
        }

        private void Formato_sx()
        {
            dataGridViewsx.Columns[0].Width = 200;
            dataGridViewsx.Columns[0].HeaderText = "Tipo de documento";

            dataGridViewsx.Columns[1].Visible = false;

        }
        private void Listado_sx()
        {
            try
            {
                dataGridViewsx.DataSource = N_Proveedores.Listado_sx();
                this.Formato_sx();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_item_sx()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewsx.CurrentRow.Cells["codigo_sx"].Value)))
            {

                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_sx = Convert.ToInt32(dataGridViewsx.CurrentRow.Cells["codigo_sx"].Value);
                txt_s.Text = Convert.ToString(dataGridViewsx.CurrentRow.Cells["descripcion_sx"].Value);

            }
        }


        private void Formato_RB()
        {
            dataGridViewRB.Columns[0].Width = 0;
            dataGridViewRB.Columns[0].HeaderText = "rubro";
            dataGridViewRB.Columns[1].Visible = false;

        }
        private void Listado_rb(string cTexto)
        {
            try
            {
                dataGridViewRB.DataSource = N_Proveedores.Listado_rb_pv(cTexto);
                this.Formato_RB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_item_rb()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewRB.CurrentRow.Cells["codigo_rb"].Value)))
            {

                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_rb = Convert.ToInt32(dataGridViewRB.CurrentRow.Cells["codigo_rb"].Value);
                txt_r.Text = Convert.ToString(dataGridViewRB.CurrentRow.Cells["descripcion_rb"].Value);

            }
        }

        private void Formato_dis()
        {
            dataGridViewCiudades.Columns[0].Width = 0;
            dataGridViewCiudades.Columns[0].HeaderText = "ciudades";
            dataGridViewCiudades.Columns[1].Width = 0;
            dataGridViewCiudades.Columns[1].HeaderText = "Estado";
            dataGridViewCiudades.Columns[2].Width = 0;
            dataGridViewCiudades.Columns[2].HeaderText = "Direccion";
            dataGridViewCiudades.Columns[3].Visible = false;

        }
        private void Listado_dis_pv(string cTexto)
        {
            try
            {
                dataGridViewCiudades.DataSource = N_Proveedores.Listado_dis_pv(cTexto);
                this.Formato_dis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_item_dis()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewCiudades.CurrentRow.Cells["codigo_dis"].Value)))
            {

                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.codigo_dis = Convert.ToInt32(dataGridViewCiudades.CurrentRow.Cells["codigo_dis"].Value);
                txt_ciudad.Text = Convert.ToString(dataGridViewCiudades.CurrentRow.Cells["descripcion_dis"].Value) + " / " +
                                  Convert.ToString(dataGridViewCiudades.CurrentRow.Cells["descripcion_po"].Value) + " / " +
                                  Convert.ToString(dataGridViewCiudades.CurrentRow.Cells["descripcion_de"].Value) ;

            }
        }







        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
            this.Listado_pc();
            this.Listado_sx();
           this.Listado_rb("%");
            this.Listado_dis_pv("%"); 

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
            //

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           if (txt_td.Text == String.Empty ||
                txt_nd.Text == String.Empty ||
                txt_rs.Text == String.Empty ||
                txt_direccion.Text == String.Empty)
            {
                MessageBox.Show("No se ha ingresado ningun dato (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Registrar informacion
            {
                E_Productos oPr = new E_Productos();
                string respuesta = "";
                oPr.codigo_p = this.codigo_p;
                oPr.descripcion_p = txt_td.Text.Trim();

                oPr.codigo_m = this.codigo_m;
                oPr.codigo_um = this.codigo_um;
                oPr.codigo_ca = this.codigo_ca;
                oPr.stock_min = Convert.ToDecimal(txt_a.Text);
                oPr.stock_max = Convert.ToDecimal(txt_n.Text);

                respuesta = N_Productos.Guardar_p(EstadoGuarda, oPr);
                if (respuesta == "OK")
                {
                    this.Listado_p("%");
                    MessageBox.Show("Datos guardados Corresctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;//no hace nada al cumplir la tarea
                    this.Estado_BotonesPrincipales(true);
                    Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
                    this.Estado_BotonesProcesos(false);
                    txt_td.Text = "";
                    txt_a.Text = "0";
                    txt_n.Text = "0";
                    txt_a.ReadOnly = true;
                    txt_n.ReadOnly = true;
                    txt_td.ReadOnly = true;
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
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_pv"].Value)))
            {

                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string ciudad = "";
                this.codigo_pv = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_pv"].Value);
                this.codigo_pc = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_pc"].Value);
                txt_td.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_pc"].Value);
                txt_nd.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["nrodocumentopv"].Value);
                txt_rs.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["razon_social_pv"].Value);
                txt_n.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["nombres"].Value);
                txt_a.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["apellidos"].Value);
                //
                this.codigo_rb = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_rb"].Value);
                txt_r.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_rb"].Value);

                txt_email.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["email_pv"].Value);
                txt_telefono.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["telefono_pv"].Value);
                txt_cel.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["movil_pv"].Value);
                //
                this.codigo_sx = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_sx"].Value);
                txt_s.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_"].Value);
                //
                txt_direccion.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["direccion_pv"].Value);
                this.codigo_dis = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_dis"].Value);

                ciudad = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_dis"].Value).Trim()+
                         Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_po"].Value).Trim()+
                         Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_de"].Value).Trim();
                //
                txt_ciudad.Text = ciudad;
                txt_comentario.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["observacion_pv"].Value).Trim();


            }
        }

 


        //boton agregar nuevo registro
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
           //Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
           // groupBox_Detalle.Visible = false;
            EstadoGuarda = 1; //nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            //definir
            this.Limpia_texto();
            this.Estado_texto(true);
            Tc_Marcas.SelectedIndex = 1;
            txt_nd.Focus();
            
        }

        //boton actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
/*
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            groupBox_Detalle.Visible = false;
            EstadoGuarda = 2; //actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            Tc_Marcas.SelectedIndex = 1;
            this.Seleciona_item();
            txt_td.ReadOnly = false;
            txt_td.Focus();
*/
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
        /*    EstadoGuarda = 0; //no hace nada 
            this.codigo_p = 0;
            txt_td.Text = "";
            txt_nd.Text = "";

            txt_a.Text = "0";
            txt_n.Text = "0";

            txt_a.ReadOnly = true;
            txt_n.ReadOnly = true;

            groupBox_Detalle.Visible = false;

            txt_td.ReadOnly = true;
            this.Estado_BotonesPrincipales(true);
            this.Estado_BotonesProcesos(false);
            Tc_Marcas.SelectedIndex = 0;
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
        */
        }

        //Doble clic en el DataGrid para visualizar un registro
        private void dataGridViewListado_DoubleClick(object sender, EventArgs e)
        {
          /*  Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            this.Seleciona_item();
            this.Estado_BotonesProcesos(false);
            this.Tc_Marcas.SelectedIndex = 1;
            this.Listado_stock_actual(this.codigo_p);
            groupBox_Detalle.Visible = true;
          */
        }

        //boton de regreso
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesProcesos(false);
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Tc_Marcas.SelectedIndex = 0;
            this.codigo_pv = 0;
         //   groupBox_Detalle.Visible = false;*/
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

               /* if (Opcion == DialogResult.Yes)
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
                }*/
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
            // Reportes.Frm_Reportes_Almacen oReporte3 = new Reportes.Frm_Reportes_Almacen();
            // oReporte3.txt_Reportes.Text = dataGridViewListado.Text;
            //  oReporte3.ShowDialog();

        }

        //Buscar 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
          //  this.Listado_p(txt_Buscar.Text.Trim());
        }

        //Refrescar los registros en el dataGrid
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
        //    this.Listado_p(dataGridViewListado.Text.Trim());
        }

        //boton para cerrar el sistema
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            this.panel_Listado_td.Visible = true;
          //  this.panel_Listado_marca.Location = btn_lupa.Location;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void dataGridView_td_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_item_pc();
            panel_Listado_td.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_lupa_medida_Click(object sender, EventArgs e)
        {
            this.panel_listado_sx.Visible = true;
          //  this.panel_listado_um.Location = btn_lupa_medida.Location;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
           // this.Listado_m(txt_m_l_marca.Text);
        }

        private void btn_buscar_um_Click(object sender, EventArgs e)
        {
           // this.Listado_um_p(txt_m_b_um.Text);
        }

        private void btn_marca_retornar_Click(object sender, EventArgs e)
        {
            panel_Listado_td.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;

        }

        private void btn_um_retornar_Click(object sender, EventArgs e)
        {
            panel_listado_sx.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void dataGridViewsx_DoubleClick(object sender, EventArgs e)
        {
           this.Seleciona_item_sx();
            panel_listado_sx.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.panel_listado_rb.Visible = true;
           // this.panel_listado_ca.Location = btn_lupa_medida.Location;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void dataGridViewRB_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_item_rb();
            panel_listado_rb.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }


        //retornar panel categorias
        private void btn_m_regredar_ca_Click(object sender, EventArgs e)
        {
            panel_listado_rb.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_b_m_ca_Click(object sender, EventArgs e)
        {
            this.Listado_rb(txt_m_rb.Text);
            //this.Listado_ca_p(txt_m_b_um.Text);
        }

     

        private void dataGridViewListado_Click(object sender, EventArgs e)
        {
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void btn_lupa_td_Click(object sender, EventArgs e)
        {
            
            this.panel_Listado_td.Location = btn_lupa_td.Location;
            panel_Listado_td.Visible = true;
        }

        private void btn_lupa_sx_Click(object sender, EventArgs e)
        {
            this.panel_listado_sx.Location = btn_lupa_sx.Location;
            panel_listado_sx.Visible = true;
        }

        private void btn_lupa_rb_Click(object sender, EventArgs e)
        {
          
            this.panel_listado_rb.Location = btn_lupa_rb.Location;
            panel_listado_rb.Visible = true;
        }

        private void btn_lupa_ciudades_Click(object sender, EventArgs e)
        {
            // Obtener la posición del botón
            int buttonX = btn_lupa_ciudades.Location.X;

            // Establecer la ubicación del panel a la izquierda del botón
            panel_Listado_ciudades.Location = new Point(buttonX - panel_Listado_ciudades.Width, panel_Listado_ciudades.Location.Y);

            panel_Listado_ciudades.Visible = true;
        }

        private void btn_regredar_c_Click(object sender, EventArgs e)
        {
            panel_Listado_ciudades.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void dataGridViewCiudades_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_item_dis();
            panel_Listado_ciudades.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_buscar_c_Click(object sender, EventArgs e)
        {
            this.Listado_dis_pv(txt_buscar_ci.Text);
        }
    }
}

