
namespace Minimarket
{
    partial class Frm_Distritos
    {
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Distritos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tc_Marcas = new System.Windows.Forms.TabControl();
            this.Tp_Listado = new System.Windows.Forms.TabPage();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dataGridViewListado = new System.Windows.Forms.DataGridView();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.Tp_Mantenimiento = new System.Windows.Forms.TabPage();
            this.panel_listado_po = new System.Windows.Forms.Panel();
            this.btn_m_regredar_ca = new System.Windows.Forms.Button();
            this.btn_b_m_ca = new System.Windows.Forms.Button();
            this.txt_m_b_DE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewM_P = new System.Windows.Forms.DataGridView();
            this.btn_lupa = new System.Windows.Forms.Button();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_Direecion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.Tc_Marcas.SuspendLayout();
            this.Tp_Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).BeginInit();
            this.Tp_Mantenimiento.SuspendLayout();
            this.panel_listado_po.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM_P)).BeginInit();
            this.SuspendLayout();
            // 
            // Tc_Marcas
            // 
            this.Tc_Marcas.Controls.Add(this.Tp_Listado);
            this.Tc_Marcas.Controls.Add(this.Tp_Mantenimiento);
            this.Tc_Marcas.Location = new System.Drawing.Point(22, 25);
            this.Tc_Marcas.Name = "Tc_Marcas";
            this.Tc_Marcas.SelectedIndex = 0;
            this.Tc_Marcas.Size = new System.Drawing.Size(922, 445);
            this.Tc_Marcas.TabIndex = 0;
            // 
            // Tp_Listado
            // 
            this.Tp_Listado.Controls.Add(this.btn_refrescar);
            this.Tp_Listado.Controls.Add(this.btn_buscar);
            this.Tp_Listado.Controls.Add(this.dataGridViewListado);
            this.Tp_Listado.Controls.Add(this.txt_Buscar);
            this.Tp_Listado.Location = new System.Drawing.Point(4, 22);
            this.Tp_Listado.Name = "Tp_Listado";
            this.Tp_Listado.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Listado.Size = new System.Drawing.Size(914, 419);
            this.Tp_Listado.TabIndex = 0;
            this.Tp_Listado.Text = "Listado";
            this.Tp_Listado.UseVisualStyleBackColor = true;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refrescar.BackgroundImage")));
            this.btn_refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refrescar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_refrescar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_refrescar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Location = new System.Drawing.Point(324, 24);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(29, 29);
            this.btn_refrescar.TabIndex = 9;
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_buscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(286, 24);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(30, 29);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dataGridViewListado
            // 
            this.dataGridViewListado.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListado.ColumnHeadersHeight = 30;
            this.dataGridViewListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewListado.GridColor = System.Drawing.Color.White;
            this.dataGridViewListado.Location = new System.Drawing.Point(48, 90);
            this.dataGridViewListado.Name = "dataGridViewListado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListado.Size = new System.Drawing.Size(838, 308);
            this.dataGridViewListado.TabIndex = 3;
            this.dataGridViewListado.DoubleClick += new System.EventHandler(this.dataGridViewListado_DoubleClick);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.Black;
            this.txt_Buscar.Location = new System.Drawing.Point(37, 24);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(231, 29);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // Tp_Mantenimiento
            // 
            this.Tp_Mantenimiento.Controls.Add(this.panel_listado_po);
            this.Tp_Mantenimiento.Controls.Add(this.btn_lupa);
            this.Tp_Mantenimiento.Controls.Add(this.txt_ciudad);
            this.Tp_Mantenimiento.Controls.Add(this.label5);
            this.Tp_Mantenimiento.Controls.Add(this.btn_regresar);
            this.Tp_Mantenimiento.Controls.Add(this.btn_guardar);
            this.Tp_Mantenimiento.Controls.Add(this.btn_cancelar);
            this.Tp_Mantenimiento.Controls.Add(this.txt_Direecion);
            this.Tp_Mantenimiento.Controls.Add(this.label1);
            this.Tp_Mantenimiento.Location = new System.Drawing.Point(4, 22);
            this.Tp_Mantenimiento.Name = "Tp_Mantenimiento";
            this.Tp_Mantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Mantenimiento.Size = new System.Drawing.Size(914, 419);
            this.Tp_Mantenimiento.TabIndex = 1;
            this.Tp_Mantenimiento.Text = "Mantenimiento";
            this.Tp_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel_listado_po
            // 
            this.panel_listado_po.Controls.Add(this.btn_m_regredar_ca);
            this.panel_listado_po.Controls.Add(this.btn_b_m_ca);
            this.panel_listado_po.Controls.Add(this.txt_m_b_DE);
            this.panel_listado_po.Controls.Add(this.label9);
            this.panel_listado_po.Controls.Add(this.dataGridViewM_P);
            this.panel_listado_po.Location = new System.Drawing.Point(508, 28);
            this.panel_listado_po.Name = "panel_listado_po";
            this.panel_listado_po.Size = new System.Drawing.Size(385, 334);
            this.panel_listado_po.TabIndex = 25;
            this.panel_listado_po.Visible = false;
            // 
            // btn_m_regredar_ca
            // 
            this.btn_m_regredar_ca.Location = new System.Drawing.Point(285, 61);
            this.btn_m_regredar_ca.Name = "btn_m_regredar_ca";
            this.btn_m_regredar_ca.Size = new System.Drawing.Size(70, 23);
            this.btn_m_regredar_ca.TabIndex = 23;
            this.btn_m_regredar_ca.Text = "Regresar";
            this.btn_m_regredar_ca.UseVisualStyleBackColor = true;
            this.btn_m_regredar_ca.Click += new System.EventHandler(this.btn_m_regredar_ca_Click);
            // 
            // btn_b_m_ca
            // 
            this.btn_b_m_ca.Location = new System.Drawing.Point(209, 61);
            this.btn_b_m_ca.Name = "btn_b_m_ca";
            this.btn_b_m_ca.Size = new System.Drawing.Size(70, 23);
            this.btn_b_m_ca.TabIndex = 19;
            this.btn_b_m_ca.Text = "Buscar";
            this.btn_b_m_ca.UseVisualStyleBackColor = true;
            this.btn_b_m_ca.Click += new System.EventHandler(this.btn_b_m_ca_Click);
            // 
            // txt_m_b_DE
            // 
            this.txt_m_b_DE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_m_b_DE.Location = new System.Drawing.Point(18, 55);
            this.txt_m_b_DE.Name = "txt_m_b_DE";
            this.txt_m_b_DE.Size = new System.Drawing.Size(175, 29);
            this.txt_m_b_DE.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Listado de Provincias";
            // 
            // dataGridViewM_P
            // 
            this.dataGridViewM_P.AllowDrop = true;
            this.dataGridViewM_P.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewM_P.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewM_P.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewM_P.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewM_P.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewM_P.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewM_P.ColumnHeadersHeight = 30;
            this.dataGridViewM_P.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewM_P.GridColor = System.Drawing.Color.White;
            this.dataGridViewM_P.Location = new System.Drawing.Point(18, 99);
            this.dataGridViewM_P.Name = "dataGridViewM_P";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewM_P.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewM_P.Size = new System.Drawing.Size(349, 214);
            this.dataGridViewM_P.TabIndex = 20;
            this.dataGridViewM_P.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewM_Provincias_CellDoubleClick);
            // 
            // btn_lupa
            // 
            this.btn_lupa.Location = new System.Drawing.Point(412, 31);
            this.btn_lupa.Name = "btn_lupa";
            this.btn_lupa.Size = new System.Drawing.Size(70, 23);
            this.btn_lupa.TabIndex = 18;
            this.btn_lupa.Text = "dEPARTAMENTO";
            this.btn_lupa.UseVisualStyleBackColor = true;
            this.btn_lupa.Click += new System.EventHandler(this.btn_lupa_Click);
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.Location = new System.Drawing.Point(177, 28);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(215, 29);
            this.txt_ciudad.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ciudad";
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(226)))), ((int)(((byte)(158)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.Black;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_regresar.Location = new System.Drawing.Point(210, 142);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(120, 38);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(192)))), ((int)(((byte)(250)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.Black;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(282, 142);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 38);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(158, 142);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(118, 38);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_Direecion
            // 
            this.txt_Direecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direecion.Location = new System.Drawing.Point(177, 81);
            this.txt_Direecion.MaxLength = 100;
            this.txt_Direecion.Name = "txt_Direecion";
            this.txt_Direecion.Size = new System.Drawing.Size(215, 29);
            this.txt_Direecion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ubicacion";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Editar.png");
            this.imageList1.Images.SetKeyName(1, "eliminar.png");
            this.imageList1.Images.SetKeyName(2, "nuevo.png");
            this.imageList1.Images.SetKeyName(3, "reportes.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "buscar1.png");
            this.imageList1.Images.SetKeyName(6, "buscar2.png");
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.AutoSize = true;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_nuevo.ImageKey = "nuevo.png";
            this.btn_nuevo.ImageList = this.imageList1;
            this.btn_nuevo.Location = new System.Drawing.Point(26, 517);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 85);
            this.btn_nuevo.TabIndex = 4;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSize = true;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actualizar.ImageKey = "Editar.png";
            this.btn_actualizar.ImageList = this.imageList1;
            this.btn_actualizar.Location = new System.Drawing.Point(107, 517);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 85);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "Editar";
            this.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eliminar.ImageKey = "eliminar.png";
            this.btn_eliminar.ImageList = this.imageList1;
            this.btn_eliminar.Location = new System.Drawing.Point(188, 517);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 85);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_report
            // 
            this.btn_report.AutoSize = true;
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_report.ImageKey = "reportes.png";
            this.btn_report.ImageList = this.imageList1;
            this.btn_report.Location = new System.Drawing.Point(269, 517);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 85);
            this.btn_report.TabIndex = 7;
            this.btn_report.Text = "Reportes";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.AutoSize = true;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_salir.ImageKey = "salir.png";
            this.btn_salir.ImageList = this.imageList1;
            this.btn_salir.Location = new System.Drawing.Point(865, 517);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 85);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Frm_Distritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 614);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.Tc_Marcas);
            this.Name = "Frm_Distritos";
            this.Text = "Distritos";
            this.Load += new System.EventHandler(this.Frm_Distritos_Load);
            this.Tc_Marcas.ResumeLayout(false);
            this.Tp_Listado.ResumeLayout(false);
            this.Tp_Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListado)).EndInit();
            this.Tp_Mantenimiento.ResumeLayout(false);
            this.Tp_Mantenimiento.PerformLayout();
            this.panel_listado_po.ResumeLayout(false);
            this.panel_listado_po.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM_P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tc_Marcas;
        private System.Windows.Forms.TabPage Tp_Listado;
        private System.Windows.Forms.TabPage Tp_Mantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewListado;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_Direecion;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.Button btn_lupa;
        public System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_listado_po;
        private System.Windows.Forms.Button btn_m_regredar_ca;
        private System.Windows.Forms.Button btn_b_m_ca;
        private System.Windows.Forms.TextBox txt_m_b_DE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewM_P;
    }
}