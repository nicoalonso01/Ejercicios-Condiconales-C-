using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números 
            //emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            int n1, n2, n3;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un ultimo numero");
            n3 = int.Parse(Console.ReadLine());
            if( (n1 + n2) > (n2 * n3) )
                Console.WriteLine("ES MAYOR");
            Console.WriteLine("programa terminado");
        }
    }
}
