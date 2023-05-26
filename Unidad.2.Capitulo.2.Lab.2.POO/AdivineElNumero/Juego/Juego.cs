namespace AdivineElNumero
{
    public class Juego
    {
        private static int _record;

        public static int Record { get => _record; }

        public Juego() { }
        
        public void ComenzarJuego()
        {
            Console.WriteLine("Bienvenido al Juego Adivine el Numero!");
            Console.WriteLine();
            Juego juego = new Juego();

            var jugada = PreguntarMaximo();
            
            int numero = PreguntarNumero();
            bool continuar = false;

            while (jugada.Comparar(numero) != true)
            {
                continuar = juego.Continuar();
                if (continuar == false) break;
                numero = PreguntarNumero();
            }

            if (jugada.Adivino)
                CompararRecord(jugada);
            else
                Console.WriteLine("\nFin de la Jugada");
        }

        private Jugada PreguntarMaximo()
        {
            Console.Write("Ingrese el Numero Maximo para comenzar: ");
            int maximo = Convert.ToInt32(Console.ReadLine());
            while (maximo <= 0)
            {
                Console.Write("Ingrese el Numero Maximo para comenzar: (Mayor a 0) ");
                maximo = Convert.ToInt32(Console.ReadLine());
            }

            ConsoleKeyInfo opcion;
            do
            {
                Console.Write("Desea jugar con Ayuda? [s/n] ");
                opcion = Console.ReadKey();
                Console.WriteLine();
            } while (opcion.Key != ConsoleKey.N && opcion.Key != ConsoleKey.S);
            if (opcion.Key == ConsoleKey.S)
            {
                JugadaConAyuda jugada = new JugadaConAyuda(maximo);
                return jugada;
            }
            else
            {
                Jugada jugada = new Jugada(maximo);
                return jugada;
            }
        }

        private int PreguntarNumero()
        {
            Console.WriteLine();

            int numero = 0;
            bool error = false;
            do
            {
                try
                {
                    Console.Write("Intente adivinar el Numero: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    error = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    error = true;
                }
            } while (error == true);

            return numero;
        }

        private bool Continuar()
        {
            Console.WriteLine("No adivinaste el numero");
            ConsoleKeyInfo opcion;

            do
            {
                Console.Write("Desea continuar adivinando? [s/n] ");
                opcion = Console.ReadKey();
                Console.WriteLine();
            } while (opcion.Key != ConsoleKey.N && opcion.Key != ConsoleKey.S);

            if (opcion.Key == ConsoleKey.S)
                return true;
            else
                return false;
        }

        private void CompararRecord(Jugada jugada)
        {
            Console.WriteLine();
            Console.WriteLine("Adivinaste el Numero!");

            if (jugada.Intentos < _record || _record == 0)
            {
                _record = jugada.Intentos;
                Console.WriteLine($"Tu nuevo puntaje maximo es: {_record}");
            }
        }
    }
}