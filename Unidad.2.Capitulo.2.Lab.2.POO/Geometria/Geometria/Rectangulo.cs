using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {       
        public float Base { get; set; }

        public float Altura { get; set; }

        public override float CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }

        public override float CalcularSuperficie()
        {
            return Base * Altura;
        }
    }
}