using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                int n = 3; // cantidad de discos
                moverDiscos(n, 'A', 'B', 'C'); // llamada a la función recursiva
            }
        }
        private static void moverDiscos(int n, char origen, char auxiliar, char destino)
        {
            if (n == 1)
            {
                Console.WriteLine("Mover disco 1 de " + origen + " a " + destino);
            }
            else
            {
                moverDiscos(n - 1, origen, destino, auxiliar);
                Console.WriteLine("Mover disco " + n + " de " + origen + " a " + destino);
                moverDiscos(n - 1, auxiliar, origen, destino);
            }
        }

    }

}

