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
    //class Clientes : Base_Datos
    //{
    //    public override void Proceso()
    //    {
    //        string Cedula;
    //        string Nombre;
    //        string Correo;
    //        string Direccion;
    //        string Telefono;
    //        SqlConnection Conex = new SqlConnection("Data Source = DESKTOP - 5IHU68C\\SQLEXPRESS03; Initial Catalog = ProFin; Integrated Security = True");
    //        SqlCommand comando;
    //        try
    //        {

    //            Conex.Open();
    //            comando = new SqlCommand($"INSERT INTO Usuario values ('{Cedula}','{Nombre}',{Correo},'{Direccion}','{Telefono}')", Conex);
    //            comando.ExecuteNonQuery();
    //            Conex.Close();
    //            MessageBox.Show("Usuario agregado correctamente ");
    //        }
    //        catch
    //        {
    //            MessageBox.Show("Error al momento de guardar los datos, intentelo nuevamente");
    //        }
    //    }
    //}
}
