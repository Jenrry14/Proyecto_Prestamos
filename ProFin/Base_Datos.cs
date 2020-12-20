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
     class  Base_Datos:Form
    {
        static SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
        static SqlCommand comando;

        public static void Guardar(string cedula, string nombre, string correo, string direccion, string telefono)
        {
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
        public static void VerCli(DataGridView tabla, string nombre, string cedula, string correo)
        {
            Conex.Open();
            comando = new SqlCommand($"select* from Clientes where nombre='{nombre}'or cedula= '{cedula}' or correo = '{correo}'", Conex);
            comando.ExecuteNonQuery();
            DataTable tab = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(tab);
            tabla.DataSource = tab;
            Conex.Close();
        }

        public static void Guardar_Pres ( string fecha,float monto , string cedula, int cuotas)
        {
            try
            {
                Conex.Open();
                string pres = "INSERT INTO Prestamos (Fecha, Monto,Ced_Cliente,cuotas) VALUES (@fecha, @monto,@cedcl, @cuota)" +
                                "update Prestamos set cuotas = Monto / cuotas where Ced_Cliente = @cedcl";
               // string Mov = "Insert into Mov_Pres (Cedula,Prestamo,Monto_Pendiente) VALUES (@cedcl,@pres,@monto)";
                //SqlCommand M = new SqlCommand(Mov, Conex);
                //M.Parameters.AddWithValue("@cedcl",cedula);
                //M.Parameters.AddWithValue("@monto", monto);
                //M.Parameters.AddWithValue("@pres", monto);
                //M.ExecuteNonQuery();
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

        public static void VerCliPres(DataGridView tabla)
        {
            Conex.Open();
            comando = new SqlCommand($"select* from Clientes", Conex);
            comando.ExecuteNonQuery();
            DataTable tab = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(tab);
            tabla.DataSource = tab;
            Conex.Close();
        }

        public static void VerPres(DataGridView tabla, string fecha, string cedula)
        {
            Conex.Open();
            comando = new SqlCommand($"select* from Prestamos where fecha='{fecha}'or Ced_Cliente= '{cedula}'", Conex);
            comando.ExecuteNonQuery();
            DataTable tab = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(tab);
            tabla.DataSource = tab;
            Conex.Close();
        }

        public static void Pago(string fecha,string cliente,int prestamo,float mont_pa)
        {
            try
            {
                Conex.Open();
                string pres = "INSERT INTO Pago (Fecha_Pago, Cliente,IdPrestamo,Monto_pagado) VALUES (@fecha,@cliente,@pres, @mont_pa)";
                comando = new SqlCommand($"update Mov_Pres set Monto_Pendiente= Monto_Pendiente - {mont_pa} where IdPrestamo={prestamo} ", Conex);
                SqlCommand p = new SqlCommand(pres, Conex);
                p.Parameters.AddWithValue("@fecha", fecha);
                p.Parameters.AddWithValue("@Cliente", cliente);
                p.Parameters.AddWithValue("@pres",prestamo );
                p.Parameters.AddWithValue("@mont_pa", mont_pa);
                p.ExecuteNonQuery();
                comando.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Ha realizado su pago correctamente ");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Error al momento de efecturar el pago");
            }
        }
        public static void VerPrest(DataGridView tabla, string cedula)
        {
            Conex.Open();
            comando = new SqlCommand($"select * from Mov_Pres where Cedula='{cedula}'", Conex);
            comando.ExecuteNonQuery();
            DataTable tab = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(tab);
            tabla.DataSource = tab;
            Conex.Close();

        }
        public static void BorrarCli(string cedula)
        {
            try
            {
                Conex.Open();
                comando = new SqlCommand($"delete from Clientes where Cedula='{cedula}'", Conex);                                                      
                comando.ExecuteNonQuery();
                Conex.Close();
                MessageBox.Show("Cliente eliminado con exito ");
            }
            catch (SystemException error)
            {

                MessageBox.Show(error.Message + "Verifique nuevamente sus datos");
            }
        }
        public static void BorrarPre(int id)
        {
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
    }

    
}
    