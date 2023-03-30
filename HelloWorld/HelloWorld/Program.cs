// See https://aka.ms/new-console-template for more information
using System;

 namespace Program{
    class program
    {
        static void Main(string[] args)
        {
            Hello();
            Datatypes();
            OverflowCheck();

        }
        static void Hello()
        {
            Console.WriteLine("Hello world! This is Naimur Rahman");
        } 
      static  void Datatypes()
        {
            char ch = 'N';
            string name = "Md. Naimur Rahman";
            int age = 24;
            long salary = 10000000000L;
            float height = 164.3F;
            double weight = 62.4;
            Console.WriteLine("This is my favourite Character " + ch);
            Console.WriteLine("This is my Full name " + name);
            Console.WriteLine("This is my Age " + age);
            Console.WriteLine("This is my salary in long data type " + salary);
            Console.WriteLine("This is my height " + height);
            Console.WriteLine("This is my weight " + weight);
        }

       /* static void OverflowCheck()
        {
            checked
            {
                 int num=int.MaxValue;
                 Console.WriteLine(num + 2);
            }

        }*/
    }
}
