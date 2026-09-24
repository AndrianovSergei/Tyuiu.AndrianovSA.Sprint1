using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndrianovSA.Sprint1.Task2.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMetreToInchs(int meters)
        {
            double inches = meters * 39.3701;
            return Math.Round(inches, 3, MidpointRounding.AwayFromZero);
        }

        public double ConvertMilesToKm(int value)
        {
            //1 миля = 1.609 км (или 1.60934 км)
            double km = value * 1.609;
            return Math.Round(km, 3);
        }
    }
}