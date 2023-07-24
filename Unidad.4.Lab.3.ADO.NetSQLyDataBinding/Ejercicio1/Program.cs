﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();

            DataColumn colIDAlumno = new DataColumn("IDAlumno", typeof(int));
            colIDAlumno.ReadOnly = true;
            colIDAlumno.AutoIncrement = true;
            colIDAlumno.AutoIncrementSeed = 0;
            colIDAlumno.AutoIncrementStep = 1;
            
            DataColumn dtcolNombre = new DataColumn("Nombre", typeof(string));
            
            DataColumn dtcolApellido = new DataColumn("Apellido", typeof(string));

            dtAlumnos.Columns.Add(dtcolNombre);
            dtAlumnos.Columns.Add(dtcolApellido);
            dtAlumnos.Columns.Add(colIDAlumno);

            dtAlumnos.PrimaryKey = new DataColumn[] { colIDAlumno };

            DataRow rwAlumno = dtAlumnos.NewRow();
            rwAlumno[dtcolApellido] = "Perez";
            rwAlumno[dtcolNombre] = "Juan";
            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2["Apellido"] = "Perez";
            rwAlumno2["Nombre"] = "Marcelo";
            dtAlumnos.Rows.Add(rwAlumno2);

            DataTable dtCursos = new DataTable("Cursos");

            DataColumn colIDCurso = new DataColumn("IDCurso", typeof(int));
            colIDCurso.ReadOnly = true;
            colIDCurso.AutoIncrement = true;
            colIDCurso.AutoIncrementSeed = 1;
            colIDCurso.AutoIncrementStep = 1;

            DataColumn colCurso = new DataColumn("Curso", typeof(string));
            
            dtCursos.Columns.Add(colIDCurso);
            dtCursos.Columns.Add(colCurso);
            dtCursos.PrimaryKey = new DataColumn[] { colIDCurso };

            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[colCurso] = "Informatica";
            dtCursos.Rows.Add(rwCurso);

            DataSet dsUniversidad = new DataSet();
            dsUniversidad.Tables.Add(dtAlumnos);
            dsUniversidad.Tables.Add(dtCursos);

            DataTable dtAlumnos_Cursos = new DataTable("Alumnos_Cursos");

            DataColumn col_ac_IDAlumno = new DataColumn("IDAlumno", typeof(int));

            DataColumn col_ac_IDCurso = new DataColumn("IDCurso", typeof(int));

            dtAlumnos_Cursos.Columns.Add(col_ac_IDCurso);
            dtAlumnos_Cursos.Columns.Add(col_ac_IDAlumno);

            dsUniversidad.Tables.Add(dtAlumnos_Cursos);

            DataRelation relAlumno_ac = new DataRelation("Alumno_Cursos", colIDAlumno, col_ac_IDAlumno);

            DataRelation relCurso_ac = new DataRelation("Curso_Alumnos", colIDCurso, col_ac_IDCurso);

            dsUniversidad.Relations.Add(relAlumno_ac);
            dsUniversidad.Relations.Add(relCurso_ac);

            DataRow rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IDAlumno] = 0;
            rwAlumnosCursos[col_ac_IDCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            rwAlumnosCursos = dtAlumnos_Cursos.NewRow();
            rwAlumnosCursos[col_ac_IDAlumno] = 1;
            rwAlumnosCursos[col_ac_IDCurso] = 1;
            dtAlumnos_Cursos.Rows.Add(rwAlumnosCursos);

            Console.Write("Ingrese el Nombre del Curso: ");
            string materia = Console.ReadLine();
            Console.WriteLine($"Listado de Alumnos del Curso {materia}");
            DataRow[] row_CursoInf = dtCursos.Select($"Curso = '{materia}'");
            foreach(DataRow rowCu in row_CursoInf)
            {
                DataRow[] row_AlumnosInf = rowCu.GetChildRows(relCurso_ac);
                foreach(DataRow rowAl in row_AlumnosInf)
                {
                    Console.WriteLine
                        ($"{rowAl.GetParentRow(relAlumno_ac)[dtcolApellido].ToString()}, " +
                         $"{rowAl.GetParentRow(relAlumno_ac)[dtcolNombre].ToString()}");
                }
            }

        }
    }
}
