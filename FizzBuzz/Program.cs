using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stage 1:");
            for (int index = 1; index <= 100; index++)
            {
                Stage1(index);
            }
            Console.WriteLine("");

            Console.WriteLine("Stage 2:");
            for (int index = 1; index <= 100; index++)
            {
                Stage2(index);
            }
            //test comment
        }

        private static void Stage1(int index)
        {
            if (index % 3 == 0 && index % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (index % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (index % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
        private static void Stage2(int index)
        {
            String indexSting = index.ToString();
            if (index % 3 == 0 && index % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (index % 3 == 0 || indexSting.Contains("3"))
            {
                Console.WriteLine("Fizz");
            }
            else if (index % 5 == 0 || indexSting.Contains("5"))
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
