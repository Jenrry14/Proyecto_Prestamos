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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Base_Datos.VerPrest(datag,txtcli.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          // Base_Datos.Pago(txtfe.Text, txtcli.Text, int.Parse(txtP.Text), float.Parse(txtmon.Text));
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Form1 f = new Form1();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pagos2 p = new Pagos2();
            p.txtcli2.Text = txtcli1.Text;
            
            this.Hide();
            p.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }
    }
}
