﻿using System;
namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute \n1.Fibonacci Series \n2.Perfect Number \n3.Prime Number \n4.Reverse a Number \n5.Exit");
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
                        Console.WriteLine("Enter number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.PerfectNum(num);
                        break;
                    case 3:
                        Console.WriteLine("Enter number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.IsPrime(n);
                        break;
                    case 4:
                        Console.WriteLine("Enter number");
                        int a = Convert.ToInt32(Console.ReadLine());
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.Reverse(a);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}