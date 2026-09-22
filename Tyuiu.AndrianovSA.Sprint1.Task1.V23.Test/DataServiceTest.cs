using Tyuiu.AndrianovSA.Sprint1.Task1.V23.Lib;
namespace Tyuiu.AndrianovSA.Sprint1.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 2.0;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(-1, res);
        }
    }
}
