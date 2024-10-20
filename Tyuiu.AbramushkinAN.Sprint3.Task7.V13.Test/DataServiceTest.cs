using System.ComponentModel.DataAnnotations;
using Tyuiu.AbramushkinAN.Sprint3.Task7.V13.Lib;

namespace Tyuiu.AbramushkinAN.Sprint3.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;
            int LenOfValue = endValue - startValue+1;
            double[] WaitArray = new double[LenOfValue];

            WaitArray[0] = -9.1;
            WaitArray[1] = 1.55;
            WaitArray[2] = 292.78;
            WaitArray[3] = -0.57;
            WaitArray[4] = -0.35;
            WaitArray[5] = 2;
            WaitArray[6] = 4.35;
            WaitArray[7] = 4.57;
            WaitArray[8] = -288.78;
            WaitArray[9] = 2.45;
            WaitArray[10] = 13.1;

            double[] result = new double[LenOfValue];
            result = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(WaitArray, result);
        }
    }
}