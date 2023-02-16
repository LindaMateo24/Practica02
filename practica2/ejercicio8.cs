using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            {
                Console.Write("Ingrese la primera fecha en formato dia/mes/año: ");
                string fecha1Str = Console.ReadLine();
                Console.Write("Ingrese la segunda fecha en formato dia/mes/año: ");
                string fecha2Str = Console.ReadLine();

                DateTime fecha1 = DateTime.ParseExact(fecha1Str, "dia/mes/año", null);
                DateTime fecha2 = DateTime.ParseExact(fecha2Str, "dia/mes/año", null);

                TimeSpan intervalo = fecha2 - fecha1;

                int cantidadSemanas = intervalo.Days / 7;

                Console.WriteLine("La cantidad de semanas entre las dos fechas es: " + cantidadSemanas);
            }
        }

    }
}
