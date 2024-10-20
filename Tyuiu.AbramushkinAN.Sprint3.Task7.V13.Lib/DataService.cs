using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AbramushkinAN.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] ResultArray = new double[stopValue - startValue+1];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double ResofFunc = Math.Round(3*x+2 - (2*x-x)/(Math.Cos(x)+1),2);
                if (Math.Cos(x)+1 ==0)
                {
                    ResultArray[count] = 0;
                }
                else
                {
                    ResultArray[count] = ResofFunc;
                }
                count++;
            }
            return ResultArray;
        }
    }
}
