using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos 
            int n1, n2, n3, n4, menor;
            Console.WriteLine("ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el ultimo numero: ");
            n4 = int.Parse(Console.ReadLine());
             //luego mostrar por pantalla el menor de ellos.
            if(n1 < n2)
                menor = n1;
            else
                menor = n2;
            if(n3 < menor)
                menor = n3;
            if (n4 < menor)
                menor = n4;
            Console.WriteLine("el menor es: " + menor);        
        }     
    }
}