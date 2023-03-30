using System;
namespace Opetator
{
    class Operator
    {
        static void Main(string[] args)
        {
            OperatorExample();
        }

        static void OperatorExample()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("A = "+a +" B = "+ b);
            Console.WriteLine("Sum of A + B = "+ (a + b));
            Console.WriteLine("Subtraction of A - B = "+(a-b));
            Console.WriteLine("Multiplication of A * B = "+ (a*b));
            Console.WriteLine("Division  of A / B = " + (a / b));
            Console.WriteLine("Modilo  of A % B = " + (a % b));
            Console.WriteLine("Bitwise OR of A | B = "+ (a|b));
            Console.WriteLine("Bitwise XOR of A ^ B = " + (a ^ b));
            Console.WriteLine("Bitwise AND of A & B = " + (a & b));

        }
    }

}