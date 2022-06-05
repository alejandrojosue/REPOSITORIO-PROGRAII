using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PII_2022_II_P1_EJERCICIO24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] argEnteros = {1,2,3,4,5,6,7 };
            double[] argDouble = { 1.2,1.1,1.3,1.4,1.5,1.6,1.7};
            char[] argChars = {'a','b','c','d' };

            WriteLine("El contenido del arreglo de enteros es: ");
            imprimirArreglos(argEnteros);
            WriteLine("El contenido del arreglo de doubles es: ");
            imprimirArreglos(argDouble);

            WriteLine("El contenido del arreglo de chars es: ");
            imprimirArreglos(argChars);
            ReadLine();
        }

        static void imprimirArreglos<T>(T[] pArg)
        {
            foreach (var item in pArg)
            {
                WriteLine($"{item}");
            }
            WriteLine();
        }

        /*
        static void imprimirArreglos(int[] pArg)
        {
            foreach(var item in pArg)
            {
                WriteLine($"{item}");
            }
            WriteLine();
        }

        static void imprimirArreglos(double[] pArg)
        {
            foreach (var item in pArg)
            {
                WriteLine($"{item}");
            }
            WriteLine();
        }

        static void imprimirArreglos(char[] pArg)
        {
            foreach (var item in pArg)
            {
                WriteLine($"{item}");
            }
            WriteLine();
        }
        */
    }
}
