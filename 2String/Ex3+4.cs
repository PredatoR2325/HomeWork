using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string str;
            string[] arrayOfString;

            Console.WriteLine("Write to string");
            str = Console.ReadLine();

            arrayOfString = str.Split(" ");

            for(int i=arrayOfString.Length-1; i>=0; i--)
            {
                Console.Write(arrayOfString[i]+" ");
            }
        }
    }
}


