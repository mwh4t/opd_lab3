/*
Вариант 13.
Даны действительные числа X, Y, Z. Если сумма чисел меньше 1, то 
наименьшее из них заменить суммой квадратов двух других. В противном 
случае значения X, Y, Z заменить полусуммой двух других.
*/
using System;

namespace opd_lab_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 действительных числа:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            double sum = x + y + z;
            double min = Math.Min(Math.Min(x, y), z);

            double halfX = (y + z) / 2;
            double halfY = (x + z) / 2;
            double halfZ = (x + y) / 2;

            if (sum < 1)
            {
                x = (min == x) ? y * y + z * z : x;
                y = (min == y) ? x * x + z * z : y;
                z = (min == z) ? x * x + y * y : z;
            }
            else
            {
                x = halfX;
                y = halfY;
                z = halfZ;
            }

            Console.WriteLine($"Обновлённые числа: X = {x}, Y = {y}, Z = {z}");
            Console.ReadKey();
        }
    }
}