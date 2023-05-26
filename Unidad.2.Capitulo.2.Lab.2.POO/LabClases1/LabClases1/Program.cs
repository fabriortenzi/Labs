using Clases;

A instanceA = new();

instanceA.MostrarNombre();
instanceA.M1();
instanceA.M2();
instanceA.M3();

A instanceAWithName = new("Fabrizio");
instanceAWithName.MostrarNombre();

B instanceB = new();
instanceB.MostrarNombre();
instanceB.M1();
instanceB.M4();

/*
Si se cambian las accesibilidades de los miembros a private y protected no se pueden 
invocar los metodos desde el programa
*/
