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
    public partial class EDITARPRES : Form
    {
        public EDITARPRES()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PROCESOS verp = new Pagoos();
            verp.VerPrestamos(Data_Pres, txtCed2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Mantenimiento eliminarP = new SavePres();
            //eliminarP.AsignaractP(txtFecha.Text, float.Parse(txtMonto.Text), txtCed2.Text, int.Parse(txtCu.Text),int.Parse(txtid.Text));
            //eliminarP.EliminarPres();
            Base_Datos.BorrarPre(int.Parse(txtid.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicios ini = new Inicios();
            this.Hide();
            ini.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mantenimiento editarP = new SavePres();
            editarP.AsignarP(txtFecha.Text, float.Parse(txtMonto.Text),txtCed2.Text, int.Parse(txtCu.Text));
            editarP.EditarPres();
        }

        private void EDITARPRES_Load(object sender, EventArgs e)
        {

        }
    }
}
