using System;

namespace CalcOperations
{
    public class CalcClass
    {
        public void CaclMethod()
        {   
                Console.WriteLine("Enter first digit:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter operation (+,-,*,/):");
                string operation = Console.ReadLine();
                Console.WriteLine("Enter second digit:");
                int m = Convert.ToInt32(Console.ReadLine());
                if (operation == "+")
                {
                    Console.WriteLine("======================");

                    Console.WriteLine(n + m);
                }
                else if (operation == "-")
                {
                    Console.WriteLine("======================");
                    Console.WriteLine(n - m);
                }
                else if (operation == "*")
                {
                    Console.WriteLine("======================");
                    Console.WriteLine(n * m);
                }
                else if (operation == "/" && m == 0)
                {
                    Console.WriteLine("======================");
                    Console.WriteLine("Not divided to zero");
                }
                else if (operation == "/")
                {
                    Console.WriteLine("======================");
                    Console.WriteLine(n / m);
                }
                else
                {
                    Console.WriteLine("======================");
                    Console.WriteLine("Something get wrong");
                }          
        }
    }
}
