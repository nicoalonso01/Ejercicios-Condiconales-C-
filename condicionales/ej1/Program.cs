using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingresar un número 
            // se emita por pantalla un cartel aclaratorio si
            // “Es mayor a 10” o “No es mayor a 10”.
            int numero;
            Console.WriteLine("escriba un numero");
            numero = int.Parse(Console.ReadLine());
            if(numero > 10)
                Console.WriteLine("Es mayor a 10");
            else
                Console.WriteLine("es menor a 10");
            
        }
    }
}
