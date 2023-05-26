namespace ClasePersona
{
    public class Persona
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Edad { get; set; }

        public int DNI { get; set; }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            DNI = dni;
            Console.WriteLine("El Objeto Persona fue creado exitosamente");
        }

        ~Persona() => Console.WriteLine("El Objeto Persona fue destruido exitosamente");

        public string GetFullName() => $"{Nombre} {Apellido}";

        public int GetAge(DateOnly fechaNacimiento)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            if (today.Day >= fechaNacimiento.Day && today.Month >= fechaNacimiento.Month)
                return today.Year - fechaNacimiento.Year;
            else
                return today.Year - fechaNacimiento.Year - 1;
        }
    }
}