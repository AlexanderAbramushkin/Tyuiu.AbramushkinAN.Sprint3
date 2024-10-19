using Tyuiu.AbramushkinAN.Sprint3.Task4.V7.Lib;

namespace Tyuiu.AbramushkinAN.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double wait = 1231.499;
            double res = ds.Calculate(startValue,stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}