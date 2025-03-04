﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab04
{
    public class Contactos
    {
        protected DataTable misContactos;

        public Contactos()
        {
            this.misContactos = this.getTabla();
        }

        public virtual DataTable getTabla()
        {
            return new DataTable();
        }

        public virtual void aplicaCambios() { }

        public void listar()
        {
            foreach (DataRow fila in this.misContactos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn col in this.misContactos.Columns)
                    {
                        Console.WriteLine($"{col.ColumnName} {fila[col]}");
                    }

                    Console.WriteLine();
                }
            }
        }

        public void nuevaFila()
        {
            DataRow fila = this.misContactos.NewRow();

            foreach (DataColumn col in this.misContactos.Columns)
            {
                Console.Write($"Ingrese {col.ColumnName}: ");
                fila[col] = Console.ReadLine();
            }

            this.misContactos.Rows.Add(fila);
        }

        public void editarFila()
        {
            Console.WriteLine("Ingrese el numero de la fila a editar");
            int nroFila = int.Parse(Console.ReadLine());
            DataRow fila = this.misContactos.Rows[nroFila - 1];

            // El 0 se omite por se el ID
            for (int nroCol = 1; nroCol < this.misContactos.Columns.Count; nroCol++)
            {
                DataColumn col = this.misContactos.Columns[nroCol];
                Console.Write($"Ingrese {col.ColumnName}: ");
                fila[col] = Console.ReadLine();
            }
        }

        public void eliminarFila()
        {
            Console.WriteLine("Ingrese el numero de la fila a eliminar");
            int fila = int.Parse(Console.ReadLine());
            this.misContactos.Rows[fila - 1].Delete();
        }
    }
}
