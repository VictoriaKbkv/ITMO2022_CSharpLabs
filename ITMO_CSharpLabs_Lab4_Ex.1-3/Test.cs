namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            
            Console.WriteLine("Enter the first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int y = int.Parse(Console.ReadLine());
            int z = Utils.Greater(x, y);
            Console.WriteLine("The greater value is {0}", z);

            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

            bool check = Utils.Factorial(x, out z);
            if (check)
            {
                Console.WriteLine("{0}!={1}", x, z);
            }
            else
            {
                Console.WriteLine("Cannot compute this factorial");
            }
        }
    }
}
