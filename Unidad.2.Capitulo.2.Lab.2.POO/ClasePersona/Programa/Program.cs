using ClasePersona;

Persona persona1 = new("Fabrizio", "Ortenzi", 22, 91091010);

Console.WriteLine(persona1.GetFullName());

Console.WriteLine(persona1.GetAge(new DateOnly(2001, 1, 10)));