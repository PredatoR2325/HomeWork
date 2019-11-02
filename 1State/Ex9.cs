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
            double[] border_size = new double[3]; //значение сторон

            Console.WriteLine("Введите значение точек:");
            for(int i=0; i<6; i+=2)
            {
                Console.Write("#"+i+"(x,y): ");
                point[i] = Convert.ToInt32(Console.ReadLine());
                point[i+1] = Convert.ToInt32(Console.ReadLine());
            }

            //Подсчет сторон
            border_size[0] = Math.Sqrt(Math.Pow(point[0] - point[2], 2) + Math.Pow(point[1] - point[3], 2));
            border_size[1] = Math.Sqrt(Math.Pow(point[2] - point[4], 2) + Math.Pow(point[3] - point[5], 2));
            border_size[2] = Math.Sqrt(Math.Pow(point[0] - point[4], 2) + Math.Pow(point[1] - point[5], 2));

            //*Классификация
            if(!(border_size[0]==border_size[1]&&border_size[1] == border_size[2]))
            {
                if(!(border_size[0] == Math.Sqrt(Math.Pow(border_size[1],2)+ Math.Pow(border_size[2], 2)) || border_size[1] == Math.Sqrt(Math.Pow(border_size[0], 2) + Math.Pow(border_size[2], 2)) || border_size[2] == Math.Sqrt(Math.Pow(border_size[1], 2) + Math.Pow(border_size[0], 2))))
                {
                    if(!((border_size[0]==border_size[1])||(border_size[2] == border_size[1])||(border_size[0] == border_size[2])))
                    {
                        Console.WriteLine("Треугольник");
                    }else
                    {
                        Console.WriteLine("Треугольник равнестаронный");
                    }
                }else
                {
                    Console.WriteLine("Треугольник прямой");
                }
            }else
            {
                Console.WriteLine("Треугольник правильный");
            }

        }
        private static void TypeOf4()
        {
            int[] point = new int[8]; //память на 4 точки (x,y)
            double[] border_size = new double[4]; //значение сторон

            Console.WriteLine("Введите значение точек:");
            for (int i = 0; i < 8; i += 2)
            {
                Console.Write("#" + i + "(x,y): ");
                point[i] = Convert.ToInt32(Console.ReadLine());
                point[i + 1] = Convert.ToInt32(Console.ReadLine());
            }

            //Подсчет сторон
            border_size[0] = Math.Sqrt(Math.Pow(point[0] - point[2], 2) + Math.Pow(point[1] - point[3], 2));
            border_size[1] = Math.Sqrt(Math.Pow(point[2] - point[4], 2) + Math.Pow(point[3] - point[5], 2));
            border_size[2] = Math.Sqrt(Math.Pow(point[4] - point[6], 2) + Math.Pow(point[5] - point[7], 2));
            border_size[3] = Math.Sqrt(Math.Pow(point[0] - point[6], 2) + Math.Pow(point[1] - point[7], 2));

            //Типизация
            if((border_size[0]==border_size[1] && border_size[2]==border_size[3])|| (border_size[2] == border_size[1] && border_size[0] == border_size[3])) //проверка равности старон
            {
                if((border_size[0]==border_size[1])&&(border_size[1]==border_size[2]))//проверка равности старон
                {
                    if(Math.Sqrt(Math.Pow(point[0] - point[4], 2) + Math.Pow(point[1] - point[5], 2)) == Math.Sqrt(Math.Pow(border_size[0],2)+Math.Pow(border_size[1],2)))
                    {
                        Console.WriteLine("Фигура: Квадрат");
                    }else
                    {
                        Console.WriteLine("Фигура: Ромб");
                    }
                }
                else
                {
                    Console.WriteLine("Фигура: прямоугольник");
                }
            }else
            {
                Console.WriteLine("Фигура: 4х угольник");
            }
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


