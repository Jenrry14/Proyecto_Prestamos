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
    public partial class EDITARCLI : Form, IVolver
    {
        public EDITARCLI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mantenimiento Editar = new SaveCli();
            Editar.Asignaract(txtCed.Text, txtNom.Text, txtCor.Text, txtDire.Text, txtTel.Text, int.Parse(txtId.Text));
            Editar.EditarCli();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Volver();
        }

        private void EDITARCLI_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mantenimiento Borrar = new SaveCli();
            Borrar.Asignaract(txtCed.Text, txtNom.Text, txtCor.Text, txtDire.Text, txtTel.Text, int.Parse(txtId.Text));
            Borrar.EliminarCli();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Base_Datos.VerCliPres(Datag);
        }

      
        ///////////////INTERFACE/////////////////////
        public void Volver()
        {
            Inicios f = new Inicios();
            this.Hide();
            f.Show();
        }
    }
}
