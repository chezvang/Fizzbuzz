using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Fizzbuzz doFizzbuzz = new Fizzbuzz();
            doFizzbuzz.DoFizzBuzz();

            Console.ReadKey();
        }
    }
}
