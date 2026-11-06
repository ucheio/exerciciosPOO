using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Multiplicar(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Subtrair(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Dividir(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}