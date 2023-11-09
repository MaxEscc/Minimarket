
namespace Minimarket.Reportes
{
    partial class Frm_reportes_M
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
            this.txt_reportes = new System.Windows.Forms.TextBox();
            this.data = new Minimarket.Reportes.data();
            this.USP_Listado_maBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_maTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_maTableAdapter();
            this.uSPListadomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_maBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadomaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadomaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.Reportes_m.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // txt_reportes
            // 
            this.txt_reportes.Location = new System.Drawing.Point(62, 92);
            this.txt_reportes.Name = "txt_reportes";
            this.txt_reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_reportes.TabIndex = 1;
            this.txt_reportes.Visible = false;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_maBindingSource
            // 
            this.USP_Listado_maBindingSource.DataMember = "USP_Listado_ma";
            this.USP_Listado_maBindingSource.DataSource = this.data;
            // 
            // USP_Listado_maTableAdapter
            // 
            this.USP_Listado_maTableAdapter.ClearBeforeFill = true;
            // 
            // uSPListadomaBindingSource
            // 
            this.uSPListadomaBindingSource.DataMember = "USP_Listado_ma";
            this.uSPListadomaBindingSource.DataSource = this.data;
            // 
            // Frm_reportes_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_reportes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_reportes_M";
            this.Text = "Frm_reportes_M";
            this.Load += new System.EventHandler(this.Frm_reportes_M_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_maBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadomaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox txt_reportes;
        private System.Windows.Forms.BindingSource USP_Listado_maBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_maTableAdapter USP_Listado_maTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadomaBindingSource;
    }
}