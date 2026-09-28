using Tyuiu.AndrianovSA.Sprint1.Task6.V5.Lib;

namespace Tyuiu.AndrianovSA.Sprint1.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Андрианов С. А. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками в C#                                           *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Андрианов Сергей Александрович  | ИИПб-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова,     *");
            Console.WriteLine("* которые являются симметричными (например: казак, шалаш).                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.CheckSymmetricalWords(value);

            if (string.IsNullOrEmpty(res))
            {
                Console.WriteLine("Симметричных слов в тексте не найдено.");
            }
            else
            {
                Console.WriteLine("Симметричные слова:");
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
    }
}