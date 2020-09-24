using System;
using System.Runtime.CompilerServices;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            char teken = Convert.ToChar(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Berekening(x, y, teken));
        }

        static int Berekening(int x, int y, char teken)
        {
            int uitkomst = 0;
            
            if (teken == '*')
            {
                uitkomst = x * y;
            }
            else if (teken == '/')
            {
                uitkomst = x / y;
            }
            else if (teken == '+')
            {
                uitkomst = x + y;
            }
            else if (teken == '-')
            {
                uitkomst = x - y;
            }

            return uitkomst;
        }
    }
}
