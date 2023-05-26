using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }

        public override bool Comparar(int numero)
        {
            if (numero == Numero)
                _adivino = true;
            else
            {
                int difference = Numero - numero;

                switch (difference)
                {
                    case (>= 100):
                        Console.WriteLine("El numero es mayor y se encuentra muy lejos");
                        break;
                    case (<= -100):
                        Console.WriteLine("El numero es menor y se encuentra muy lejos");
                        break;
                    case (>= 50):
                        Console.WriteLine("El numero es mayor y se encuentra lejos");
                        break;
                    case (<= -50):
                        Console.WriteLine("El numero es menor y se encuentra lejos");
                        break;
                    case (>= 20):
                        Console.WriteLine("El numero es mayor y se encuentra un poco cerca");
                        break;
                    case (<= -20):
                        Console.WriteLine("El numero es menor y se encuentra un poco cerca");
                        break;
                    case (>= 5):
                        Console.WriteLine("El numero es mayor y se encuentra cerca");
                        break;
                    case (<= -5):
                        Console.WriteLine("El numero es menor y se encuentra cerca");
                        break;
                    case (>= 0):
                        Console.WriteLine("El numero es mayor y se encuentra muy cerca");
                        break;
                    case (<= 0):
                        Console.WriteLine("El numero es menor y se encuentra muy cerca");
                        break;
                }
            }                

            _intentos++;
            return _adivino;
        }
    }
}
