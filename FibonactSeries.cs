using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int FibonactSeries(int index)
        {
            if (index == 0) return 0;
            if (index == 1) return 1;

            return FibonactSeries(index - 1) + FibonactSeries(index - 2);
        }
    }
}
