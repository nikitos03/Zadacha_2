using System;

namespace ЕНГ_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для выбора действия: ");

            string text = Console.ReadLine();
            while (!text.Contains("exit"))
            {
                if (text != "exit")
                {
                    Console.Write("Введите количество повторов сообщения: ");
                    int povtor = int.Parse(Console.ReadLine());
                    for (int i = 0; i < povtor; i++)
                    {
                        Console.WriteLine(text);
                    }
                    Console.WriteLine("Повторить операцию или exit для выхода");
                    text = Console.ReadLine();
                }
            }
        }
    }
}
