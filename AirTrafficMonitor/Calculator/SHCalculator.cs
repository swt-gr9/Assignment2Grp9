using System;

namespace Calculator
{
    public static class SHCalculator
    {
        public static double GetCurrentSpeed(int x, int y, double time)
        {
            return (double)GetDistance(x, y) / time;
        }

        private static double GetDistance(int x, int y)
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        }

        public static int GetCurrentHeading(int x, int y)
        {
            
        }
    }
}
