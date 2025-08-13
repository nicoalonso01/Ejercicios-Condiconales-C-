using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
           // ingresar un número 
           int numero;
            Console.WriteLine("Escriba un numero");
            numero = int.Parse(Console.ReadLine());
           //se emita un cartel por pantalla “Positivo” si el número es mayor a cero,
           if(numero > 0)
                Console.WriteLine("Positivo");
                else if(numero < 0 )
                    Console.WriteLine("Negativo");
                else
                    Console.WriteLine("Cero");
           
           // “Negativo” si el número es menor a cero o 
           //“Cero” si el número es igual a cero.
        }
    }
}
