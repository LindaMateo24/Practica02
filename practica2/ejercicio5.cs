using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio._5
{
    internal class Program
 

    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra o frase: ");
            string texto = Console.ReadLine();

            string[] palabras = texto.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                char[] caracteres = palabras[i].ToCharArray();
                Array.Reverse(caracteres);
                palabras[i] = new string(caracteres);
            }

            string resultado = String.Join(" ", palabras);

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }

}

