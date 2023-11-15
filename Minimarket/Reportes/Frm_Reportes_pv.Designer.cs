
namespace Minimarket.Reportes
{
    partial class Frm_Reportes_pv
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
            this.data = new Minimarket.Reportes.data();
            this.USP_Listado_pvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_pvTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_pvTableAdapter();
            this.uSPListadopvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_reportes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_pvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadopvBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_Proveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1041, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_pvBindingSource
            // 
            this.USP_Listado_pvBindingSource.DataMember = "USP_Listado_pv";
            this.USP_Listado_pvBindingSource.DataSource = this.data;
            // 
            // USP_Listado_pvTableAdapter
            // 
            this.USP_Listado_pvTableAdapter.ClearBeforeFill = true;
            // 
            // uSPListadopvBindingSource
            // 
            this.uSPListadopvBindingSource.DataMember = "USP_Listado_pv";
            this.uSPListadopvBindingSource.DataSource = this.data;
            // 
            // txt_reportes
            // 
            this.txt_reportes.Location = new System.Drawing.Point(54, 93);
            this.txt_reportes.Name = "txt_reportes";
            this.txt_reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_reportes.TabIndex = 2;
            this.txt_reportes.Visible = false;
            // 
            // Frm_Reportes_pv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.txt_reportes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reportes_pv";
            this.Text = "Frm_Reportes_pv";
            this.Load += new System.EventHandler(this.Frm_Reportes_pv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_pvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_pvBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_pvTableAdapter USP_Listado_pvTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadopvBindingSource;
        public System.Windows.Forms.TextBox txt_reportes;
    }
}