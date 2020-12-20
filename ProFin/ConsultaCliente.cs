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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base_Datos.VerCli(DataG, txtNom.Text, txtCedu.Text, txtCor.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            REPORTE2 rep = new REPORTE2();
            this.Hide();
            rep.Show();
        }
    }
}
