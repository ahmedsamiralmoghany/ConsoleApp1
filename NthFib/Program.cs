using System;
using System.Collections.Generic;

namespace NthFib
{
    class Program
    {
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
        static public void Main()
        {
            var length = Convert.ToInt32(Console.ReadLine());
            var nums = new List<int>();

            for (int i = 0; i < length; i++)
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var item in nums)
            {
                Console.WriteLine(Fib(item));
            }

        }
    }
}
