using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PII_2022_II_P1_EJERCICIO25
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"El max de 2,3,4: {obtenerMax(5,3,4)}");
            WriteLine($"El max de 1.2, 3.4, 5.1: {obtenerMax(1.2, 3.4, 5.1)}");
            WriteLine($"El max de pera, manzana, uva: {obtenerMax("pera", "manzana","uva")}");
            ReadLine();
        }

        static T obtenerMax<T>(T x, T y, T z) where T : IComparable<T>
        {
            var max = x;
            if (y.CompareTo(max) > 0)
            {
                max = y;
            }
            else if (z.CompareTo(max) > 0) {
                max = z;
                    }

            return max;
            }
  }
}