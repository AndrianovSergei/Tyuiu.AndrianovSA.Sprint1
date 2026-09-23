using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AndrianovSA.Sprint1.Task1.V23.Lib
{
    public class DataService : ISprint1Task1V23
    {
        public double Calculate(double a, double x)
        {
            return Math.Round((x * Math.PI) / (2 * a), 2);
        }
    }
}
