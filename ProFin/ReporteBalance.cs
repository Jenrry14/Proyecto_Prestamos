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
    public partial class ReporteBalance : Form
    {
        public ReporteBalance()
        {
            InitializeComponent();
        }

        private void ReporteBalance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetBALANCE1.Mov_Pres' table. You can move, or remove it, as needed.
            this.Mov_PresTableAdapter.Fill(this.DataSetBALANCE1.Mov_Pres);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Mov_PresTableAdapter.FillBy(this.DataSetBALANCE1.Mov_Pres,txtCedu.Text);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
