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
    public partial class Pagos2 : Form
    {
        public Pagos2()
        {
            InitializeComponent();
            
        }

        private void Pagos2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PROCESOS PagarPr = new Pagoos();
            PagarPr.Pagar(txtfe.Text, txtcli2.Text, int.Parse(txtP.Text), float.Parse(txtmon.Text));
            //Base_Datos.Pago(txtfe.Text, txtcli2.Text, int.Parse(txtP.Text), float.Parse(txtmon.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PROCESOS VERPRES = new Pagoos();
            VERPRES.VerPrestamos(datag, txtcli2.Text);
       
            //Base_Datos.VerPrest(datag, txtcli2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
}
