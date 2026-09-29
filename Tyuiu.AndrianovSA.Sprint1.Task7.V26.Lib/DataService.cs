using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndrianovSA.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double firstPart = (Math.Sin(x * x) + y) / (y + 1);
            double secondPart = (x * y - 12) / (34 + x * x);

            double res = firstPart - secondPart;
            return Math.Round(res, 3);
        }
    }
}