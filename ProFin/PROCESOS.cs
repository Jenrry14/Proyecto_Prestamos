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
    abstract class PROCESOS
    {
        public abstract void Pagar(string fecha, string cliente, int prestamo, float mont_pa);
        public abstract void VerPres(DataGridView tabla, string cedula);
        public abstract void VerPrestamos(DataGridView tabla, string cedula);

    }

    class Pagoos : PROCESOS
    {
        public override void Pagar(string fecha, string cliente, int prestamo, float mont_pa)
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            SqlCommand comando;
            try
            {
                Conex.Open();
                string pres = "INSERT INTO Pago (Fecha_Pago, Cliente,IdPrestamo,Monto_pagado) VALUES (@fecha,@cliente,@pres, @mont_pa)";
                comando = new SqlCommand($"update Mov_Pres set Monto_Pendiente= Monto_Pendiente - {mont_pa} where IdPrestamo={prestamo} ", Conex);
                SqlCommand p = new SqlCommand(pres, Conex);
                p.Parameters.AddWithValue("@fecha", fecha);
                p.Parameters.AddWithValue("@Cliente", cliente);
                p.Parameters.AddWithValue("@pres", prestamo);
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

        public override void VerPres(DataGridView tabla, string cedula)
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            SqlCommand comando;

            Conex.Open();
            comando = new SqlCommand($"select * from Mov_Pres where Cedula='{cedula}'", Conex);
            comando.ExecuteNonQuery();
            DataTable tab = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(tab);
            tabla.DataSource = tab;
            Conex.Close();
        }

        public override void VerPrestamos(DataGridView tabla, string cedula)
        {
            SqlConnection Conex = new SqlConnection("Data Source=DESKTOP-5IHU68C\\SQLEXPRESS03;Initial Catalog=ProyectoF;Integrated Security=True");
            SqlCommand comando;

            Conex.Open();
            comando = new SqlCommand($"select * from Prestamos where Ced_Cliente='{cedula}'", Conex);
            comando.ExecuteNonQuery();
            DataTable tab = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(comando);
            adap.Fill(tab);
            tabla.DataSource = tab;
            Conex.Close();
        }
    }


}
