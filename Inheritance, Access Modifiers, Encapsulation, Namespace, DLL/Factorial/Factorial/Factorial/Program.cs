using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial fact = new Factorial();
            int n = 5;
            int factorial = Factorial.Fact(n);

            Console.WriteLine(factorial);
        }
        
    }

}
