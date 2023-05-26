using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    public class Jugada
    {
        protected bool _adivino = false;
        public bool Adivino { get => _adivino;  }

        protected int _intentos;

        public int Intentos { get => _intentos; }

        protected int _numero;

        protected int Numero 
        { 
            get => _numero;
            set => _numero = value;
        }

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public virtual bool Comparar(int numero)
        {
            if (numero == Numero)
                _adivino = true;

            _intentos++;
            return _adivino;
        }
    }
}
