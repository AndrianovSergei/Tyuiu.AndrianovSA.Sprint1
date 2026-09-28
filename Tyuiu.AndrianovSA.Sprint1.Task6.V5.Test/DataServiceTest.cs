using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AndrianovSA.Sprint1.Task6.V5.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckSymmetricalWords()
        {
            DataService ds = new DataService();

            string str = "казак ехал на шалаш и встретил ротор";
            string res = ds.CheckSymmetricalWords(str);

            string wait = "казак шалаш ротор";
            Assert.AreEqual(wait, res);
        }
    }
}