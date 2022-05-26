namespace Utils
{
    using System;

    public class Utils
    {
        public static void Reverse(ref string s)
        {
            string sRev = "";
            for (int count = s.Length - 1; count>=0; count--)
            {
                sRev = sRev + s[count];
            }
            s = sRev;
        }

        public static bool IsItFormatable(object x)
        {
            if (x is IFormattable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}