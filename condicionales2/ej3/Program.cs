using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
           //elegir la configuración del equipo a comprar.  la siguiente escala de precios:
           //           i5 (1)  	i7 (2)	i9 (3)
            //8 RAM (1)	USD 800	  USD 900	USD 1200
            //16 RAM (2)USD 900	 USD 1000	USD 1400
            //32 RAM (3)USD 1000 USD 1400	USD 2000
            //el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea,
            // lo cual tiene un costo  adicional de USD 300. 
            //Hacer un programa que solicite la opción de procesador, 
           // la opción de memoria  RAM, 
           //y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) 
           //y calcule y emita por pantalla el monto de la máquina seleccionada.
           int procesador, RAM, disco, precioFinal;
           precioFinal = 0;
           Console.WriteLine("elige el tipo de procesador: i5 selecciona(1) i7 selecciona(2) i9 selecciona(3)");
           procesador = int.Parse(Console.ReadLine());
           Console.WriteLine("elige la cantidad de memoria ram que quieres: 8RAM OPCION(1), 16 RAM OPCION(2), 32 RAM OPCION(3)");
           RAM = int.Parse(Console.ReadLine());
           Console.WriteLine("¿Desea ampliar el almacenamiento a 1TB? OPCION(1)SI, OPCION(0)NO");
           disco = int.Parse(Console.ReadLine());
           if(disco == 1)
                precioFinal += 300;
           switch (procesador){
            case 1:
                switch (RAM){
                    case 1:
                    precioFinal += 800;
                    break;  
                    case 2:
                    precioFinal += 900;
                    break;
                    case 3:
                    precioFinal += 1000;
                    break;
                }
            break;
            case 2:
                switch (RAM){
                    case 1:
                    precioFinal += 900;
                    break;  
                    case 2:
                    precioFinal += 1000;
                    break;
                    case 3:
                    precioFinal += 1400;
                    break;
                }
            break;
            case 3: 
                switch (RAM){
                    case 1:
                    precioFinal += 1200;
                    break;  
                    case 2:
                    precioFinal += 1400;
                    break;
                    case 3:
                    precioFinal += 2000;
                    break;
                }
            break;    
           }
           Console.WriteLine("el precio a pagar es de " + precioFinal);
            
        }
    }
}
