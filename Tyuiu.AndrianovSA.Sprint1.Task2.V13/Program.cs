using Tyuiu.AndrianovSA.Sprint1.Task2.V13.Lib;

//ЗАДАНИЕ
//Известно расстояние в милях. Вычислить расстояние в километрах. Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.AndrianovSA.Sprint1.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Андрианов С. А. | ИИПб-26-1";

            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #2                                                                *");
            Console.WriteLine("* Вариант #13                                                               *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Известно расстояние в милях. Вычислить расстояние в километрах.             *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                               *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите расстояние в милях: ");
            int miles = int.Parse(Console.ReadLine()!);

            double result = ds.ConvertMilesToKm(miles);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine($"* Расстояние = {miles} миль");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine($"* Расстояние в километрах = {result}");
            Console.WriteLine("***************************************************************************");
        }
    }
}