using Tyuiu.AbramushkinAN.Sprint3.Task5.V6.Lib;

namespace Tyuiu.AbramushkinAN.Sprint3.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.Title = "Спринт #3 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  3   10     1                                                           *");
            Console.WriteLine("*  Σ   Σ    ----- + 2                                                     *");
            Console.WriteLine("* i=1 k=1   cos(k)                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine($"Старт шага первой суммы ряда= {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда= {stopValue1}");
            Console.WriteLine($"Старт шага второй суммы ряда= {startValue2}");
            Console.WriteLine($"Конец шага второй суммы ряда= {stopValue2}");
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Минимальне количество соседних элементов = {ds.GetSumSumSeries(startValue1,startValue2,stopValue1,stopValue2)}");
        }
    }
    
}
