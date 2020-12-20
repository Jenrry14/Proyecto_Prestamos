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
    public partial class Inicios : Form
    {
        public Inicios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            this.Close();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {        
            Prestamos p = new Prestamos();
            this.Hide();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            EDITARCLI Ed = new EDITARCLI();
            this.Hide();
            Ed.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EdiPrestamos ed = new EdiPrestamos();
            this.Hide();
            ed.Show();
        }
    }
}
