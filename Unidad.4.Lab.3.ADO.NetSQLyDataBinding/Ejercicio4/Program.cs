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

            SqlConnection myconn = new SqlConnection();

            myconn.ConnectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=unidad4_lab3;Integrated Security=True;";

            SqlCommand mycommand = new SqlCommand();

            mycommand.CommandText = "SELECT id, company_name FROM customers";

            mycommand.Connection = myconn;

            SqlDataAdapter myadap = new SqlDataAdapter("SELECT id, company_name FROM customers", myconn);

            myconn.Open();

            SqlDataReader mydr = mycommand.ExecuteReader();

            dtEmpresas.Load(mydr);

            myconn.Close();

            Console.WriteLine("Listado de Empresas");

            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string id = rowEmpresa["id"].ToString();
                string nombreEmpresa = rowEmpresa["company_name"].ToString();
                Console.WriteLine($"{id} - {nombreEmpresa}");
            }


        }
    }
}
