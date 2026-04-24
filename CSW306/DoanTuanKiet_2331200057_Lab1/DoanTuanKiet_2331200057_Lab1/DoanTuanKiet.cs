using System;
using System.Linq.Expressions;

namespace DoanTuanKiet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our service\nPlease enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            while (true)
            {
                Console.WriteLine("Please select a function:");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Swap two numbers");
                Console.WriteLine("3. Classify student");
                Console.WriteLine("4. Print month information");
                Console.WriteLine("5. Sum from 1 to N");
                Console.WriteLine("6. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the first number:");
                        int numberA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number:");
                        int numberB = Convert.ToInt32(Console.ReadLine());
                        int sum = AddTwoNumbers(numberA, numberB);
                        Console.WriteLine("The sum of {0} and {1} is {2}", numberA, numberB, sum);
                        Thread.Sleep(3000); // Wait for 3 secs
                        break;
                    case 2:
                        Console.WriteLine("Enter the first number:");
                        int numA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the second number:");
                        int numB = Convert.ToInt32(Console.ReadLine());
                        SwapNumbers(numA, numB);
                        Thread.Sleep(3000);
                        break;
                    case 3:
                        Console.WriteLine("Enter the average score:");
                        double averageScore = Convert.ToDouble(Console.ReadLine());
                        ClassifyStudent(averageScore);
                        Thread.Sleep(3000);
                        break;
                    case 4:
                        Console.WriteLine("Enter the month (1-12):");
                        int month = Convert.ToInt32(Console.ReadLine());
                        PrintMonthInfo(month);
                        Thread.Sleep(3000);
                        break;
                    case 5:
                        Console.WriteLine("Enter a positive integer N:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        SumToN(n);
                        Thread.Sleep(3000);
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using our service. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Thread.Sleep(3000);
                        break;
                }


            }
        }

        static int AddTwoNumbers(int numberA, int numberB)
        {
            return numberA + numberB;
        }

        static void SwapNumbers(int numberA, int numberB)
        {
            Console.WriteLine("Before swapping: numberA = {0}, numberB = {1}", numberA, numberB);
            int tmp = numberA;
            numberA = numberB;
            numberB = tmp;
            Console.WriteLine("After swapping: numberA = {0}, numberB = {1}", numberA, numberB);
            return;
        }

        static void ClassifyStudent(double averageScore)
        {
            if (averageScore >= 90 && averageScore <= 100)
            {
                Console.WriteLine("Excellent");
                return;
            }
            else if (averageScore >= 80 && averageScore < 90)
            {
                Console.WriteLine("Good");
                return;
            }
            else if (averageScore >= 70 && averageScore < 80)
            {
                Console.WriteLine("Fair");
                return;
            }
            else
            {
                Console.WriteLine("Average");
                return;
            }
            return;
        }

        static void PrintMonthInfo(int month)
        {
            if (month < 1 || month > 12)
            {
                Console.WriteLine("The month input is invalid.");
                return;
            }
            else
            {
                switch (month)
                {
                    case 1: Console.WriteLine("Have 31 days"); break;
                    case 2: Console.WriteLine("Have 28 or 29 days"); break;
                    case 3: Console.WriteLine("Have 31 days"); break;
                    case 4: Console.WriteLine("Have 30 days"); break;
                    case 5: Console.WriteLine("Have 31 days"); break;
                    case 6: Console.WriteLine("Have 30 days"); break;
                    case 7: Console.WriteLine("Have 31 days"); break;
                    case 8: Console.WriteLine("Have 31 days"); break;
                    case 9: Console.WriteLine("Have 30 days"); break;
                    case 10: Console.WriteLine("Have 31 days"); break;
                    case 11: Console.WriteLine("Have 30 days"); break;
                    case 12: Console.WriteLine("Have 31 days"); break;
                }
            }
        }

        static void SumToN(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum from 1 to {0} is {1}", n, sum); //Show result
        }

    }
}