using Tyuiu.AndrianovSA.Sprint1.Task2.V13.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ConvertMilesToKm()
        {
            int miles = 2;
            double result = ds.ConvertMilesToKm(miles);
            Assert.AreEqual(3.218, result);
        }
    }
}