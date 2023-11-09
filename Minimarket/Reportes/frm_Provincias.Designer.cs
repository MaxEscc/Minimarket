
namespace Minimarket.Reportes
{
    partial class frm_Provincias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_reportes = new System.Windows.Forms.TextBox();
            this.uSPListadopoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new Minimarket.Reportes.data();
            this.USP_Listado_poBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_poTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_poTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_poBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadopoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_Provincias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_reportes
            // 
            this.txt_reportes.Location = new System.Drawing.Point(320, 107);
            this.txt_reportes.Name = "txt_reportes";
            this.txt_reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_reportes.TabIndex = 1;
            this.txt_reportes.Visible = false;
            // 
            // uSPListadopoBindingSource
            // 
            this.uSPListadopoBindingSource.DataMember = "USP_Listado_po";
            this.uSPListadopoBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_poBindingSource
            // 
            this.USP_Listado_poBindingSource.DataMember = "USP_Listado_po";
            this.USP_Listado_poBindingSource.DataSource = this.data;
            // 
            // USP_Listado_poTableAdapter
            // 
            this.USP_Listado_poTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Provincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_reportes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Provincias";
            this.Text = "frm_Provincias";
            this.Load += new System.EventHandler(this.frm_Provincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_poBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_poBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_poTableAdapter USP_Listado_poTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadopoBindingSource;
        public System.Windows.Forms.TextBox txt_reportes;
    }
}