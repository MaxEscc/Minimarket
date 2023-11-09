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
    public partial class Frm_Provincias : Form
    {
        public Frm_Provincias()
        {
            //Desabiliatar casilla de mantenimiento 
            InitializeComponent();
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            Estado_BotonesProcesos(false);
          
         
        }

        #region "Variables"
        int codigo_po = 0;
        int codigo_de = 0;
        int EstadoGuarda = 0; //
        #endregion

        #region"Metodos"
        private void Formato_po()
        {
            dataGridViewListado.Columns[0].Width = 100;
            dataGridViewListado.Columns[0].HeaderText = "CODIGO_PO";
            dataGridViewListado.Columns[1].Width = 200;
            dataGridViewListado.Columns[1].HeaderText = "PROVINCIAS";
            dataGridViewListado.Columns[2].Width = 250;
            dataGridViewListado.Columns[2].HeaderText = "DEPARTAMENTO";
            dataGridViewListado.Columns[3].Visible = false;
        }
        private void Listado_po(string cTexto)
        {
            try
            {
                dataGridViewListado.DataSource = N_Provincias.Listado_po(cTexto);
                this.Formato_po();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
            }
        }

        private void Formato_de_po()
        {
            dataGridViewM_DE.Columns[0].Width = 100;
            dataGridViewM_DE.Columns[0].HeaderText = "DEPARTAMENTO";
            dataGridViewM_DE.Columns[1].Visible = false; 
      
        }
        private void Listado_de_po(string cTexto)
        {
            try
            {
                dataGridViewM_DE.DataSource = N_Provincias.Listado_de_po(cTexto);
                this.Formato_de_po();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                throw;
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
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //depa
                this.codigo_de = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_de"].Value);
                txt_descripcion_de.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_de"].Value).Trim();

                this.codigo_po = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_po"].Value);
                txt_Provincia.Text = Convert.ToString(dataGridViewListado.CurrentRow.Cells["descripcion_po"].Value).Trim();
          
            }
        }



        #endregion

        private void Frm_Provincias_Load(object sender, EventArgs e)
        {
            this.Listado_po("%");
            this.Listado_de_po("%");
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
    if (txt_descripcion_de.Text == String.Empty || txt_Provincia.Text == String.Empty)
    {
        MessageBox.Show("No se ha ingresado ningún dato (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else // Registrar información
    {
        E_Provincias oPo = new E_Provincias();
        string respuesta = "";
        oPo.codigo_po = this.codigo_po;
        oPo.descripcion_po = txt_Provincia.Text.Trim();
        oPo.codigo_de = this.codigo_de;
        
        // Actualizar el valor de nOpcion dependiendo de si es un nuevo registro o una actualización
        int nOpcion = (this.codigo_po == 0) ? 1 : 2;
        
        respuesta = N_Provincias.Guardar_po(nOpcion, oPo);
        if (respuesta == "OK")
        {
            this.Listado_po("%");
            MessageBox.Show("Datos guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoGuarda = 0; // No hace nada al cumplir la tarea
            this.Estado_BotonesPrincipales(true);
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = false;
            this.Estado_BotonesProcesos(false);
            txt_Provincia.Text = "";
            txt_Provincia.ReadOnly = true;
            Tc_Marcas.SelectedIndex = 0;
            this.codigo_po = 0;
        }
        else
        {
            MessageBox.Show(respuesta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


       
        //boton agregar nuevo registro
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Tc_Marcas.TabPages["Tp_Mantenimiento"].Enabled = true;
          
            EstadoGuarda = 1; //nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_BotonesProcesos(true);
  
            txt_Provincia.Text = "";
            txt_Provincia.ReadOnly = false;
            Tc_Marcas.SelectedIndex = 1;
            txt_Provincia.Focus();
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
            txt_Provincia.ReadOnly = false;
            txt_Provincia.Focus();
        }

        //boton cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            EstadoGuarda = 0; //no hace nada 
            this.codigo_de = 0;
            txt_Provincia.Text = "";
            txt_Provincia.ReadOnly = true;
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
       
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewListado.CurrentRow.Cells["codigo_po"].Value)))
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
                    this.codigo_po = Convert.ToInt32(dataGridViewListado.CurrentRow.Cells["codigo_po"].Value);
                    respuesta = N_Provincias.Eliminar_po(this.codigo_de);

                    if (respuesta.Equals("OK"))
                    {
                        this.Listado_po("%");
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
            Reportes.frm_Provincias oReportePo = new Reportes.frm_Provincias();
            oReportePo.txt_reportes.Text = dataGridViewListado.Text;
            oReportePo.ShowDialog();

        }

        //Buscar 
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_po(txt_Buscar.Text.Trim());
        }

        //Refrescar los registros en el dataGrid
        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.Listado_po(dataGridViewListado.Text.Trim());
        }

        //boton para cerrar el sistema
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            panel_listado_de.Visible = true;
        }

        private void btn_m_regredar_ca_Click(object sender, EventArgs e)
        {
            panel_listado_de.Visible = false;
        }

        private void dataGridViewM_DE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Seleciona_item_de_po();
            panel_listado_de.Visible = true;
        }

        private void Seleciona_item_de_po()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewM_DE.CurrentRow.Cells["codigo_de"].Value)))
            {
                MessageBox.Show("No existe informacion para visualizar", "Aviso del sistema,", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.codigo_de = Convert.ToInt32(dataGridViewM_DE.CurrentRow.Cells["codigo_de"].Value);
                txt_descripcion_de.Text = Convert.ToString(dataGridViewM_DE.CurrentRow.Cells["descripcion_de"].Value);
            }
        }

        private void btn_b_m_ca_Click(object sender, EventArgs e)
        {
            this.Listado_de_po(txt_m_b_DE.Text);
        }

     
    }
}

