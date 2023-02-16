using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._02
{
    internal class Program
    {
          
        
            static void Main(string[] args)
            {
                Console.Write("Por favor Ingrese el primer número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.Write("Por favor Ingrese el segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                int mcd = CalcularMCD(numero1, numero2);
                int mcm = CalcularMCM(numero1, numero2, mcd);

                Console.WriteLine("El MCD de {0} y {1} es: {2}", numero1, numero2, mcd);
                Console.WriteLine("El MCM de {0} y {1} es: {2}", numero1, numero2, mcm);
            }

            static int CalcularMCD(int a, int b)
            {
                int resto;

                while (b != 0)
                {
                    resto = a % b;
                    a = b;
                    b = resto;
                }

                return a;
            }

            static int CalcularMCM(int a, int b, int mcd)
            {
                return (a * b) / mcd;
            }
        }

    }


