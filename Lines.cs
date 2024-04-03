namespace Lab4_1_
{
    public class Lines
    {

        int x1, y1, x2, y2;

        public Lines(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        int c = 0;
        

        public void Equation()
        {
            System.Console.WriteLine($"y = {K}x + {B}.");
        }

        private double X 
        {
            get { return x2 - x1; }

        }

        private double Y 
        {
            get { return y2 - y1; }
        }


        private double K //K и B элементы для уравнения прямой y=kx+b
        {
            get { return Y / X; }
            
        }

        private double B
        {
            get { return y1 - K * x1; }
        }

        public static bool operator ==(Lines AB, Lines CD)
        {
            
            return AB.K == CD.K;
        }

        public static bool operator !=(Lines AB, Lines CD)
        {
            return !(AB == CD);
        }

        public static double Angle(Lines AB, Lines CD)
        {
            double slopeDifference = CD.K - AB.K;
            double angle = System.Math.Atan(slopeDifference / (1 + AB.K * CD.K));
            return angle * (180 / System.Math.PI);
        }
       
    }
}
