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
            int LenOfValue = endValue - startValue + 1;
            double[] WaitArray = new double[LenOfValue];

            WaitArray[0] = -6.9;
            WaitArray[1] = 9.55;
            WaitArray[2] = 298.78;
            WaitArray[3] = 3.43;
            WaitArray[4] = 1.65;
            WaitArray[5] = 2;
            WaitArray[6] = 2.35;
            WaitArray[7] = 0.57;
            WaitArray[8] = -294.78;
            WaitArray[9] = -5.55;
            WaitArray[10] = 3.10;

            double[] result = new double[LenOfValue];
            result = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(WaitArray, result);
        }
    }
}