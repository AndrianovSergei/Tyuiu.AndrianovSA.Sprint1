using Tyuiu.AndrianovSA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Андрианов С. А. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Класс Convert                                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).    *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine($"* Расстояние между точками = {result}                                    *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}