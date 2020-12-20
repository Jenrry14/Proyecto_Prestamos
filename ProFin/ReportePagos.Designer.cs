namespace ProFin
{
    partial class ReportePagos
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
            this.DataSetBALANCE1 = new ProFin.DataSetBALANCE1();
            this.Mov_PresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mov_PresTableAdapter = new ProFin.DataSetBALANCE1TableAdapters.Mov_PresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBALANCE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mov_PresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Mov_PresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Location = new System.Drawing.Point(200, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetBALANCE1
            // 
            this.DataSetBALANCE1.DataSetName = "DataSetBALANCE1";
            this.DataSetBALANCE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Mov_PresBindingSource
            // 
            this.Mov_PresBindingSource.DataMember = "Mov_Pres";
            this.Mov_PresBindingSource.DataSource = this.DataSetBALANCE1;
            // 
            // Mov_PresTableAdapter
            // 
            this.Mov_PresTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePagos";
            this.Text = "ReportePagos";
            this.Load += new System.EventHandler(this.ReportePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBALANCE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mov_PresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Mov_PresBindingSource;
        private DataSetBALANCE1 DataSetBALANCE1;
        private DataSetBALANCE1TableAdapters.Mov_PresTableAdapter Mov_PresTableAdapter;
    }
}