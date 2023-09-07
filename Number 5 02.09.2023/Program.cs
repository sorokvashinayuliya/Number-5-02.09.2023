using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_5_02._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задача 5. Решение квадратного уравнения*/
            Console.WriteLine("Введите коэффициенты");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double discriminant = (b * b) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Корней нет");
            }
            if (discriminant == 0)
            {
                double x=-b/(2*a);
                Console.WriteLine("Корень уравнения:" + x);

            }
            if (discriminant > 0)
            {
                double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("Первый корень уранения:"+x1);
                Console.WriteLine("Второй корень уравнения:" + x2);
            }
        }
    }
}
