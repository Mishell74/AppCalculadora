using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    class Procedimiento
    {
        public double Sum(double x, double y)
        {
            return (x + y);
        }
        public double Rest(double x, double y)
        {
            return (x - y);
        }
        public double Mult(double x, double y)
        {
            return (x * y);
        }
        public double Div(double x, double y)
        {
            return (x / y);
        }
        public double Pot(double x, double y)
        {
            return (Math.Pow(x, y));
        }
        public double Raiz(double x, double y)
        {
            return (Math.Sqrt(x));
        }


    }
}
