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
    public partial class REPORTE2 : Form
    {
        public REPORTE2()
        {
            InitializeComponent();
        }

        private void REPORTE2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCLI.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.DataSetCLI.Clientes);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ClientesTableAdapter.FillBy(this.DataSetCLI.Clientes,txtCedu.Text,txtNom.Text,txtCor.Text);

            this.reportViewer1.RefreshReport();
           
        }
    }
}
