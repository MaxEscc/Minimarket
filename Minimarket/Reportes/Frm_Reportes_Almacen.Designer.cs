
namespace Minimarket.Reportes
{
    partial class Frm_Reportes_Almacen
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_Reportes = new System.Windows.Forms.TextBox();
            this.data = new Minimarket.Reportes.data();
            this.uSPListadoalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_Listado_alTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_alTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadoalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_Al.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_Reportes
            // 
            this.txt_Reportes.Location = new System.Drawing.Point(62, 67);
            this.txt_Reportes.Name = "txt_Reportes";
            this.txt_Reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_Reportes.TabIndex = 1;
            this.txt_Reportes.Visible = false;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPListadoalBindingSource
            // 
            this.uSPListadoalBindingSource.DataMember = "USP_Listado_al";
            this.uSPListadoalBindingSource.DataSource = this.data;
            // 
            // uSP_Listado_alTableAdapter
            // 
            this.uSP_Listado_alTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Reportes_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Reportes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reportes_Almacen";
            this.Text = "Frm_Reportes_Almacen";
            this.Load += new System.EventHandler(this.Frm_Reportes_Almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox txt_Reportes;
        private System.Windows.Forms.BindingSource uSPListadoalBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_alTableAdapter uSP_Listado_alTableAdapter;
    }
}