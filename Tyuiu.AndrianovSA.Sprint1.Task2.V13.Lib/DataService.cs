using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AndrianovSA.Sprint1.Task2.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMilesToKm(int value)
        {
            return Math.Round(value * 1.609344, 3);
        }
    }
}