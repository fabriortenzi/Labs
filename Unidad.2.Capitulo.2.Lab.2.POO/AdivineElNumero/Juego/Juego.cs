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
            Jugada jugada = PreguntarMaximo();
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

            Jugada jugada = new(maximo);
            return jugada;
        }

        private int PreguntarNumero()
        {
            Console.WriteLine();
            Console.Write("Intente adivinar el Numero: ");
            return Convert.ToInt32(Console.ReadLine());
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