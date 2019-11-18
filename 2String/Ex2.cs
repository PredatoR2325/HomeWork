using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string str;
            string find;

            Console.WriteLine("Write to string");
            str = Console.ReadLine();

            Console.WriteLine("Write to string who you want search");
            find = Console.ReadLine();

            if(str.Contains(find))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("No found");
            }
        }
    }
}


