using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    internal class Calculadora
    {

        public Calculadora(double sum1, double sum2)
        {
            double resultado = sum1 + sum2;
            Console.WriteLine($"{sum1} + {sum2} = {resultado}");
        }

        public Calculadora(double mul1, double mul2, int i = 0)
        {
            double resultado = mul1 * mul2;
            Console.WriteLine($"{mul1} * {mul2} = {resultado}");

        }
        public Calculadora(double div1, double div2, int i = 0, int i1 = 0)
        {

            double resultado = div1 / div2;

            Console.WriteLine($"{div1} / {div2} = {resultado}");

        }
        public Calculadora(double resi1, double resi2, int i = 0, int i2 = 0, int i3 = 0)
        {
            double resultado = resi1 % resi2;

            Console.WriteLine($"{resi1} % {resi2} = {resultado}");
        }
    }
}
