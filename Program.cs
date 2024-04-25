using System;

namespace Lab4_1_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Lines AB = new Lines(1, 3, 3, 6);
            Lines CD = new Lines(2, 5, 4, 8);

            Console.WriteLine("Уровнение прямой AB:");
            AB.Equation();
            Console.WriteLine("Уровнение прямой CD:");
            CD.Equation();

            if (AB == CD )
            {
                Console.WriteLine($"Прямые AB и CD параллельны.");
            }
            else
            {
                Console.WriteLine("Прямые AB и CD не параллельны.");
                double angle = Lines.Angle(AB, CD);
                Console.WriteLine($"Угол между прямыми AB и CD: {angle} градусов.");
            }

        }
    }
}
