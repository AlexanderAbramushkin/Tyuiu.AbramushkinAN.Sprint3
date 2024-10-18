using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AbramushkinAN.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                result *= ( (Math.Pow(value, i) + 1) * Math.Cos(4));
            }
            return Math.Round(result,3);
        }
    }
}
