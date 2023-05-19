using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        public override float CalcularPerimetro()
        {
            return (Base * 4);
        }

        public override float CalcularSuperficie()
        {
            return (float) Math.Pow(Base, 2);
        }
    }
}