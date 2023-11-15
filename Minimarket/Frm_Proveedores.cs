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
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
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
            dataGridViewListado.Columns[0].HeaderText = "CODIGO_PV";
            dataGridViewListado.Columns[1].Width = 50;
            dataGridViewListado.Columns[1].HeaderText = "Tipo documento";
            dataGridViewListado.Columns[2].Width = 50;
            dataGridViewListado.Columns[2].HeaderText = "nro documento";
            dataGridViewListado.Columns[3].Width = 50;
            dataGridViewListado.Columns[3].HeaderText = "Razon social";
            dataGridViewListado.Columns[4].Width = 50;
            dataGridViewListado.Columns[4].HeaderText = "nombres";
            dataGridViewListado.Columns[5].Width = 50;
            dataGridViewListado.Columns[5].HeaderText = "apellidos";
            dataGridViewListado.Columns[6].Width = 50;
            dataGridViewListado.Columns[6].HeaderText = "Rubro";
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
            dataGridViewListado.Columns[18].Visible = false;
            dataGridViewListado.Columns[19].Visible = false;

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

        private void Formato_pc()
        {
            dataGridViewTD.Columns[0].Width = 200;
            dataGridViewTD.Columns[0].HeaderText = "TIPO DOCUMENTO";
            dataGridViewTD.Columns[1].Visible = false;

        }
        private void Listado_pc()
        {
            try
            {
                dataGridViewTD.DataSource = N_Proveedores.Listado_pc();
                this.Formato_pc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_pc()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewTD.CurrentRow.Cells["codigo_pc"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_pc = Convert.ToInt32(dataGridViewTD.CurrentRow.Cells["codigo_pc"].Value);
                txt_TipoD.Text = Convert.ToString(dataGridViewTD.CurrentRow.Cells["descripcion_pc"].Value);
            }
        }

        private void Formato_sx()
        {
            dataGridViewSX.Columns[0].Width = 50;
            dataGridViewSX.Columns[0].HeaderText = "Género";
            dataGridViewSX.Columns[1].Visible = false;

        }
        private void Listado_sx()
        {
            try
            {
                dataGridViewSX.DataSource = N_Proveedores.Listado_sx();
                this.Formato_sx();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_sx()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewSX.CurrentRow.Cells["codigo_sx"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_sx = Convert.ToInt32(dataGridViewSX.CurrentRow.Cells["codigo_sx"].Value);
                txt_Sexo.Text = Convert.ToString(dataGridViewSX.CurrentRow.Cells["descripcion_sx"].Value);
            }
        }

        private void Formato_rb()
        {
            data_rubro.Columns[0].Width = 50;
            data_rubro.Columns[0].HeaderText = "Rubro";
            data_rubro.Columns[1].Visible = false;
      

        }
        private void Listado_rb(string cTexto)
        {
            try
            {
                data_rubro.DataSource = N_Proveedores.Listado_rb_pv(cTexto);
                this.Formato_rb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_rubro()
        {
            if (string.IsNullOrEmpty(Convert.ToString(data_rubro.CurrentRow.Cells["codigo_rb"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_rb = Convert.ToInt32(data_rubro.CurrentRow.Cells["codigo_rb"].Value);
                txt_rubro.Text = Convert.ToString(data_rubro.CurrentRow.Cells["descripcion_rb"].Value);
            }
        }

        private void Formato_c()
        {
            dataGridView_C.Columns[0].Width = 50;
            dataGridView_C.Columns[0].HeaderText = "direcion";
            dataGridView_C.Columns[1].Width = 50;
            dataGridView_C.Columns[1].HeaderText = "Ciudad";
            dataGridView_C.Columns[2].Width = 50;
            dataGridView_C.Columns[2].HeaderText = "estado";
            dataGridView_C.Columns[3].Visible = false;


        }
        private void Listado_c(string cTexto)
        {
            try
            {
                dataGridView_C.DataSource = N_Proveedores.Listado_dis_pv(cTexto);
                this.Formato_c();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Seleciona_c()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridView_C.CurrentRow.Cells["codigo_dis"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_dis = Convert.ToInt32(dataGridView_C.CurrentRow.Cells["codigo_dis"].Value);
                txt_ciudad.Text = Convert.ToString(dataGridView_C.CurrentRow.Cells["descripcion_dis"].Value) + '/' +
                                  Convert.ToString(dataGridView_C.CurrentRow.Cells["descripcion_po"].Value) + '/' +
                                   Convert.ToString(dataGridView_C.CurrentRow.Cells["descripcion_de"].Value);



            }
        }





        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
            this.Listado_pc();
            this.Listado_sx();
            this.Listado_rb("%");
            this.Listado_c("%");


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
          if (txt_TipoD.Text == String.Empty ||
                txt_RazonS.Text == String.Empty ||
                txt_Sexo.Text == String.Empty ||
                txt_ciudad.Text == String.Empty ||
                txt_NumeroD.Text == String.Empty ||
                txt_rubro.Text == String.Empty)
            {
                MessageBox.Show("No se ha ingresado ningun dato (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Registrar informacion
            {
                
                string respuesta = "";
                E_Proveedores ePv = new E_Proveedores();

                ePv.codigo_pv = this.codigo_pv;
                ePv.codigo_pc = this.codigo_pc;
                ePv.nrodocumentopv = txt_NumeroD.Text.Trim();
                ePv.razon_social_pv = txt_RazonS.Text.Trim();
             
                ePv.nombres = txt_Nombres.Text.Trim();
                ePv.apellidos = txt_Apellidos.Text.Trim();
                ePv.codigo_sx = this.codigo_sx;
                ePv.codigo_rb = this.codigo_rb;
                ePv.email_pv = txt_correo.Text.Trim();
                ePv.telefono_pv = txt_telefono.Text.Trim();
                ePv.movil_pv = txt_cel.Text.Trim();
                ePv.direccion_pv = txt_Direccion.Text.Trim();
                ePv.codigo_dis = this.codigo_dis;
                ePv.observacion_pv = txt_Comentario.Text.Trim();


                respuesta = N_Proveedores.Guardar_pv(EstadoGuarda, ePv);
                if (respuesta.Equals ("OK"))
                {
                    this.Listado_pv("%");
                    MessageBox.Show("Datos guardados Corresctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;//no hace nada al cumplir la tarea
                    this.Estado_BotonesPrincipales(true);
                    Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
                    this.Estado_BotonesProcesos(false);


                    EstadoTexto(false);
                    Tc_Marcas.SelectedIndex = 0;
                    this.codigo_pv= 0;
                    this.codigo_pc = 0;
                    this.codigo_sx = 0;
                    this.codigo_rb = 0;
                    this.codigo_dis = 0;


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
                txt_TipoD.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_pc"].Value);
                txt_NumeroD.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["nrodocumentopv"].Value);
                txt_RazonS.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["razon_social_pv"].Value);
                txt_Nombres.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["nombres"].Value);
                txt_Apellidos.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["apellidos"].Value);

                //
                this.codigo_rb = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_rb"].Value);
                txt_rubro.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_rb"].Value);
                txt_correo.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["email_pv"].Value);
                txt_telefono.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["telefono_pv"].Value);
                txt_cel.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["movil_pv"].Value);
                //
                this.codigo_sx = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_sx"].Value);
                txt_Sexo.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_sx"].Value);
                //
                txt_Direccion.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["direccion_pv"].Value);
                this.codigo_dis = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_dis"].Value);

                    ciudad =
                    Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_dis"].Value).Trim() + '/'+
                    Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_po"].Value).Trim() +  '/'+
                    Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_de"].Value).Trim();
                txt_ciudad.Text = ciudad;
                txt_Comentario.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["observacion_pv"].Value).Trim();
                //roupBox_Detalle.Visible = true;

            }
        }

        //
       


        private void  EstadoTexto(bool lestado)
        {
            txt_NumeroD.ReadOnly = !lestado;
            txt_RazonS.ReadOnly = !lestado;
            txt_Nombres.ReadOnly = !lestado;
            txt_Apellidos.ReadOnly = !lestado;
            txt_correo.ReadOnly = !lestado;
            txt_telefono.ReadOnly = !lestado;
            txt_cel.ReadOnly = !lestado;
            txt_Direccion.ReadOnly = !lestado;
            txt_Comentario.ReadOnly = !lestado;
        }


        private void LimpiaTexto()
        {
            txt_TipoD.Text = "";
            txt_Sexo.Text = "";
            txt_rubro.Text = "";
            txt_ciudad.Text = "";

            txt_NumeroD.Text = "";
            txt_RazonS.Text = "";
            txt_Nombres.Text = "";
            txt_Apellidos.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            txt_cel.Text = "";
            txt_Direccion.Text = "";
            txt_Comentario.Text = "";
        }






        //boton agregar nuevo registro
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 1; //nuevo registro

            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            this.LimpiaTexto();
            this.EstadoTexto(true);
       
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            Tc_Marcas.SelectedIndex = 1;


        }

        //boton actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            EstadoGuarda = 2; //ACTUALIZAR registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            this.EstadoTexto(true);
            Tc_Marcas.SelectedIndex = 1;
           txt_NumeroD.Focus();
            this.Seleciona_item();

        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.codigo_pv = 0;
            this.codigo_pc = 0;
            this.codigo_sx = 0;
            this.codigo_rb = 0;
            this.codigo_dis = 0;

            this.EstadoTexto(false);
            this.LimpiaTexto();
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
          //  Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Tc_Marcas.SelectedIndex = 0;
               this.LimpiaTexto();
       
        }

        //boton para eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_pv"].Value)))
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
                    this.codigo_pv = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_pv"].Value);
                    respuesta = N_Proveedores.Eliminar_pv(this.codigo_pv);

                    if (respuesta.Equals("OK"))
                    {
                        this.Listado_pv("%");
                        this.codigo_pv = 0;
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
             Reportes.Frm_Reportes_pv oReporte_PV = new Reportes.Frm_Reportes_pv();
             oReporte_PV.txt_reportes.Text = dataGridViewListado.Text;
              oReporte_PV.ShowDialog();

        }

        //Buscar 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_pv(txt_Buscar.Text.Trim());
        }

        //Refrescar los registros en el dataGrid
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Listado_pv(dataGridViewListado.Text.Trim());
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

        private void dataGridViewTD_DoubleClick(object sender, EventArgs e)
        {


            this.Seleciona_pc();
            panel_listado_td.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

    



        //retornar panel categorias
        private void btn_m_regredar_ca_Click(object sender, EventArgs e)
        {
            panel_listado_td.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }
   

        private void dataGridViewListado_Click(object sender, EventArgs e)
        {
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void btn_lupa_SX_Click(object sender, EventArgs e)
        {
            this.PANELSX.Location = btn_lupa_SX.Location;
            this.PANELSX.Visible = true;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void dataGridViewSX_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_sx();
            PANELSX.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_lupa_rubro_Click(object sender, EventArgs e)
        {
            this.panel_rubro.Location = btn_lupa_rubro.Location;
            this.panel_rubro.Visible = true;
            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void data_rubro_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_rubro();
            panel_rubro.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_regresar_sx_Click(object sender, EventArgs e)
        {
            PANELSX.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_regresar_rb_Click(object sender, EventArgs e)
        {
            panel_rubro.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_regresar_c_Click(object sender, EventArgs e)
        {
            panel_ciudad.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_lupa_c_Click(object sender, EventArgs e)
        {
            
                // Definir la posición del panel a la izquierda del botón
                int panelWidth = panel_ciudad.Width; // Ancho del panel
                int panelX = btn_lupa_c.Location.X - panelWidth - 5; // Ajuste de 5 píxeles para separación
                int panelY = btn_lupa_c.Location.Y;

                // Ubicar el panel al lado izquierdo del botón
                panel_ciudad.Location = new Point(panelX, panelY);

                // Hacer visible el panel
                panel_ciudad.Visible = true;
            

            btn_guardar.Enabled = false;
            btn_cancelar.Enabled = false;
        }

        private void dataGridView_C_DoubleClick(object sender, EventArgs e)
        {
            this.Seleciona_c();
            panel_ciudad.Visible = false;
            btn_guardar.Enabled = true;
            btn_cancelar.Enabled = true;
        }
    }
}

