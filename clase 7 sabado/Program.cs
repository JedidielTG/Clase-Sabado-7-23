using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_7_sabado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prueba = false;
            do
            {
                try
                {
                    Console.Write("Ingrese un valor: ");
                    string linea = Console.ReadLine();
                    var num = int.Parse(linea);
                    var cuadrado = num * num;
                    Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
                    Console.ReadKey();
                    prueba = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("debe ingresar un entero ");
                }
            } while (prueba == false);

            
            Console.ReadKey();
        }
    }
}
