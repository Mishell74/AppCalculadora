using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppCalculadora
{
    class Program
    {


        static void Main(string[] args)
        {
            Menú MENU = new Menú ();
            Pedirnumeros Opera = new Pedirnumeros();

            int Opcion = 0;

            while (Opcion != 7)
            {
                Opcion = MENU.men();

                if (Opcion == 1)
                {
                    Console.WriteLine(Opera.Resultado('s'));
                }

                else if (Opcion == 2)
                {
                    Console.WriteLine(Opera.Resultado('r'));
                }

                else if (Opcion == 3)
                {
                    Console.WriteLine(Opera.Resultado('m'));
                }

                else if (Opcion == 4)
                {
                    Console.WriteLine(Opera.Resultado('d'));

                }

                else if (Opcion == 5)
                {
                    Console.WriteLine(Opera.Resultado('p'));
                }
                else if (Opcion == 6)
                {
                    Console.WriteLine(Opera.Resultado('q'));
                }
            }

            Console.ReadKey();

        }
    }
}

