using System;
namespace TypeConvert
{
    class TypeConvert
    {
        static void Main(string[] args)
        {
            DataConvert();
        }

        static void DataConvert()
        {
            // String to Int
            string s = "1211123";
            int result;
           // Console.WriteLine(result);
            if(Int32.TryParse(s,out result))
            {
                Console.WriteLine("String to Int = "+result);
            }
            else
            {
                Console.WriteLine("Something is not ok in input string");
            }
            string newString = result.ToString();
            Console.WriteLine("Int to String = "+newString);


            /// String TO Double
            string ss = "12.21837139874923";
            double res= Convert.ToDouble(ss);
            Console.WriteLine("String to Double = "+res);
            string stringToDouble = Convert.ToString(res);
            Console.WriteLine("Doubel to String = "+stringToDouble);


            // String to LOng- long int
            string ns = "1234567844291111";
            long SToD=Convert.ToInt64(ns);
            Console.WriteLine("String to Double = "+SToD);
            Console.WriteLine("Double to String = " + Convert.ToString(SToD));

            // String TO Float
            string floats = "123.121";
            float sTof=Convert.ToSingle(floats);
            Console.WriteLine("String to Float = " + sTof);
            Console.WriteLine("Float to String = "+Convert.ToString(sTof));

            // String to Bool
            String stringForBool = "True";
            bool b = Convert.ToBoolean(stringForBool);
            Console.WriteLine("String to BOOL = "+b);
            Console.WriteLine("Boolean to String = "+Convert.ToString(b));

            // Int to LOng
            Console.WriteLine("Int to LOng = " + Convert.ToInt64(result));
            Console.WriteLine("Long To Int = " + (int)(SToD));

            // Char to ASCI
            char c = 'A';
            Console.WriteLine("Char to Asci = "+Convert.ToInt32(c));
            Console.WriteLine("ASCI to Char = "+ Convert.ToChar(65));
        }
    }
}
