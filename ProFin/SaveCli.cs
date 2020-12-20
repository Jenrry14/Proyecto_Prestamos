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
    class SaveCli:Mantenimiento
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public  string correo { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int id { get; set; }

        public override void GuardarCli()
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            //SqlCommand comando;
            try
            {
                string cli = "INSERT INTO CLIENTES(Cedula,Nombre,Correo,Direccion,Telefono) VALUES (@ced,@nom,@cor,@dire,@tele)";

                Conex.Open();
                SqlCommand c = new SqlCommand(cli, Conex);
                /////////
                c.Parameters.AddWithValue("@ced", cedula);
                c.Parameters.AddWithValue("@nom", nombre);
                c.Parameters.AddWithValue("@cor", correo);
                c.Parameters.AddWithValue("@dire", direccion);
                c.Parameters.AddWithValue("@tele", telefono);
                c.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Cliente agregado con exito ");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Verifique nuevamente sus datos");
            }
        }
        public override void Asignar(string Cedula, string Nombre, string Correo, string Direccion, string Telefono)
        {
            this.cedula = Cedula;
            this.nombre = Nombre;
            this.correo = Correo;
            this.direccion = Direccion;
            this.telefono = Telefono;
            
        }
       
        public override void EditarCli()
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            SqlCommand comando;
            try
            {
                Conex.Open();
                comando = new SqlCommand($"UPDATE CLIENTES SET Cedula='{cedula}' ,Nombre='{nombre}', Correo=' {correo}', Direccion='{direccion}', Telefono='{telefono}' WHERE IdCliente = {id}", Conex);
                comando.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Usuario Actualizado");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Verifique nuevamente el dato introducido");
            }
        }

        public override void EliminarCli()
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            SqlCommand comando;
            try
            {
                Conex.Open();
                comando = new SqlCommand($"delete from Clientes where IdCliente={id}", Conex);
                comando.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Cliente eliminado con exito ");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Verifique nuevamente sus datos");
            }
        }
        public override void Asignaract(string cedula, string nombre, string correo, string direccion, string telefono, int id)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.id = id;
        }
        ////////////////// //DIVISION///////
        /// <summary>
        /// 
        /// </summary>
        public override void GuardarPres()
        {
            throw new NotImplementedException();
        }

        public override void EditarPres()
        {
            throw new NotImplementedException();
        }

        public override void EliminarPres()
        {
            throw new NotImplementedException();
        }

        public override void AsignarP(string fecha, float monto, string cedula, int cuotas)
        {
            throw new NotImplementedException();
        }
        public override void AsignaractP(string fecha, float monto, string cedula, int cuotas,int id)
        {
            throw new NotImplementedException();
        }

    }
}
