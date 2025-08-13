using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            int n1, n2, resultado;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            if(n1 > n2)
                resultado = n1 - n2;
            else if (n1 == n2)
                resultado = n1 + n2;
            else
                resultado = n1 * n2;
            Console.WriteLine("el resultado es " + resultado);
            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
        }
    }
}
