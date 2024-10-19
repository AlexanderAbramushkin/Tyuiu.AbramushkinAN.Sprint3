using Tyuiu.AbramushkinAN.Sprint3.Task3.V25.Lib;
namespace Tyuiu.AbramushkinAN.Sprint3.Task3.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string value = "kjhgfuu gujut dtuu";
            char item = 'u';

            Console.Title = "Спринт #3 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв u,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: kjhgfuu gujut dtuu           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Строка = {value}");
            Console.WriteLine($"Элемент = {item}");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Минимальне количество соседних элементов = {ds.GetMinCharCount(value, item)}");
        }
    }
}
