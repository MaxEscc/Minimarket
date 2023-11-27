
namespace Minimarket.Reportes
{
    partial class Frm_Reportes_Clientes
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
            this.USP_Listado_clBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_clTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_clTableAdapter();
            this.uSPListadoclBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_clBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoclBindingSource)).BeginInit();
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
            reportDataSource1.Value = this.uSPListadoclBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_Clientes.rdlc";
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
            // USP_Listado_clBindingSource
            // 
            this.USP_Listado_clBindingSource.DataMember = "USP_Listado_cl";
            this.USP_Listado_clBindingSource.DataSource = this.data;
            // 
            // USP_Listado_clTableAdapter
            // 
            this.USP_Listado_clTableAdapter.ClearBeforeFill = true;
            // 
            // uSPListadoclBindingSource
            // 
            this.uSPListadoclBindingSource.DataMember = "USP_Listado_cl";
            this.uSPListadoclBindingSource.DataSource = this.data;
            // 
            // Frm_Reportes_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txt_Reportes);
            this.Name = "Frm_Reportes_Clientes";
            this.Text = "Frm_Reportes_Clientes";
            this.Load += new System.EventHandler(this.Frm_Reportes_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_clBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoclBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_Reportes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_clBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_clTableAdapter USP_Listado_clTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadoclBindingSource;
    }
}