// Programa para probar el ejercicio

using Geometria;

Circulo circulo1 = new();
circulo1.Radio = 3.4F;
Console.WriteLine(circulo1.CalcularPerimetro());
Console.WriteLine(circulo1.CalcularSuperficie());

Rectangulo rectangulo1 = new();
rectangulo1.Altura = 2.1F;
rectangulo1.Base = 1.57F;
Console.WriteLine(rectangulo1.CalcularPerimetro());
Console.WriteLine(rectangulo1.CalcularSuperficie());

Triangulo triangulo1 = new();
triangulo1.Altura = 6.1F;
triangulo1.Base = 10;
Console.WriteLine(triangulo1.CalcularPerimetro());
Console.WriteLine(triangulo1.CalcularSuperficie());

Cuadrado cuadrado1 = new();
cuadrado1.Base = 5;
Console.WriteLine(cuadrado1.CalcularPerimetro());
Console.WriteLine(cuadrado1.CalcularSuperficie());
