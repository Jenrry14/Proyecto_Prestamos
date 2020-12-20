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
    public partial class EdiPrestamos : Form
    {
        public EdiPrestamos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EDITARPRES a = new EDITARPRES();
            a.txtCed2.Text = txtced1.Text;
            this.Hide();
            a.Show(); 
        }

        private void EdiPrestamos_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();
        }
    }
}
