using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = "aaaaassssssssssbbbbbbbbbbbbbbcccccccccccccccccddddddddddddddddddddddddddd";
            for (int i = str.Length-1; i>=0; i-- )
            {
                Console.Write(str[i]);
            }
        }

   
    }
}


