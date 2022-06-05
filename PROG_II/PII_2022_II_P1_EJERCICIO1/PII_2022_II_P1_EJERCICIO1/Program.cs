using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PII_2022_II_P1_EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            // comentario 1 linea
            /*
             *comentario multilinea
             */

            //PROGRAMA QUE SOLICITE NOM ALUMNO Y SUS 3 NOTAS
            //CALCULE EL PROMEDIO
            string nom;
            int n1,n2,n3;
            decimal prom;
            WriteLine("Ingrese el nombre de alumno:");
            nom = ReadLine();
            WriteLine("Ingrese nota 1");
            n1 = int.Parse( ReadLine());
            WriteLine("Ingrese nota 2");
            n2 = int.Parse( ReadLine());
            WriteLine("Ingrese nota 3");
            n3 = int.Parse( ReadLine());
            prom = (n1 + n2 + n3) / 3;
            Write($"El alumno {nom} tiene un promedio de:\n{prom}");
            ReadLine();
        }
    }
}
