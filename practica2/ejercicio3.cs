using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaPractica

{

    class Program
    {
       using System;

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la operación a realizar (suma o diferencia): ");
            string operacion = Console.ReadLine();

            Console.Write("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            if (operacion == "suma")
            {
                resultado = (int)(Math.Pow(numero1, 3) + Math.Pow(numero2, 3));
            }
            else if (operacion == "diferencia")
            {
                resultado = (int)(Math.Pow(numero1, 3) - Math.Pow(numero2, 3));
            }
            else
            {
                Console.WriteLine("Operación inválida.");
                return;
            }

            Console.WriteLine("El resultado de la {0} de cubos de {1} y {2} es: {3}", operacion, numero1, numero2, resultado);
        }
    }



