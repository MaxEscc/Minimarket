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
    public partial class Frm_Departamento : Form
    {
        public Frm_Departamento()
        {
            //Desabiliatar casilla de mantenimiento 
            InitializeComponent();
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Estado_BotonesProcesos(false);
          
         
        }

        #region "Variables"
        int codigo_de = 0;
        int EstadoGuarda = 0; //
        #endregion

        #region"Metodos"
        private void Formato_de()
        {
            dataGridViewListado.Columns[0].Width = 100;
            dataGridViewListado.Columns[0].HeaderText = "CODIGO_DE";
            dataGridViewListado.Columns[1].Width = 300;
            dataGridViewListado.Columns[1].HeaderText = "DEPARTAMENTO";
        }
        private void Listado_de(string cTexto)
        {
            try
            {
                dataGridViewListado.DataSource = N_Departamento.Listado_de(cTexto);
                this.Formato_de();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }
        #endregion

        private void Frm_Departamento_Load(object sender, EventArgs e)
        {
            this.Listado_de("%");
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
            if (txt_Departamento.Text == String.Empty)
            {
                MessageBox.Show("No se ha ingresado ningun dato (*)", "Aviso del sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else // Registrar informacion
            {
                E_Departamento oDe = new E_Departamento();
                string respuesta = "";
                oDe.codigo_de = this.codigo_de;
                oDe.descripcion_de = txt_Departamento.Text.Trim();
                respuesta = N_Departamento.Guardar_de(EstadoGuarda, oDe);
                if (respuesta == "OK")
                {
                    this.Listado_de("%");
                    MessageBox.Show("Datos guardados Corresctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EstadoGuarda = 0;//no hace nada al cumplir la tarea
                    this.Estado_BotonesPrincipales(true);
                    Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
                    this.Estado_BotonesProcesos(false);
                    txt_Departamento.Text = "";
                    txt_Departamento.ReadOnly = true;
                    Tc_Marcas.SelectedIndex = 0;
                    this.codigo_de = 0;

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
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_de"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_de =Convert.ToInt32( dataGridViewListado.CurrentRow.Cells["codigo_de"].Value);
                txt_Departamento.Text =Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_de"].Value);
            }
        }

        //boton agregar nuevo registro
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
          
            EstadoGuarda = 1; //nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
  
            txt_Departamento.Text = "";
            txt_Departamento.ReadOnly = false;
            Tc_Marcas.SelectedIndex = 1;
            txt_Departamento.Focus();
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
            txt_Departamento.ReadOnly = false;
            txt_Departamento.Focus();
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0; //no hace nada 
            this.codigo_de = 0;
            txt_Departamento.Text = "";
            txt_Departamento.ReadOnly = true;
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
            this.codigo_de = 0;
        }

        //boton para eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_de"].Value)))
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
                    this.codigo_de = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_de"].Value);
                    respuesta = N_Departamento.Eliminar_de(this.codigo_de);

                    if (respuesta.Equals("OK"))
                    {
                        this.Listado_de("%");
                        this.codigo_de = 0;
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
            Reportes.frm_Departamento oReporteDe = new Reportes.frm_Departamento();
            oReporteDe.txt_Reportes.Text = dataGridViewListado.Text;
            oReporteDe.ShowDialog();

        }

        //Buscar 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_de(txt_Buscar.Text.Trim());
        }

        //Refrescar los registros en el dataGrid
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Listado_de(dataGridViewListado.Text.Trim());
        }

        //boton para cerrar el sistema
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
    }
}

