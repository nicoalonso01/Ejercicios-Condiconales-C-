using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            // menos de 100 litros, no hay descuento.
            //entre 101 y 300 litros, descuento  del 10%.
            //entre 301 y 500 litros,  descuento  del 15%.
            // más de 500 litros,  descuento  del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos
            // calcule y emita el importe con el descuento  aplicado..
            float importe, litros;
            Console.WriteLine("ingrese el importe total de la venta");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de lts vendidos");
            litros = float.Parse(Console.ReadLine());
            if(litros > 500 )
                importe *= 0.75F;
             else if (litros > 300 )
                importe *= 0.85F;
            else if (litros > 100)
                importe *= 0.90F;
            
            Console.WriteLine("El precio final es " + importe);
        }
    }
}
