using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProFin
{
    public partial class Form1 : Form
    {
         static SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=Proyecto;Integrated Security=True");
         static SqlCommand comando;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            Inicios a = new Inicios();
            this.Hide();
            a.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas_Form con = new Consultas_Form();
            con.Show();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagos p = new Pagos();
            p.Show();
        }

       
    }
}
