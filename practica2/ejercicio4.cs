using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._04
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.Write("Ingrese una palabra o frase: ");
                string texto = Console.ReadLine();

                // Convertimos el texto a minúsculas y eliminamos los espacios en blanco
                string textoLimpio = texto.ToLower().Replace(" ", "");

                bool esPalindromo = true;

                for (int i = 0; i < textoLimpio.Length / 2; i++)
                {
                    if (textoLimpio[i] != textoLimpio[textoLimpio.Length - i - 1])
                    {
                        esPalindromo = false;
                        break;
                    }
                }

                if (esPalindromo)
                {
                    Console.WriteLine("{0} es un palíndromo.", texto);
                }
                else
                {
                    Console.WriteLine("{0} no es un palíndromo.", texto);
                }
            }
        }

    }

