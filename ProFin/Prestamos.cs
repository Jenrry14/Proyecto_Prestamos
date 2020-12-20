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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
            Base_Datos.VerCliPres(Data_Pres);
            //datos();
        }

        private void Data_Pres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnReaP_Click(object sender, EventArgs e)
        {
            //Base_Datos.Guardar_Pres(txtFecha.Text, float.Parse(txtMonto.Text),txtCedula.Text, int.Parse(txtCu.Text));
            Mantenimiento GuardaPres = new SavePres();
            GuardaPres.AsignarP(txtFecha.Text, float.Parse(txtMonto.Text), txtCedula.Text, int.Parse(txtCu.Text));
            GuardaPres.GuardarPres();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //public void datos()
        //{
        //    Conex.Open();
        //    comando = new SqlCommand($"SELECT CEDULA FROM CLIENTES", Conex);
        //    SqlDataAdapter da = new SqlDataAdapter(comando);
        //    DataTable tab = new DataTable();
        //    da.Fill(tab);
        //    Conex.Close();

        //    DataRow f = tab.NewRow();
        //    f["Cedula"] = "Seleccione su cedula";
        //    tab.Rows.InsertAt(f, 0);
        //    combced.DisplayMember = "Cedula";
        //    combced.DataSource = tab;
        //}
    }
}
