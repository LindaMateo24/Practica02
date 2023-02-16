using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaPracticaEjercicio1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la fracción mixta");
            string input = Console.ReadLine();

            int wholeNumber = int.Parse(input.Split(' ')[0]);
            int numerator = int.Parse(input.Split(' ')[1].Split('/')[0]);
            int denominator = int.Parse(input.Split(' ')[1].Split('/')[1]);

            int newNumerator = wholeNumber * denominator + numerator;

            Console.WriteLine($"La fracción mixta {input} en fracción común es: {newNumerator}/{denominator}");
        }
    }
}
