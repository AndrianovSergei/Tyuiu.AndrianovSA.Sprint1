using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndrianovSA.Sprint1.Task1.V20.Lib
{
    public class DataService : ISprint1Task1V20
    {
        public double Calculate(double x, double y)
        {
            double numerator = 1 + x;
            double denominator = Math.Abs(x - Math.Sqrt(2 + y));
            return Math.Round(numerator / denominator, 3);
        }
    }
}