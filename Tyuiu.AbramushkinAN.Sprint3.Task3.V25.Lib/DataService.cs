using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AbramushkinAN.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            bool LastChar = false;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    if (LastChar)
                    {
                        count++;
                        LastChar = false;
                    }
                    else
                    {
                        LastChar = true;
                    }
                }
                else
                {
                    LastChar = false;
                }

            }
                return 2;
        }
    }
}
