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

    abstract class Mantenimiento
    {
        static SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
        static SqlCommand comando;
       ///// ///CLIENTES/////////
        public abstract void GuardarCli();
        public abstract void EliminarCli();
        public abstract void EditarCli();
        public abstract void Asignaract(string cedula, string nombre, string correo, string direccion, string telefono, int id);
        public abstract void Asignar(string cedula, string nombre, string correo, string direccion, string telefono);

        //////////////// //PRESTAMOS/////////////
        public abstract void GuardarPres();
        public abstract void EditarPres();
        public abstract void EliminarPres();
        public abstract void AsignarP(string fecha, float monto, string cedula, int cuotas);
        public abstract void AsignaractP(string fecha, float monto, string cedula, int cuotas,int id);
    }  
}


