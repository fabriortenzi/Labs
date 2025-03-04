﻿using System.Net.Http.Headers;

namespace Negocio
{
    public sealed class Conexion
    {
        private Conexion() { }
        private static Conexion? instancia;
        private HttpClient _Cliente = new HttpClient();

        public HttpClient Cliente
        {
            get => _Cliente;
        }

        public static Conexion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Conexion();
                    instancia._Cliente.DefaultRequestHeaders.Accept.Clear();
                    instancia._Cliente.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                }
                return instancia;
            }
        }
    }
}