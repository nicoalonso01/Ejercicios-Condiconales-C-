using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
          //hacer un programa para ingresar 4 números. 
          //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
          int n1, n2, n3, n4;
          Console.WriteLine("ingrese un numero");
          n1 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese 2do numero");
          n2 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese otro numero");
          n3 = int.Parse(Console.ReadLine());
          Console.WriteLine("ingrese un ultimo numero");
          n4 = int.Parse(Console.ReadLine());  
          if(n1 > n2 && n2 > n3 && n3 > n4)
           Console.WriteLine ("se encuentran ordenados");
         else
            Console.WriteLine("no se encuentran");
        }    
    }
}
