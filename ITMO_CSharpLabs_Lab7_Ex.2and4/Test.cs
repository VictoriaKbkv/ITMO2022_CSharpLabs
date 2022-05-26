using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Test
    {
        public static void Main()
        {

            int x=0;
            ulong y=0;
            string s="Test";

            bool check = Utils.IsItFormatable(x);
            Console.WriteLine("For intrger {0}", check);
            check = Utils.IsItFormatable(y);
            Console.WriteLine("For ulong {0}", check);
            check = Utils.IsItFormatable(s);
            Console.WriteLine("For string {0}", check);
        }
    }
}
