using System;

namespace Lab4_1_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point A = new Point(1, 3);
            Point B = new Point(3, 6);
            Point C = new Point(2, 5);
            Point D = new Point(4, 8);

            if (B.y != A.y && B.x != A.x && C.y != D.y && C.x != D.x)
            {
                double K1 = (B.y - A.y) / (B.x - A.x);
                double K2 = (D.y - C.y) / (D.x - C.x);
                double B1 = (A.y - K1 * A.x);
                double B2 = (C.y - K2 * C.x);
                Console.WriteLine($"Уравнение прямой AB: y = {K1}x + {B1}.");
                Console.WriteLine($"Уравнение прямой СВ: y = {K2}x + {B2}.");
                if(K1==K2)
                {
                    Console.WriteLine($"Прямые AB и CD параллельны.");
                }
                else
                {
                    double angle = Math.Atan(K2 - K1 / (1 + K1 * K2)) * (180 / Math.PI);
                    Console.WriteLine($"Угол между прямыми AB и CD: {angle} градусов.");
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
