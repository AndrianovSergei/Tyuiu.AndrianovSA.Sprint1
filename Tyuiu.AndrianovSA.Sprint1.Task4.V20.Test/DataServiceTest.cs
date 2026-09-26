using Tyuiu.AndrianovSA.Sprint1.Task1.V20.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 2.0;

            // Расчет: (1 + 1) / |1 - sqrt(2 + 2)| = 2 / |1 - 2| = 2 / 1 = 2
            double res = ds.Calculate(x, y);

            Assert.AreEqual(2.0, res);
        }
    }
}