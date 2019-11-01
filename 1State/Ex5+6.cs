using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result=0;
            char operation;

            while(true)
            {
                Console.Write("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите операцию:");
                operation = Convert.ToChar(Console.ReadLine());

                if(TestOperations(operation))
                {
                    Console.Write("Введите первое число:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Результат:" + Calculating(a, b, operation));
                }
                else
                {
                    Console.WriteLine("Ошибка: Неизвестная операцию!");
                }

                Console.WriteLine("Продолжить использование калькулятора? true/false");
                if(Convert.ToBoolean(Console.ReadLine()))
                {
                    break;
                }
            }
        }


        private static double Calculating(double x, double y, char operations)
        {
            double result;
            switch (operations)
            {
                case '+':
                    result = Addition(x, y);
                    break;
                case '-':
                    result = Division(x, y);
                    break;
                case '/':
                    if (y == 0)  return 0;
                    result = Substraction(x, y);
                    break;
                case '*':
                    result = Multiplication(x, y);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
            
        }

        private static bool TestOperations(char operations) //Проверяем операцию
        {
            switch (operations)
            {
                case '+':
                    return true;
                case '-':
                    return true;
                case '/':
                    return true;
                case '*':
                    return true;
                default:
                    return false;
            }
        }

        public static double Division(double x, double y)
        {
            return x / y;
        }

        public static double Addition(double x, double y)
        {
            return x + y;
        }

        public static double Substraction(double x, double y)
        {
            return x - y;
        }

        public static double Multiplication(double x, double y)
        {
            return x * y;
        }
    }
}
