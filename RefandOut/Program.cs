using System;

namespace RefandOut
{
    class Program
    {
        //TODO impliment this ref method by returning  a string and mulitplying the parameter. So it will have two outputs but only returns the string.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable.
        public static string TimesFive(ref int x)
        {
            int y = x;
            x *= 5;
            return $"{y} * 5 = {x} ";
        }

        //TODO create method that uses the out keyword. Call the method in the main.
        public static double SquareRoot(int x, out double root)
        {
            return root = Math.Sqrt(x);
        }
  
        static void Main(string[] args)
        {
            Console.WriteLine ("What number do you want to multiply by 5?");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"{TimesFive(ref input)}");
            Console.WriteLine($"{TimesFive(ref input)}");
            double root;
            SquareRoot(input, out root);
            Console.WriteLine($"The square root of {input} is {root}");
        }

    }
}
