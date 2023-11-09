
namespace Minimarket.Reportes
{
    partial class Frm_Reportes_Um
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
            this.uSPListadoumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new Minimarket.Reportes.data();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_Listado_umBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_umTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_umTableAdapter();
            this.txt_Reportes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_umBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uSPListadoumBindingSource
            // 
            this.uSPListadoumBindingSource.DataMember = "USP_Listado_um";
            this.uSPListadoumBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadoumBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_UM.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_Listado_umBindingSource
            // 
            this.USP_Listado_umBindingSource.DataMember = "USP_Listado_um";
            this.USP_Listado_umBindingSource.DataSource = this.data;
            // 
            // USP_Listado_umTableAdapter
            // 
            this.USP_Listado_umTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Reportes
            // 
            this.txt_Reportes.Location = new System.Drawing.Point(58, 62);
            this.txt_Reportes.Name = "txt_Reportes";
            this.txt_Reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_Reportes.TabIndex = 1;
            this.txt_Reportes.Visible = false;
            // 
            // Frm_Reportes_Um
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Reportes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reportes_Um";
            this.Text = "Frm_Reportes_Um";
            this.Load += new System.EventHandler(this.Frm_Reportes_Um_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadoumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_umBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_umBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_umTableAdapter USP_Listado_umTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadoumBindingSource;
        public System.Windows.Forms.TextBox txt_Reportes;
    }
}