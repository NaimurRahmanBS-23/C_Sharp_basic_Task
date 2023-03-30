using System;
namespace OverflowDetect
{
    class OverflowDetect
    {
        static void Main(string[] args)
        {
            Overflow();
        }

        static void Overflow()
        {
            checked
            {
                long number = long.MaxValue;
               Console.WriteLine(number+1);
            }
        }
    }
}

