using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Ingrese un año: ");
                int anio = int.Parse(Console.ReadLine());

                if (esBisiesto(anio))
                {
                    Console.WriteLine(anio + " es un año bisiesto");
                }
                else
                {
                    Console.WriteLine(anio + " no es un año bisiesto");
                }
            }
        }
        private static bool esBisiesto(int anio)
        {
            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

