using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbramushkinAN.Sprint3.Task5.V6.Lib
{
    public class DataService : ISprint3Task5V6
    {
        public double GetSumSumSeries(int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;

            for (int i = 1; i <= stopValue1; i++)
            {
                for (int k = 1; k <= stopValue2; k++)
                {
                    res += ((1 / Math.Cos(k)) + 2);
                }
            }
            return Math.Round(res,3);
        }
    }
}
