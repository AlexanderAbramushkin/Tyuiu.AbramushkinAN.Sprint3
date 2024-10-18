using Tyuiu.AbramushkinAN.Sprint3.Task1.V6.Lib;
namespace Tyuiu.AbramushkinAN.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 4;
            int startValue = 1;
            int stopValue = 10;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -389102.25;
            Assert.AreEqual(wait, res);
        }
    }
}