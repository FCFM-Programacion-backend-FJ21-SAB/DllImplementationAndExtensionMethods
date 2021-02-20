using FunctionsLibrary_DWB;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFunctionDWB_Sabado
{
    public static class MyOwnOperations
    {
        public static decimal Div(this Function fn, decimal x, decimal y)
        {
            return x / y; 
        }

        public static decimal Resta(this Function f, decimal x, decimal y)
        {
            return x - y;
        }
    }
}
