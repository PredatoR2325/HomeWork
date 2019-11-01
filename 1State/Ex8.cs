using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int a=0, b=1, value;
            Console.WriteLine("Введите номер ч-ла фибаначи:");
            value = Convert.ToInt32(Console.ReadLine());
            while(value <=0)
            {
                Console.WriteLine("ОШИБКА, число должно быть больше 0: ");
                value = Convert.ToInt32(Console.ReadLine());
            }

            while(value !=0)
            {
                a = a + b;
                b = a - b;
                value--;
                if(value==0)Console.WriteLine(a + " ");
            }
        }
        static int Fibanachi(int i)
        {
            //Console.WriteLine(i);
            if (i < 1) return 0;
            if (i == 1) return 1;
            return Fibanachi(i - 1) + Fibanachi(i - 2);

        }
    }
}


