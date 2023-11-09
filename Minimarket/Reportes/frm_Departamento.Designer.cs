
namespace Minimarket.Reportes
{
    partial class frm_Departamento
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
            this.USP_Listado_deBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_deTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_deTableAdapter();
            this.uSPListadodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Reportes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_deBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadodeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPListadodeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_Departamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_deBindingSource
            // 
            this.USP_Listado_deBindingSource.DataMember = "USP_Listado_de";
            this.USP_Listado_deBindingSource.DataSource = this.data;
            // 
            // USP_Listado_deTableAdapter
            // 
            this.USP_Listado_deTableAdapter.ClearBeforeFill = true;
            // 
            // uSPListadodeBindingSource
            // 
            this.uSPListadodeBindingSource.DataMember = "USP_Listado_de";
            this.uSPListadodeBindingSource.DataSource = this.data;
            // 
            // txt_Reportes
            // 
            this.txt_Reportes.Location = new System.Drawing.Point(37, 49);
            this.txt_Reportes.Name = "txt_Reportes";
            this.txt_Reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_Reportes.TabIndex = 2;
            this.txt_Reportes.Visible = false;
            // 
            // frm_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Reportes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Departamento";
            this.Text = "frm_Departamento";
            this.Load += new System.EventHandler(this.frm_Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_deBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_deBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_deTableAdapter USP_Listado_deTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadodeBindingSource;
        public System.Windows.Forms.TextBox txt_Reportes;
    }
}