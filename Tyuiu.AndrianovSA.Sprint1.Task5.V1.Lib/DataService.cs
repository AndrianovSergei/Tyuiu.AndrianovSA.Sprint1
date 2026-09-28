using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndrianovSA.Sprint1.Task4.V1.Lib
{
    public class DataService : ISprint1Task5V1
    {
        public int DistanceBetweenDots(double x1, double y1, double x2, double y2)
        {
            double distance = System.Math.Sqrt(System.Math.Pow(x2 - x1, 2) + System.Math.Pow(y2 - y1, 2));
            return Convert.ToInt32(distance);
        }
    }
}