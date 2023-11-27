
namespace Minimarket.Reportes
{
    partial class Frm_E_Productos
    {
        /// <summary>
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.txt_Reportes = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.data = new Minimarket.Reportes.data();
            this.USP_Listado_epBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_epTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_epTableAdapter();
            this.uSPListadoepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_epBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Reportes
            // 
            this.txt_Reportes.Location = new System.Drawing.Point(350, 215);
            this.txt_Reportes.Name = "txt_Reportes";
            this.txt_Reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_Reportes.TabIndex = 3;
            this.txt_Reportes.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadoepBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Report1_Entrada_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 4;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_epBindingSource
            // 
            this.USP_Listado_epBindingSource.DataMember = "USP_Listado_ep";
            this.USP_Listado_epBindingSource.DataSource = this.data;
            // 
            // USP_Listado_epTableAdapter
            // 
            this.USP_Listado_epTableAdapter.ClearBeforeFill = true;
            // 
            // uSPListadoepBindingSource
            // 
            this.uSPListadoepBindingSource.DataMember = "USP_Listado_ep";
            this.uSPListadoepBindingSource.DataSource = this.data;
            // 
            // Frm_E_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txt_Reportes);
            this.Name = "Frm_E_Productos";
            this.Text = "Frm_E_Productos";
            this.Load += new System.EventHandler(this.Frm_E_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_epBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoepBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_Reportes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_epBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_epTableAdapter USP_Listado_epTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadoepBindingSource;
    }
}