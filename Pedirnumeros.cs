using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    class Pedirnumeros
    {
        public Procedimiento pedir = new Procedimiento();

        public double n = 0;



        public string Resultado(char t)

        {

            double Tot = 0;



            char op = 's';





            while (op != 'n')

            {

                if (t == 's')

                {

                    Tot = pedir.Sum(Tot, PedirVal());

                }

                else if (t == 'r')

                {

                    Tot = pedir.Rest(Tot, PedirVal());

                }
                else if (t == 'm')

                {
                    Tot = pedir.Mult(Tot, PedirVal());
                }
                else if (t == 'd')

                {
                    Tot = pedir.Div(Tot, PedirVal());
                }
                else if (t == 'p')

                {

                    Tot = pedir.Pot(Tot, PedirVal());
                }
                else if (t == 'q')
                {
                    Tot = pedir.Raiz(Tot, PedirVal());
                }


                bool a = false;
                Console.WriteLine("¿Quiere agregar una cantidad?");
                Console.WriteLine("Si                 No");

                while (a == false)
                {
                    try
                    {

                        op = char.Parse(Console.ReadLine());
                        a = true;
                    }
                    catch
                    {
                        Console.WriteLine("Ingrese letras");
                        op = char.Parse(Console.ReadLine());

                    }


                }

            }



            return ("Resultado de la operacion: " + Tot);

        }



        private double PedirVal()
        {
            double Val = 0;
            bool Est = false;



            while (Est == false)

            {

                Console.Write("ingrese un Numero: ");

                try

                {

                    Val = double.Parse(Console.ReadLine());

                    Est = true;

                }

                catch

                {
                    Console.WriteLine("Caracter u operacion invalida, por favor intente de nuevo");
                }

            }
            return Val;


        }

    }
}

    

