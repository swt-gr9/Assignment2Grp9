using System;

namespace Calculator
{

    public interface ICalculator
    {
       
    }
    public static class SHCalculator
    {
        /// <summary>
        /// Returnerer farten ud fra ændring i x og y koordinat og tiden imellem
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double GetCurrentSpeed(int deltaX, int deltaY, double time)
        {
            return (double)GetDistance(deltaX, deltaY) / time;
        }

        private static double GetDistance(int x, int y)
        {
            return Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2)));
        }

        public static double GetCurrentHeading(int deltaX, int deltaY)
        {
            var radius = GetDistance(deltaX, deltaY);
            var radian = Math.Asin(deltaX / radius);


            return radian * 180/Math.PI;
        }
    }
}
