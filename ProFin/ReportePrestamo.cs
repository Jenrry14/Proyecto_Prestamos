using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFin
{
    public partial class ReportePrestamo : Form
    {
        public ReportePrestamo()
        {
            InitializeComponent();
        }

        private void ReportePrestamo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetPRESTAMOS.Prestamos' table. You can move, or remove it, as needed.
            this.PrestamosTableAdapter.Fill(this.DataSetPRESTAMOS.Prestamos);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PrestamosTableAdapter.FillBy(this.DataSetPRESTAMOS.Prestamos,txtFecha.Text,txtCedu.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
