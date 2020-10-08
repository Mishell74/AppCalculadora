using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    class Menú
    {
        private int no = 0;


        public int men()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_________________________________");
            Console.WriteLine("MENU");
            Console.WriteLine("1.SUMA");
            Console.WriteLine("2.RESTA");
            Console.WriteLine("3.MULTIPLACION");
            Console.WriteLine("4.DIVISIÓN");
            Console.WriteLine("5.POTENCIA");
            Console.WriteLine("6.RADICACIÓN");
            Console.WriteLine("7.SALIR");
            Console.WriteLine("_________________________________");
            Console.WriteLine("inserte opción: ");


            try
            {
                no = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("opción inválida");
                Console.WriteLine("inserte de nuevo: ");
                no = int.Parse(Console.ReadLine());
            }


        }


    }
}
