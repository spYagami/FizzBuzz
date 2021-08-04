using System;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            int max = 30;
            for(int i=1; i<= max; i++)
            {
                Console.WriteLine($"{FizzBuzz(i)}");
            }
        }

        public static string FizzBuzz(int n)
        {
            if (n % 3 == 0)
                return "Fizz";
            else if (n % 5 == 0)
                return "Buzz";
            else if (n % 15 == 0)
                return "FizzBuzz";

            return n.ToString();
 
        }

        //public static string DivisibleByThree(int x)
        //{
        //    if (x % 3 == 0)
        //        return "Fizz";

        //    return string.Empty;
        //}
        //public static string DivisibleByFive(int x)
        //{
        //    if (x % 5 == 0)
        //        return "Buzz";

        //    return string.Empty;
        //}
        //public static string DivisibleByFifteen(int x)
        //{
        //    if (x % 15 == 0)
        //        return "FizzBuzz";

        //    return string.Empty;
        //}
    }
}
