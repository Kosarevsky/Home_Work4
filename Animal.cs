using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Animal
    {
        public delegate void Delegate2();

        public Delegate2 delegate2 = () => Console.WriteLine("Hello world");


        //public Delegate2 delegate2 = Method1;
        //public static void Method1()
        //{
        //    Console.WriteLine("Hello world");
        //}
    }

}
