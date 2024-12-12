/*
 * Буров Иван.
 * Вариант 1.
 * БПИ249-1.
 */

using KR_TEST;
using System.Globalization;
using System.Transactions;

namespace KR_TEST_CONSOLE
{
    public static class Program
    {
        private static Circle InitializeDefaultCircle()
        {
            while (true)
            {
                try
                {
                    Console.Write("Точка x1:");
                    double x1 = double.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Точка y1:");
                    double y1 = double.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Точка x2:");
                    double x2 = double.Parse(Console.ReadLine() ?? string.Empty);
                    Console.Write("Точка y2:");
                    double y2 = double.Parse(Console.ReadLine() ?? string.Empty);
                    return new Circle(new Point(x1, y1), new Point(x2, y2));
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                }
            }
        }
        
        public static void Main()
        {
            Circle x = InitializeDefaultCircle();
            Console.WriteLine("Нажмите F чтобы прочитать данные из файла инпут тэхэтэ");
            if (Console.ReadKey().Key == ConsoleKey.F)
            {
                try
                {
                    string[] data = File.ReadAllLines("input.txt");
                    FromData(x, data);
                }
                catch (Exception)
                {
                    Console.WriteLine("Проблемы с файлом.");
                }
            }
            else
            {
                FromKeyboard(x);
            }
            
        }

        private static void FromData(Circle x, string[] data)
        {
            foreach (string line in data)
            {
                Circle y;
                string input = line;
                
                if (input == "0 0 0 0")
                {
                    break;
                }
                    
                try
                {
                    Console.WriteLine(input);
                    string[] points = input.Split(' ');
                    foreach (string point in points)
                    {
                        Console.WriteLine(point);
                    }
                    string[] coords1 = points[0][1..^1].Split(';');
                    string[] coords2 = points[1][1..^1].Split(';');
                    foreach (string coord in coords1)
                    {
                        Console.WriteLine(coord + 'x');
                    }
                    foreach (string coord in coords2)
                    {
                        Console.WriteLine(coord + 'x');
                    }
                    double x1 = double.Parse(coords1[0]);
                    double y1 = double.Parse(coords1[1]);
                    double x2 = double.Parse(coords2[0]);
                    double y2 = double.Parse(coords2[1]);
                    y = new Circle(new Point(x1, y1), new Point(x2, y2));
                    if (x > y)
                    {
                        Console.WriteLine("X больше Y");
                    }
                    else if (x == y)
                    {
                        Console.WriteLine("X равно Y");
                    }
                    else
                    {
                        Console.WriteLine("X меньше Y");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректные данные были пропущены");
                }
            }
        }

        private static void FromKeyboard(Circle x)
        {
            while (true)
            {
                Circle y;
                string input = Console.ReadLine() ?? string.Empty;
                
                if (input == "0 0 0 0")
                {
                    break;
                }
                    
                try
                {
                    string[] points = input.Split(' ');
                    double x1 = double.Parse(points[0]);
                    double y1 = double.Parse(points[1]);
                    double x2 = double.Parse(points[2]);
                    double y2 = double.Parse(points[3]);
                    y = new Circle(new Point(x1, y1), new Point(x2, y2));
                    if (x > y)
                    {
                        Console.WriteLine("X больше Y");
                    }
                    else if (x == y)
                    {
                        Console.WriteLine("X равно Y");
                    }
                    else
                    {
                        Console.WriteLine("X меньше Y");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                }
            }
        }
    }
}
