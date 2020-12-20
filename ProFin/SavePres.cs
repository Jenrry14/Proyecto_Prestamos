using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProFin
{
    class SavePres: Mantenimiento
    {
        public string fecha { get; set; }
        public float monto { get; set; }
        public string cedula { get; set; }
        public int cuotas { get; set; }
        public int id { get; set; }

        public override void GuardarPres()
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            //SqlCommand comando;
            try
            {
                Conex.Open();
                string pres = "INSERT INTO Prestamos (Fecha, Monto,Ced_Cliente,cuotas) VALUES (@fecha, @monto,@cedcl, @cuota)" +
                                "update Prestamos set cuotas = Monto / cuotas where Ced_Cliente = @cedcl";

                SqlCommand p = new SqlCommand(pres, Conex);
                p.Parameters.AddWithValue("@fecha", fecha);
                p.Parameters.AddWithValue("@monto", monto);
                p.Parameters.AddWithValue("@cedcl", cedula);
                p.Parameters.AddWithValue("@cuota", cuotas);
                p.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Ha realizado su prestamo correctamente ");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Error al momento de efecturar el prestamo");
            }
        }
        public override void EliminarPres()
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            SqlCommand comando;
            try
            {
                Conex.Open();
                comando = new SqlCommand($"delete from Prestamos where IdPres={id}", Conex);
                comando.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Prestamo eliminado con exito ");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Verifique nuevamente sus datos");
            }
        }
        public override void EditarPres()
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            SqlCommand comando;
            try
            {
                Conex.Open();
                comando = new SqlCommand($"UPDATE PRESTAMOS SET Fecha='{fecha}' ,Monto={monto}, cuotas={cuotas} WHERE Ced_Cliente=' {cedula}'", Conex);
                comando.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Prestamo actualizado");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Verifique nuevamente los datos introducidos");
            }
        }
      
        public override void AsignarP(string fecha, float monto, string cedula, int cuotas)
        {
            this.fecha = fecha;
            this.monto = monto;
            this.cedula = cedula;
            this.cuotas = cuotas;
        }
        public override void AsignaractP(string fecha, float monto, string cedula, int cuotas, int id)
        {
            this.fecha = fecha;
            this.monto = monto;
            this.cedula = cedula;
            this.cuotas = cuotas;
            this.id = id;
        }
        public override void EditarCli()
        {
            throw new NotImplementedException();
        }
        public override void EliminarCli()
        {
            throw new NotImplementedException();
        }
        public override void GuardarCli()
        {
            throw new NotImplementedException();
        }
       

        public override void Asignar(string cedula, string nombre, string correo, string direccion, string telefono)
        {
            throw new NotImplementedException();
        }
        public override void Asignaract(string cedula, string nombre, string correo, string direccion, string telefono, int id)
        {
            throw new NotImplementedException();
        }

        
    }
}

