using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtEmpresas = new DataTable("Empresas");

            dtEmpresas.Columns.Add("id", typeof(string));
            dtEmpresas.Columns.Add("company_name", typeof(string));

            SqlConnection myConn = new SqlConnection();

            myConn.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=unidad4_lab3;Integrated Security=True;";

            SqlDataAdapter myAdap = new SqlDataAdapter("SELECT id, company_name FROM customers", myConn);

            myConn.Open();
            myAdap.Fill(dtEmpresas);
            myConn.Close();

            Console.WriteLine("Listado de Empresas");

            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string id = rowEmpresa["id"].ToString();
                string nombreEmpresa = rowEmpresa["company_name"].ToString();
                Console.WriteLine($"{id} - {nombreEmpresa}");
            }


            // Update
            Console.Write("\nEscriba el id del cliente que desea modificar: ");
            string custId = Console.ReadLine();

            DataRow[] rwEmpresas = dtEmpresas.Select($"id = '{custId}'");
            if (rwEmpresas.Length != 1)
            {
                Console.WriteLine("Cliente no encontrado");
                return;
            }

            DataRow rowMiEmpresa = rwEmpresas[0];
            string nombreActual = rowMiEmpresa["company_name"].ToString();
            Console.WriteLine($"Nombre actual de la empresa: {nombreActual}");
            Console.Write("Escriba el nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();

            rowMiEmpresa.BeginEdit();
            rowMiEmpresa["company_name"] = nuevoNombre;
            rowMiEmpresa.EndEdit();

            SqlCommand updCommand = new SqlCommand();
            updCommand.Connection = myConn;
            updCommand.CommandText = "UPDATE customers SET company_name = @company_name WHERE id = @id";

            updCommand.Parameters.Add("@company_name", SqlDbType.VarChar, 20, "company_name");
            updCommand.Parameters.Add("@id", SqlDbType.Int, 8,"id");

            myAdap.UpdateCommand = updCommand;
            myAdap.Update(dtEmpresas);
        }
    }
}
