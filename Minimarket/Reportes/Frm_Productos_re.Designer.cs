
namespace Minimarket.Reportes
{
    partial class Frm_Productos_re
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
            this.USP_Listado_pBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_pTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_pTableAdapter();
            this.uSPListadopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_pBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1350, 493);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_Reportes
            // 
            this.txt_Reportes.Location = new System.Drawing.Point(52, 85);
            this.txt_Reportes.Name = "txt_Reportes";
            this.txt_Reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_Reportes.TabIndex = 2;
            this.txt_Reportes.Visible = false;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_pBindingSource
            // 
            this.USP_Listado_pBindingSource.DataMember = "USP_Listado_p";
            this.USP_Listado_pBindingSource.DataSource = this.data;
            // 
            // USP_Listado_pTableAdapter
            // 
            this.USP_Listado_pTableAdapter.ClearBeforeFill = true;
            // 
            // uSPListadopBindingSource
            // 
            this.uSPListadopBindingSource.DataMember = "USP_Listado_p";
            this.uSPListadopBindingSource.DataSource = this.data;
            // 
            // Frm_Productos_re
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 493);
            this.Controls.Add(this.txt_Reportes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Productos_re";
            this.Text = "Frm_Productos_re";
            this.Load += new System.EventHandler(this.Frm_Productos_re_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_pBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox txt_Reportes;
        private System.Windows.Forms.BindingSource USP_Listado_pBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_pTableAdapter USP_Listado_pTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadopBindingSource;
    }
}