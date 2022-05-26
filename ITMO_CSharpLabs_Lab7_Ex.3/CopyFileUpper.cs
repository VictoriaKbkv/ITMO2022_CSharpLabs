using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_CSharpLabs_Lab7_Ex._3
{
    internal class CopyFileUpper
    {
        static void Main(string[] args)
        {
            string sFrom;
            string sTo;
            Console.WriteLine("Copy from:");
            sFrom = Console.ReadLine();
            Console.WriteLine("Copy to:");
            sTo = Console.ReadLine();

            try
            {
                StreamReader srFrom = new StreamReader(sFrom);
                StreamWriter swTo = new StreamWriter(sTo);

                while (srFrom.Peek() != -1)
                {
                    string SBuffer = srFrom.ReadLine();
                    SBuffer = SBuffer.ToUpper();
                    swTo.WriteLine(SBuffer);
                }

                srFrom.Close();
                swTo.Close();
            }
            catch (FileNotFoundException)
            { 
                Console.WriteLine("File to read from not found"); 
            }
           
        }
    }
}
