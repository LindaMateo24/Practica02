using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Bienvenido a la tómbola de la lotería nacional");
            Console.WriteLine("Presione Enter para sacar los números");

            Console.ReadLine();

            int numero1 = random.Next(1, 100);
            int numero2 = random.Next(1, 100);
            int numero3 = random.Next(1, 100);

            Console.WriteLine("Los números son: {0}, {1}, {2}", numero1, numero2, numero3);
        }
    }
}
