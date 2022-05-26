using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    internal class DevideIt
    {
        static void Main(string[] args)
        {
            try
            {
                string temp;
                Console.WriteLine("Please, enter the first integer");
                temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.WriteLine("Please, enter the second integer");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine("The result of deviding {0} by {1} is {2}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
        }
    }
}
