using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6AppleOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart1 = new Cart();
            cart1.Buy("apple");
            cart1.Buy("apple");
            cart1.Buy("orange");
            cart1.Buy("apple");
            cart1.Buy("apple");
            cart1.Buy("apple");
            cart1.Buy("apple");
            cart1.Buy("chair");



            Console.WriteLine($"The total is {cart1.Addition()} euros");

            Console.ReadKey();


        }
    }
}
