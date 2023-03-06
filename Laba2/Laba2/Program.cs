
using Newtonsoft.Json;
using System;
using System.Security.AccessControl;

namespace Laba;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Fraction f = new Fraction(4, 8);
            Fraction f2 = new Fraction(2, 5);
            Console.WriteLine("If you want to reduce and proper input - 0, if summ - 1, if Substraction - 2, if Multiplication - 3, if Division - 4");
            string input = Console.ReadLine()!;
            if (input == "0")
            {
                f.Reduce();
                f.Proper();
            }
            else if (input == "1")
            {
                f.Summ(f2);
            }
            else if (input == "2")
            {

                f.Substraction(f2);
            }
            else if (input == "3")
            {
                f.Multiplication(f2);

            }
            else if (input == "4")
            {
                f.Division(f2);

            }
            Console.WriteLine("Do you want to end? y/n");
            if (Console.ReadLine() == "y")
            {
                break;
            }
        }
        

    }
}
