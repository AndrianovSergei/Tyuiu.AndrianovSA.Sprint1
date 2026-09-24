using Tyuiu.AndrianovSA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x1 = 1;
            int y1 = 1;
            int x2 = 4;
            int y2 = 4;

            bool res = ds.ElephCanMove(x1, y1, x2, y2);

            Assert.AreEqual(true, res);
        }
    }
}