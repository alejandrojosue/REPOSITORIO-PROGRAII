using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace PII_2022_II_P1_EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {

            //''''''''''''''''''''''''''''''''''''''''''''''''''''--------------

            

    //--------------------------





            /*
             * solicite el promedio
             * si prom<=65 reprobado
             * sino aprobado
             * 
            //estructuras condicion
            double prom;
            WriteLine("Ingrese el promedio:");
            prom = double.Parse(ReadLine());

            if (prom <=65)
            {
                WriteLine("Esta reprobado");
            }
            else
            {
                WriteLine("Esta aprobado");
            }
            */

            /*
             * Solicitar una clave
             * si clave = ujcv
             * msj de bienvenida
             * sino
             * msj de incorrecto
             */

            /*
            string clave;
            WriteLine("Ingrese la clave");
            clave = ReadLine();
            if (clave == "ujcv")

            { 
                WriteLine("Bienvenido");
            }
            else
            {
                WriteLine($"La clave {clave} es incorrecta");

            }
            */

            /*
             * programa que muestre un saludo de acuerdo a la hora
             * si hora < 12 buenos dias
             * si hora < 18 buenas tardes
             * sino buenas noches
             */

            int hr;

            WriteLine("Ingrese la hora");
            hr = int.Parse(ReadLine());
            if (hr < 12)
            {
                WriteLine("Buenos dias");
            }else if(hr < 18)
            {
                WriteLine("Buenas tardes");
            }
            else
            {
                WriteLine("Buenas noches");
            }
            ReadLine();
        }
    }
}
