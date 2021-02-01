using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    delegate T Operation<T,K>(K val);
    public static class GenericDelegate
    {
        public static void ExampleGeneric()
        {
            Operation<int,int> operation;
            operation = (x) => x + x;

            Console.WriteLine($"Сумма двух чисел 5= {operation(5)}");
        }
    }
}
