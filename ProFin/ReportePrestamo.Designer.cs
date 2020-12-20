namespace ProFin
{
    partial class ReportePrestamo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedu = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DataSetPRESTAMOS = new ProFin.DataSetPRESTAMOS();
            this.PrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrestamosTableAdapter = new ProFin.DataSetPRESTAMOSTableAdapters.PrestamosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPRESTAMOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProFin.ReportPr.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 302);
            this.reportViewer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha";
            // 
            // txtCedu
            // 
            this.txtCedu.Location = new System.Drawing.Point(158, 397);
            this.txtCedu.Name = "txtCedu";
            this.txtCedu.Size = new System.Drawing.Size(100, 20);
            this.txtCedu.TabIndex = 25;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(158, 348);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataSetPRESTAMOS
            // 
            this.DataSetPRESTAMOS.DataSetName = "DataSetPRESTAMOS";
            this.DataSetPRESTAMOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrestamosBindingSource
            // 
            this.PrestamosBindingSource.DataMember = "Prestamos";
            this.PrestamosBindingSource.DataSource = this.DataSetPRESTAMOS;
            // 
            // PrestamosTableAdapter
            // 
            this.PrestamosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedu);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePrestamo";
            this.Text = "ReportePrestamo";
            this.Load += new System.EventHandler(this.ReportePrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPRESTAMOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedu;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource PrestamosBindingSource;
        private DataSetPRESTAMOS DataSetPRESTAMOS;
        private DataSetPRESTAMOSTableAdapters.PrestamosTableAdapter PrestamosTableAdapter;
    }
}