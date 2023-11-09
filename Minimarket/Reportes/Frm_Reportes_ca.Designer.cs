
namespace Minimarket.Reportes
{
    partial class Frm_Reportes_ca
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
            this.txt_reportes = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.data = new Minimarket.Reportes.data();
            this.USP_Listado_caBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Listado_caTableAdapter = new Minimarket.Reportes.dataTableAdapters.USP_Listado_caTableAdapter();
            this.uSPListadocaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_caBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_reportes
            // 
            this.txt_reportes.Location = new System.Drawing.Point(58, 69);
            this.txt_reportes.Name = "txt_reportes";
            this.txt_reportes.Size = new System.Drawing.Size(100, 20);
            this.txt_reportes.TabIndex = 1;
            this.txt_reportes.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPListadocaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Minimarket.Reportes.reportes_cs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 2;
            // 
            // data
            // 
            this.data.DataSetName = "data";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Listado_caBindingSource
            // 
            this.USP_Listado_caBindingSource.DataMember = "USP_Listado_ca";
            this.USP_Listado_caBindingSource.DataSource = this.data;
            // 
            // USP_Listado_caTableAdapter
            // 
            this.USP_Listado_caTableAdapter.ClearBeforeFill = true;
            // 
            // uSPListadocaBindingSource
            // 
            this.uSPListadocaBindingSource.DataMember = "USP_Listado_ca";
            this.uSPListadocaBindingSource.DataSource = this.data;
            // 
            // Frm_Reportes_ca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txt_reportes);
            this.Name = "Frm_Reportes_ca";
            this.Text = "Frm_Reportes_ca";
            this.Load += new System.EventHandler(this.Frm_Reportes_ca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Listado_caBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPListadocaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_reportes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Listado_caBindingSource;
        private data data;
        private dataTableAdapters.USP_Listado_caTableAdapter USP_Listado_caTableAdapter;
        private System.Windows.Forms.BindingSource uSPListadocaBindingSource;
    }
}