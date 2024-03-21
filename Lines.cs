namespace Lab4_1_
{
    public class Lines
    {
        int xa;
        int ya;
        int xb;
        int yb;
        int xc;
        int yc;
        int xd;
        int yd;
        public Lines(int xa, int ya, int xb, int yb, int xc, int yc, int xd, int yd)
        {
            this.xa = xa;
            this.ya = ya;
            this.xb = xb;
            this.yb = yb;
            this.xc = xc;
            this.yc = yc;
            this.xd = xd;
            this.yd = yd;

            System.Console.WriteLine($"Уровнение прямой AB:y-{ya}/{yb}-{ya}=x-{xa}/{xb}-{xa}");
            System.Console.WriteLine($"Уровнение прямой AB:y-{yc}/{yd}-{yc}=x-{xc}/{xd}-{xc}");

            bool parallel = Parallel(xa, ya, xb, yb, xc, yc, xd, yd);
            if (parallel == true)
            {
                System.Console.WriteLine($"Прямые AB и CD параллельны");
            }
            else
            {
                System.Console.WriteLine($"Прямые AB и CD не параллельны");

                double angle = CalculateAngle(xa, ya, xb, yb, xc, yc, xd, yd);
                System.Console.WriteLine($"Угол между прямыми AB и CD: {angle} градусов.");
            }
        }

        static bool Parallel(int xa, int ya, int xb, int yb, int xc, int yc, int xd, int yd)
        {
            if (xb - xa == 0 && xd - xc == 0 && yb - ya == yd - yc || yb - ya == 0 && yd - yc == 0 && xb - xa == xd - xc || ((yb - ya) / (xb - xa)) - ((yd - yc) / (xd - xc)) is 0)
            { return true; }
            if (xb - xa is 0 && xd - xc != 0 || xb - xa != 0 && xd - xc is 0 || yb - ya is 0 && yd - yc != 0 || yb - ya != 0 && yd - yc is 0)
            { return false; }
            else { return false; }

        }

        static double CalculateAngle(int xa, int ya, int xb, int yb, int xc, int yc, int xd, int yd)
        {
            double angle1 = System.Math.Atan2(yb - ya, xb - xa) * 180 / System.Math.PI;
            double angle2 = System.Math.Atan2(yd - yc, xd - xc) * 180 / System.Math.PI;

            double angle = angle1 - angle2;
            if (angle > 180)
            {
                angle = 360 - angle;
            }
            return angle;
        }
    }
}