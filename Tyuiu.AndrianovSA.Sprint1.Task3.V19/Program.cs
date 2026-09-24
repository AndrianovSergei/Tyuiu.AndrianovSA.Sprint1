using Tyuiu.AndrianovSA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Андрианов С. А. | ИИПб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая печатает true или false в зависимости от     *");
            Console.WriteLine("* того, может ли шахматная фигура «Слон» с одного заданного поля          *");
            Console.WriteLine("* шахматной доски перейти за один ход на другое.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату x1 (1-8): ");
            int x1 = int.Parse(Console.ReadLine()!);

            Console.Write("Введите координату y1 (1-8): ");
            int y1 = int.Parse(Console.ReadLine()!);

            Console.Write("Введите координату x2 (1-8): ");
            int x2 = int.Parse(Console.ReadLine()!);

            Console.Write("Введите координату y2 (1-8): ");
            int y2 = int.Parse(Console.ReadLine()!);

            bool result = ds.ElephCanMove(x1, y1, x2, y2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine($"* Слон может совершить ход: {result}                                      *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}