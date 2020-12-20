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
    public partial class Consultas_Form : Form 
    {
        
        public Consultas_Form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnVerCli_Click(object sender, EventArgs e)
        {
            // Base_Datos.VerCli(DataG,txtNom.Text,txtCedu.Text,txtCor.Text);
            REPORTE2 r = new REPORTE2();
            Hide();
            r.Show();

        }

        private void BtnVerPag_Click(object sender, EventArgs e)
        {
            // Base_Datos.VerPres(DataG, txtFecha.Text, txtCed2.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void btnVerPres_Click(object sender, EventArgs e)
        {
            // Base_Datos.VerPres(DataG, txtFecha.Text, txtCed2.Text);
            ReportePrestamo rep = new ReportePrestamo();
            Hide();
            rep.Show();
        }

        private void btnPendi_Click(object sender, EventArgs e)
        {
            ReporteBalance rep = new ReporteBalance();
            Hide();
            rep.Show();
        }
    }
}