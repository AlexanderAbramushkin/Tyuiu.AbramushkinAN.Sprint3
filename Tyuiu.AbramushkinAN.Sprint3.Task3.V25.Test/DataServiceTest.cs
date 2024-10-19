using Tyuiu.AbramushkinAN.Sprint3.Task3.V25.Lib;
namespace Tyuiu.AbramushkinAN.Sprint3.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMinCharCount()
        {
            DataService ds = new DataService();

            string value = "kjhgfuu gujut dtuu";
            char item = 'u';
            int result = ds.GetMinCharCount(value, item);
            int wait = 2;
            Assert.AreEqual(wait, result);

        }
    }
}