using Tarea3.Entidades;
using Tarea3.Negocio;

Numero numero = new Numero();
Numeros clsnumeros = new Numeros();

Console.WriteLine("Ingresa el numero menor");
numero.NumeroMinimo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el numero mayor");
numero.NumeroMaximo = int.Parse(Console.ReadLine());

clsnumeros.ImprimirPares(numero); 




