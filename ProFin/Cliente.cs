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
    public partial class Cliente : Form,IVolver
    {
        static SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
        static SqlCommand comando;
        public Cliente()
        {
            InitializeComponent();
        }

        public void Volver()
        {
            Inicios c = new Inicios();
            this.Close();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Base_Datos.Guardar(txtCed.Text, txtNom.Text, txtCor.Text, txtDire.Text, txtTel.Text);
            Mantenimiento Guararcl = new SaveCli();
            Guararcl.Asignar(txtCed.Text, txtNom.Text, txtCor.Text, txtDire.Text, txtTelefono.Text);
            Guararcl.GuardarCli();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Base_Datos.BorrarCli(txtCed.Text);
        }
    }
}
