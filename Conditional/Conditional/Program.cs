using System;
namespace Conditional
{
    class Conditional
    {
        static void Main(string[] args)
        {
            ///Use if,if else, else if

            int age = 17;
            if (age <= 0)
            {
                Console.WriteLine("Please give a valid Age");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are Apply for Smart Card");
            }
            else
            {
                Console.WriteLine("Your age is less than 18 and can't Apply for NID");
            }


            //Use more operators like (&&, || ) inside conditional operators

            Op();


            //Use ternary logical operators

            String name = "Naimur Rahman";
            Console.WriteLine((name == "Naimur Rahman") ? "Access Granted" : "Access denied");



            // Different types of comment
            // Single line comment
            /* Multi line 
              comment 
              This is Beautiful
             */
            
        }

        static void Op()
        {
            int x = 10;
            int y = 20;
            int z = 30;
            int num = 23;
            if (num > x && num < y)
            {
                Console.WriteLine("This Number is between 10 and 20");
            }
            else if(num > y && num < z)
            {
                Console.WriteLine("This number is between 10 and 30");
            }
            else if(num>z|| num < z)
            {
                if (num > z)
                {
                    Console.WriteLine("This number is greater than 30");
                }
                else 
                { 
                    Console.WriteLine("This number is less than 10");
                }
            }
        }
    }
}