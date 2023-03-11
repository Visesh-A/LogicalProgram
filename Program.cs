using System;
namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programming");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute \n1.Fibonacci Series \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries series = new FibonacciSeries();
                        series.PrintSeries(number);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}