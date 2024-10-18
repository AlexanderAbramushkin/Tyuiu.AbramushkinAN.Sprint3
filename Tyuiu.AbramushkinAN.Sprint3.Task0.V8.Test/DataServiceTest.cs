using System.ComponentModel;
using Tyuiu.AbramushkinAN.Sprint3.Task0.V8.Lib;
namespace Tyuiu.AbramushkinAN.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 10;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);2
            double wait = 0.01930371478769551;
            Assert.AreEqual(wait, res);


        }
    }
}