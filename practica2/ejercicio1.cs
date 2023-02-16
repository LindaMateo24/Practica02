using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO02
{
  
class NumerosPrimos
        {
            static void Main(string[] args)
            {
                Console.Write("Por favor ingrese el número inicial: ");
                int numeroInicial = int.Parse(Console.ReadLine());

                Console.Write("Por favor ingrese el número final: ");
                int numeroFinal = int.Parse(Console.ReadLine());

                Console.WriteLine("Los números primos entre {0} y {1} son:", numeroInicial, numeroFinal);

                for (int numero = numeroInicial; numero <= numeroFinal; numero++)
                {
                    bool esPrimo = true;

                    for (int divisor = 2; divisor < numero; divisor++)
                    {
                        if (numero % divisor == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo && numero > 1)
                    {
                        Console.WriteLine(numero);
                    }
                }
            }
        }

    }

