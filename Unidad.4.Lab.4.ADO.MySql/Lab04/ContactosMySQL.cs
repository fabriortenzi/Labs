using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lab04
{
    public class ContactosMySQL : Contactos
    {
        protected string ConnectionString =>
            "server=localhost;database=net;uid=root;pwd=fabri";

        public override DataTable getTabla()
        {
            using (MySqlConnection Conn = new MySqlConnection(ConnectionString))
            {
                MySqlCommand cmdSelect = new("SELECT * FROM contactos", Conn);
                Conn.Open();
                MySqlDataReader reader = cmdSelect.ExecuteReader();
                DataTable contactos = new();
                
                if (reader != null)
                {
                    contactos.Load(reader);
                }
                Conn.Close();
                return contactos;
            }
        }

        public override void aplicaCambios()
        {
            using (MySqlConnection Conn = new(ConnectionString))
            {
                MySqlCommand cmdInsert = new("INSERT INTO contactos VALUES(@id, @nombre, @apellido, @email, @telefono)", Conn);
                cmdInsert.Parameters.Add("@id", MySqlDbType.Int32);
                cmdInsert.Parameters.Add("@nombre", MySqlDbType.VarChar, 20);
                cmdInsert.Parameters.Add("@apellido", MySqlDbType.VarChar, 20);
                cmdInsert.Parameters.Add("@email", MySqlDbType.VarChar, 50);
                cmdInsert.Parameters.Add("@telefono", MySqlDbType.VarChar, 10);

                MySqlCommand cmdUpdate = new("UPDATE contactos SET nombre=@nombre, apellido=@apellido, telefono=@telefono, email=@email WHERE id=@id", Conn);
                cmdUpdate.Parameters.Add("@id", MySqlDbType.Int32);
                cmdUpdate.Parameters.Add("@nombre", MySqlDbType.VarChar, 20);
                cmdUpdate.Parameters.Add("@apellido", MySqlDbType.VarChar, 20);
                cmdUpdate.Parameters.Add("@email", MySqlDbType.VarChar, 50);
                cmdUpdate.Parameters.Add("@telefono", MySqlDbType.VarChar, 10);

                MySqlCommand cmdDelete = new("DELETE FROM contactos WHERE id=@id", Conn);
                cmdDelete.Parameters.Add("@id", MySqlDbType.Int32);

                DataTable filasNuevas = this.misContactos.GetChanges(DataRowState.Added);
                DataTable filasBorradas = this.misContactos.GetChanges(DataRowState.Deleted);
                DataTable filasModificadas = this.misContactos.GetChanges(DataRowState.Modified);

                Conn.Open();

                if (filasNuevas != null)
                {
                    foreach (DataRow fila in filasNuevas.Rows)
                    {
                        cmdInsert.Parameters["@id"].Value = fila["id"];
                        cmdInsert.Parameters["@nombre"].Value = fila["nombre"];
                        cmdInsert.Parameters["@apellido"].Value = fila["apellido"];
                        cmdInsert.Parameters["@email"].Value = fila["email"];
                        cmdInsert.Parameters["@telefono"].Value = fila["telefono"];
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                if (filasBorradas != null)
                {
                    foreach (DataRow fila in filasBorradas.Rows)
                    {
                        cmdDelete.Parameters["@id"].Value = fila["id", DataRowVersion.Original];
                        cmdDelete.ExecuteNonQuery();
                    }
                }

                if (filasModificadas != null)
                {
                    foreach (DataRow fila in filasModificadas.Rows)
                    {
                        cmdUpdate.Parameters["@id"].Value = fila["id"];
                        cmdUpdate.Parameters["@nombre"].Value = fila["nombre"];
                        cmdUpdate.Parameters["@apellido"].Value = fila["apellido"];
                        cmdUpdate.Parameters["@email"].Value = fila["email"];
                        cmdUpdate.Parameters["@telefono"].Value = fila["telefono"];
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                Conn.Close();
                this.misContactos.AcceptChanges();
            }
        }
    }
}
