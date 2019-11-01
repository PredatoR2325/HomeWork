using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            if(ShowMenu())
            {
                TypeOf3();
            }else
            {
                TypeOf4();
            }

        }

        private static void TypeOf3()
        {
            int[] point = new int[6]; //память на 3 точки (x,y)
            Console.WriteLine("Введите значение точек:");
            for(int i=0; i<6; i+=2)
            {
                Console.Write("#"+i+"(x,y): ");
                point[i] = Convert.ToInt32(Console.ReadLine());
                point[i+1] = Convert.ToInt32(Console.ReadLine());
            }

            //* Тут будет класификация
        }
        private static void TypeOf4()
        {

        }


        private static bool ShowMenu()
        {
            int number = 0;

            Console.WriteLine("$1m0n: Сдраствуйте, вас приветствует робот Саймон ");
            Console.WriteLine("$1m0n: Из випадающего меню выберете интересующую вас тематику ");
            Console.WriteLine("1. треугольник");
            Console.WriteLine("2. четырёх угольник");

            do
            {
                if (number != 0) Console.WriteLine("$1m0n: Введени неверные данные! Попробуйде ещё раз");
                number = Convert.ToInt32(Console.ReadLine());
            } while ((number != 2) && (number != 1));

            Console.WriteLine("Success");

            if (number == 1)
            {
                return true;
            } else { 
                return false; 
            }
        }
    }
}


