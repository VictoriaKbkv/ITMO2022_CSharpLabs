using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDay
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }


    internal class WhatDay
    {


        static void Main(string[] args)
        {
            try
            {
                List<byte> DaysInMonths = new List<byte> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                List<byte> DaysInLeapMonths = new List<byte> { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string line;
                int yearNum;

                bool isLeapYear;
                int MonthNum = 0;

                Console.WriteLine("Enter the year");
                line = Console.ReadLine();
                yearNum = int.Parse(line);
                isLeapYear = ((yearNum % 4 == 0) && ((yearNum % 100 != 0) || (yearNum % 400 == 0)));

                int MaxDayNumber = isLeapYear ? 366 : 365;
                Console.WriteLine("Enter a day number between 1 and {0}", MaxDayNumber);
                line = Console.ReadLine();
                int dayNum = int.Parse(line);
                if (dayNum < 1 || dayNum > MaxDayNumber)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }


                if (isLeapYear)
                {

                    foreach (byte daysInMonths in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonths)
                        {
                            goto End;
                        }
                        else
                        {
                            dayNum = dayNum - daysInMonths;
                            MonthNum++;
                        }
                    }
                }
                else
                {
                    foreach (byte daysInMonths in DaysInMonths)
                    {
                        if (dayNum <= daysInMonths)
                        {
                            goto End;
                        }
                        else
                        {
                            dayNum = dayNum - daysInMonths;
                            MonthNum++;
                        }
                    }
                }

            End:

                MonthName temp = (MonthName)MonthNum;
                string monthName = temp.ToString();
                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
        }
    }
}

