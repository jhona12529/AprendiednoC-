using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiedno_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                 //Escribir mensaje
                Console.WriteLine("Bienvenidos a c#");
                //-- Definir Variables --
                int a, b, producto;
                //-- Entrada Datos --
                Console.WriteLine("Ingrese Primer Numero: ");
                //Guardar valor de la cosola
                a = int.Parse(Console.ReadLine());
                //a = int.TryParse(Console.ReadLine()); //Boolean True o False
                //-- Entrada Datos --
                Console.WriteLine("Ingrese Segundo Numero: ");
                //Guardar valor de la cosola
                b = int.Parse(Console.ReadLine());
                //b = int.TryParse(Console.ReadLine()); //Boolean True o False
                //-- Proceso --
                producto = a * b;
                //-- Salida Datos --
                Console.WriteLine("El producto es:" + (producto + 2));
                Console.WriteLine($"El producto de {a} * {b} = {producto}");
                //Detener Pantalla para mostrar el resultado
                Console.ReadKey();



            }

        }

    }




}
    