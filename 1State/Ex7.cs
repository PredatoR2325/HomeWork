using System;

namespace ConsoleApp1
{
    class Program
    {
        static char[] ENG_Alfavit = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
        'A','B','C','D','E','F','G','H','I','G','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        static char[] RU_Alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я',
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };
        static void Main(string[] args)
        {
            double registr;
            string text;
            char[] text2;

            Console.WriteLine("Введите текст");
            text = Console.ReadLine();
            text2 = text.ToCharArray();

            Console.WriteLine("Введите значение регистра");
            registr = Convert.ToInt32(Console.ReadLine());//преобразуем в целочисельное значение
            registr = Math.Sqrt(Math.Pow(registr, 2));//убираем отрицательный регистр

            Console.WriteLine("Выберите язык ввода информации! [ENG/RU] true/false");
            if (Convert.ToBoolean(Console.Read()))
            {
                for(int i = 0; i < text.Length; i++)
                {
                    for(int j=0; j<ENG_Alfavit.Length; j++)
                    {
                        if(text[i]==ENG_Alfavit[j])
                        {

                            text2[i] = ENG_Alfavit[j + Convert.ToInt32(registr % ENG_Alfavit.Length)];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < text.Length; i++)
                {
                    for (int j = 0; j < RU_Alfavit.Length; j++)
                    {
                        if (text[i] == RU_Alfavit[j])
                        {

                            text2[i] = RU_Alfavit[j + Convert.ToInt32(registr % RU_Alfavit.Length)];
                        }
                    }
                }
            }

            for(int i=0; i<text2.Length; i++)
            {
                Console.Write(text2[i]);
            }

        }
    }
}
