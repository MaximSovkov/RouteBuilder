using System;
using System.Collections.Generic;
using System.Text;

namespace RouteBuilder
{
    /// <summary>
    /// Defines the entry point to the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        static void Main()
        {
            // Add support for the Russian language.
            Console.OutputEncoding = Console.InputEncoding = Encoding.GetEncoding("Cyrillic");

            var paths = new List<Path>();

            while (true)
            {
                Console.WriteLine("Пожалуйста, введите количество путей.");
                if (!int.TryParse(Console.ReadLine(), out var pathCount) || pathCount <= 0)
                {
                    Console.WriteLine("Введённое Вами число некорректно!");
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    for (var i = 0; i < pathCount; i++)
                    {
                        Console.Write(Environment.NewLine);
                        Console.WriteLine($"Путь номер {i + 1}.");

                        Console.Write("From: ");
                        var from = Console.ReadLine();

                        Console.Write("To: ");
                        var to = Console.ReadLine();

                        paths.Add(new Path
                        {
                            From = from,
                            To = to,
                        });
                    }

                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Исходные данные:");
                    paths.ForEach(path => Console.WriteLine(path.ToString()));

                    Console.Write(Environment.NewLine);
                    Console.WriteLine("Выходные данные:");

                    var result = new RouteBuilder().BuildRoute(paths);
                    Console.WriteLine(result);
                    Console.Write(Environment.NewLine);

                    paths.Clear();
                }
            }
        }
    }
}
