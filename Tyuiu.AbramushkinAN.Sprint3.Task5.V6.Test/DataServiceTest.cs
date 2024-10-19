using Tyuiu.AbramushkinAN.Sprint3.Task5.V6.Lib;
namespace Tyuiu.AbramushkinAN.Sprint3.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            
            double result = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            double wait = 40.917;

            Assert.AreEqual(wait, result);

        }
    }
}