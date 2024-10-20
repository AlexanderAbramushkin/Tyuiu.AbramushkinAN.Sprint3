using Tyuiu.AbramushkinAN.Sprint3.Task6.V25.Lib;

namespace Tyuiu.AbramushkinAN.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 16;
            int endValue = 24;

            int wait = 89;
            int result = ds.GetSumTheDivisors(startValue, endValue);
            Assert.AreEqual(wait,result);
        }
    }
}