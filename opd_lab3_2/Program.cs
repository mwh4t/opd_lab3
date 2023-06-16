/*
Вариант 13.
По введённому номеру единицы измерения (1 - дециметр,
2 - километр, 3 - метр, 4 - миллиметр, 5 - сантиметр) и длине
отрезка L получить соответствующее значение длины отрезка в
метрах.
*/
using System;

namespace opd_lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Единицы измерения:");
            Console.WriteLine("1 - Дециметр");
            Console.WriteLine("2 - Километр");
            Console.WriteLine("3 - Метр");
            Console.WriteLine("4 - Миллиметр");
            Console.WriteLine("5 - Сантиметр");

            Console.Write("Выберите число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину: ");
            double dlina = Convert.ToDouble(Console.ReadLine());

            double dlinaVmetrah = 0;

            switch (chislo)
            {
                case 1: // Дециметры в метры
                    dlinaVmetrah = dlina / 10;
                    break;
                case 2: // Километры в метры
                    dlinaVmetrah = dlina * 1000;
                    break;
                case 3: // Метры
                    dlinaVmetrah = dlina;
                    break;
                case 4: // Миллиметры в метры
                    dlinaVmetrah = dlina / 1000;
                    break;
                case 5: // Сантиметры в метры
                    dlinaVmetrah = dlina / 100;
                    break;
                default:
                    Console.WriteLine("Что-то пошло не так :(");
                    return;
            }

            Console.WriteLine($"Длина в метрах: {dlinaVmetrah} м");
            Console.ReadKey();
        }
    }
}