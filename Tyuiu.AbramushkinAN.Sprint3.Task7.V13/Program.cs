using Tyuiu.AbramushkinAN.Sprint3.Task7.V13.Lib;

namespace Tyuiu.AbramushkinAN.Sprint3.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;

            Console.Title = "Спринт #3 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*                                       2x-x                              *");
            Console.WriteLine("*                    F(x) = 3*x + 2 - --------                            *");
            Console.WriteLine("*                                     cos(x)+1                            *"); 
            Console.WriteLine("* f(x) на заданном диапазон [-5; 5] с шагом 1. Произвести проверку        *");
            Console.WriteLine("* деления на ноль. При делении на ноль вернуть значение 0.                *");
            Console.WriteLine("* Значения занести в массив. Значения округлить до двух знаков после      *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {endValue}");

            int len = ds.GetMassFunction(startValue, endValue).Length;

            double[] ResultofArray = new double[len];
            ResultofArray = ds.GetMassFunction(startValue, endValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("+    X      +    f(x)   +");
            Console.WriteLine("+-----------+-----------+");

            for (int i = 0; i<=len-1; i++)
            {
                Console.WriteLine("|{0,5:d}      |   {1,6:f2}  |", startValue, ResultofArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+-----------+");
        }
    }
}
