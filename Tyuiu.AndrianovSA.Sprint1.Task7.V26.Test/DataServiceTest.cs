using Tyuiu.AndrianovSA.Sprint1.Task7.V26.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            double wait = 1.233;
            Assert.AreEqual(wait, res);
        }
    }
}