using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1_
{
    public class Lines
    {
        int x1;
        int y1;
        int x2;
        int y2;


        public Lines(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public void Equation()
        {
            System.Console.WriteLine($"y = {K}x + {B}.");
        }

        private double K //K и B элементы для уравнения прямой y=kx+b
        {
            get { return (y2-y1) / (x2-x1); }
        }

        private double B
        {
            get { return y1 - K * x1; }
        }
        public static bool operator ==(Lines AB, Lines CD)
        {
            if (AB.y1 != AB.y2 && AB.x1 != AB.x2 && CD.y1 != CD.y2 && CD.x1 != CD.x2)
            {
                return AB.K == CD.K;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static bool operator !=(Lines AB, Lines CD)
        {
            if (AB.y1 != AB.y2 && AB.x1 != AB.x2 && CD.y1 != CD.y2 && CD.x1 != CD.x2)
            {
                return !(AB == CD);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public static double Angle(Lines AB, Lines CD)
        {
            double slopeDifference = CD.K - AB.K;
            double angle = System.Math.Atan(slopeDifference / (1 + AB.K * CD.K));
            return angle * (180 / System.Math.PI);
        }

    }
}

