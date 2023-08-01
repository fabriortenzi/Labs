using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class ContactosMySQLConDataAdapter : Contactos
    {
        protected string ConnectionString =>
            "server=localhost;database=net;uid=root;pwd=fabri";

        protected MySqlDataAdapter adapter;

        public ContactosMySQLConDataAdapter() : base()
        {
            adapter.InsertCommand = new MySqlCommand("INSERT INTO contactos VALUES(@id, @nombre, @apellido, @email, @telefono)");
            adapter.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            adapter.InsertCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            adapter.InsertCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            adapter.InsertCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            adapter.InsertCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            adapter.UpdateCommand = new MySqlCommand("UPDATE contactos SET nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono WHERE id=@id");
            adapter.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
            adapter.UpdateCommand.Parameters.Add("@nombre", MySqlDbType.VarChar, 20, "nombre");
            adapter.UpdateCommand.Parameters.Add("@apellido", MySqlDbType.VarChar, 20, "apellido");
            adapter.UpdateCommand.Parameters.Add("@email", MySqlDbType.VarChar, 50, "email");
            adapter.UpdateCommand.Parameters.Add("@telefono", MySqlDbType.VarChar, 10, "telefono");

            adapter.DeleteCommand = new MySqlCommand("DELETE FROM contactos WHERE id=@id");
            adapter.DeleteCommand.Parameters.Add("@id", MySqlDbType.Int32, 1, "id");
        }

        public override DataTable getTabla()
        {
            adapter = new MySqlDataAdapter("SELECT * FROM contactos", ConnectionString);
            DataTable contactos = new DataTable();
            adapter.Fill(contactos);
            return contactos;
        }

        public override void aplicaCambios()
        {
            using (MySqlConnection Conn = new(ConnectionString))
            {
                adapter.InsertCommand.Connection = Conn;
                adapter.UpdateCommand.Connection = Conn;
                adapter.DeleteCommand.Connection = Conn;
                adapter.Update(misContactos);
            }
        }
    }
}
