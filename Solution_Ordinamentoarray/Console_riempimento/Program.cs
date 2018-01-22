using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_riempimento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeri = new int[] { 72, 43, 55, 61, 73, 5, 43, 32, 43, 55, 11, 54, 65, 43, 73, 67, 5, 5, 73, 43 };
            int[] posizione = new int[20];
            int numero = 0;
            int ctr = 0;
            int sost = 0;

            Console.WriteLine("Inserisci il numero da trovare");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Numeri.Length; i++)
            {
                if (Numeri[i] == numero)
                {
                    posizione[i] = 1;
                }
                else
                {
                    posizione[i] = 0;
                }
            }
            for (int i = 0; i < posizione.Length; i++)
            {
                if (posizione[i] == 1)
                {
                    Console.WriteLine("ho trovato in posizione {0} il numero carcato {1}", i, numero);
                    Console.WriteLine();
                    ctr++;
                }
            }
            if (ctr == 0) Console.WriteLine("Lillo non ho trovato il numero che volevi");

            for (int i = 0; i < Numeri.Length; i++)
            {
                if (numero == Numeri[i])
                {
                    Console.WriteLine("con che numero vuoi sostituire il {0} nella posizione {1}", numero, i);
                    sost = Convert.ToInt32(Console.ReadLine());

                    Numeri[i] = sost;
                }

            }
            for (int i = 0; i < Numeri.Length; i++)
            {
                Console.WriteLine("{0}", Numeri[i]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
