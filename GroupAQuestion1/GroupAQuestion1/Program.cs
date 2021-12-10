using System;

namespace GroupAQuestion1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        public int findDigits(int number)
        {
            Console.Write("Enter a number :");
            int numb = int.Parse(Console.ReadLine());
            string n = numb.ToString();

            int count = 0;
            for (int d = n[0]; d < n.Length; d++)
            {
                if (numb % d == 0)
                    count += d;
            }
            Console.WriteLine($"{count}");


            return number;
        }
    }
}
