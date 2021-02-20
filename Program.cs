using System;
using FunctionsLibrary_DWB;

namespace TestFunctionDWB_Sabado
{
    class Program
    {
        static void Main(string[] args)
        {
            Function fn = new Function();
            var x = fn.Sum(20, 43);
            var y = fn.Mult(30, 12);
            var w = fn.Div(10, 5);
            var t = fn.Resta(100, 50);

            Console.WriteLine("La suma es " + x);
            Console.WriteLine("La multiplicación es " + y);

            Console.WriteLine("La division es " + w);
            Console.WriteLine("La resta es " + t);

        }
    }
}
