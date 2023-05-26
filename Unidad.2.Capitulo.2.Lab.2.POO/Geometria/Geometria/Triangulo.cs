using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Geometria
{
    
    public class Triangulo
    {
        /*
            Para simplificar el ejercicio, se consideran solo los Triangulos clasificados por lado:
            Isoceles y Equilateros
        */
        public float Base { get; set; }

        public float Altura { get; set; }

        public float CalcularPerimetro()
        {
            return (Base * Altura / 2);
        }

        public float CalcularSuperficie()
        {
            float cateto;
            cateto = (float) Math.Sqrt((Math.Pow(Base / 2, 2)) + (Math.Pow(Altura, 2)));

            return (Base + 2 * cateto);
        }
    }
}