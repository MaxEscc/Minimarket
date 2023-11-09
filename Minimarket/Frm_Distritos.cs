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
    public partial class Frm_Distritos : Form
    {
        public Frm_Distritos()
        {
            //Desabiliatar casilla de mantenimiento 
            InitializeComponent();
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Estado_BotonesProcesos(false);
          
         
        }

        #region "Variables"
        int codigo_dis = 0;
        int codigo_po = 0;
        int EstadoGuarda = 0; //
        #endregion

        #region"Metodos"
        private void Formato_dis()
        {
            dataGridViewListado.Columns[0].Width = 20;
            dataGridViewListado.Columns[0].HeaderText = "CODIGO_Dis";
            dataGridViewListado.Columns[1].Width = 50;
            dataGridViewListado.Columns[1].HeaderText = "DISTRITO";
            dataGridViewListado.Columns[2].Width = 30;
            dataGridViewListado.Columns[2].HeaderText = "PROVINCIA";
            dataGridViewListado.Columns[3].Width = 50;
            dataGridViewListado.Columns[3].HeaderText = "DEPARTAMENTO";
            dataGridViewListado.Columns[4].Visible = false;

        }
        private void Listado_dis(string cTexto)
        {
            try
            {
                dataGridViewListado.DataSource = N_Distritos.Listado_dis(cTexto);
                this.Formato_dis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Formato_pp()
        {
            dataGridViewM_P.Columns[0].Width = 100;
            dataGridViewM_P.Columns[0].HeaderText = "Provincia";
            dataGridViewM_P.Columns[1].Width = 100;
            dataGridViewM_P.Columns[1].HeaderText = "DEPARTAMENTO";
            dataGridViewM_P.Columns[2].Visible = false; 
      
        }
        private void Listado_pp(string cTexto)
        {
            try
            {
                dataGridViewM_P.DataSource = N_Distritos.Listado_pp(cTexto);
                this.Formato_pp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }


        #endregion

        private void Frm_Distritos_Load(object sender, EventArgs e)
        {
            this.Listado_dis("%");
            this.Listado_pp("%");
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
            if (txt_ciudad.Text == String.Empty ||
                 txt_Direecion.Text == String.Empty)
            {
                MessageBox.Show("No se ha ingresado ningun dato (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Registrar informacion
            {
                E_Distritos oDi = new E_Distritos();
                string respuesta = "";
                oDi.codigo_dis = this.codigo_dis;
                oDi.descripcion_dis = txt_Direecion.Text.Trim();
                //
                oDi.codigo_po = this.codigo_po;
                respuesta = N_Distritos.Guardar_dis(EstadoGuarda, oDi);
                if (respuesta == "OK")
                {
                    this.Listado_dis("%");
                    MessageBox.Show("Datos guardados Corresctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;//no hace nada al cumplir la tarea
                    this.Estado_BotonesPrincipales(true);
                    Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
                    this.Estado_BotonesProcesos(false);
                    txt_Direecion.Text = "";
                    txt_Direecion.ReadOnly = true;
                    Tc_Marcas.SelectedIndex = 0;
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
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_dis"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_po = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_po"].Value);
                txt_ciudad.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_po"].Value);

                this.codigo_dis = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_dis"].Value);
                txt_Direecion.Text =Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_dis"].Value);
                //depa
               
            }
        }

        //boton agregar nuevo registro
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
          
            EstadoGuarda = 1; //nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
  
            txt_Direecion.Text = "";
            txt_Direecion.ReadOnly = false;
            Tc_Marcas.SelectedIndex = 1;
            txt_Direecion.Focus();
        }

        //boton actualizar
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
            EstadoGuarda = 2; //actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
            Tc_Marcas.SelectedIndex = 1;
            this.Seleciona_item();
            txt_Direecion.ReadOnly = false;
            txt_Direecion.Focus();
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0; //no hace nada 
            this.codigo_dis= 0;
            txt_Direecion.Text = "";
            txt_Direecion.ReadOnly = true;
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
        }

        //boton de regreso
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Estado_BotonesProcesos(false);
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Tc_Marcas.SelectedIndex = 0;
            this.codigo_dis = 0;
        }

        //boton para eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_dis"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Estas seguro que deseas eliminar este registro","Aviso del sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (Opcion == DialogResult.Yes)
                {
                    string  respuesta="";
                    this.codigo_dis = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_dis"].Value);
                    respuesta = N_Distritos.Eliminar_dis(this.codigo_dis);

                    if (respuesta.Equals("OK"))
                    {
                        this.Listado_pp("%");
                        this.codigo_dis = 0;
                        MessageBox.Show("Registro eliminado","Aviso del sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
            Reportes.frm_Provincias oReportePo = new Reportes.frm_Provincias();
            oReportePo.txt_reportes.Text = dataGridViewListado.Text;
            oReportePo.ShowDialog();

        }

        //Buscar 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_pp(txt_Buscar.Text.Trim());
        }

        //Refrescar los registros en el dataGrid
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Listado_pp(dataGridViewListado.Text.Trim());
        }

        //boton para cerrar el sistema
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            panel_listado_po.Visible = true;
        }

        private void btn_m_regredar_ca_Click(object sender, EventArgs e)
        {
            panel_listado_po.Visible = false;
        }

        private void dataGridViewM_Provincias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Seleciona_item_pp();
            panel_listado_po.Visible = true;
        }

        private void Seleciona_item_pp()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewM_P.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_po = Convert.ToInt32(dataGridViewM_P.CurrentRow.Cells["codigo_po"].Value);
                txt_ciudad.Text = Convert.ToString(dataGridViewM_P.CurrentRow.Cells["descripcion_po"].Value);
            }
        }

        private void btn_b_m_ca_Click(object sender, EventArgs e)
        {
            this.Listado_pp(txt_m_b_DE.Text);
        }

     
    }
}

