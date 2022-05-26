namespace Utils
{
    using System;

    public class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer)
        {
            int f;
            bool ok = true;
            if (n<0) ok = false;

            try
            {
                f = 1;
                for (int k = 2; k <= n; k++)
                {
                    f = f * k;
                }
            }

            catch (Exception) // All exceptions are handled the same way: set the result to zero and return false.
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }

}
