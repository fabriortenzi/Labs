using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    public class Jugada
    {
        private bool _adivino = false;
        public bool Adivino { get => _adivino;  }

        private int _intentos;

        public int Intentos { get => _intentos; }

        private int _numero;

        private int Numero 
        { 
            get => _numero;
            set => _numero = value;
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public bool Comparar(int numero)
        {
            if (numero == Numero)
                _adivino = true;

            _intentos++;
            return _adivino;
        }
    }
}
