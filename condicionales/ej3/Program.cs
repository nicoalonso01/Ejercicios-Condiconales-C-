using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe, precioFinal, descuento;
            Console.WriteLine("Escriba el importe");
            importe = float.Parse(Console.ReadLine());
            if(importe >= 5000){
               descuento = importe * 0.18F;
                precioFinal = importe - descuento;
            }else if (importe >= 1000){
                descuento = importe * 0.1F;
                precioFinal = importe - descuento;    
            }else{
                precioFinal = importe;
            }
            Console.WriteLine("el precio final es " + precioFinal);           
        }    
    }
}
