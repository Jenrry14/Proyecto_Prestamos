namespace ProFin
{
    partial class ReporteBalance
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
            this.DataSetBALANCE1 = new ProFin.DataSetBALANCE1();
            this.Mov_PresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mov_PresTableAdapter = new ProFin.DataSetBALANCE1TableAdapters.Mov_PresTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBALANCE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mov_PresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Mov_PresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProFin.ReportBalan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 318);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cedula";
            // 
            // txtCedu
            // 
            this.txtCedu.Location = new System.Drawing.Point(182, 375);
            this.txtCedu.Name = "txtCedu";
            this.txtCedu.Size = new System.Drawing.Size(100, 20);
            this.txtCedu.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCedu);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteBalance";
            this.Text = "ReporteBalance";
            this.Load += new System.EventHandler(this.ReporteBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBALANCE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mov_PresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Mov_PresBindingSource;
        private DataSetBALANCE1 DataSetBALANCE1;
        private DataSetBALANCE1TableAdapters.Mov_PresTableAdapter Mov_PresTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedu;
        private System.Windows.Forms.Button button1;
    }
}