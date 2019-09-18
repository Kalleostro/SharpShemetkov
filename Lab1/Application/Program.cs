using System;
using FigureLib;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure trap = new Figure();
            int k = 0, flag = 0;
            float a, b;
            while (k != 5)
            {
                Console.Clear();
                Console.WriteLine("Меню: ");
                Console.WriteLine("1. Ввести координаты фигуры");
                Console.WriteLine("2. Проверка существования заданной фигуры");
                Console.WriteLine("3. Найти приближенные длины сторон, площади и периметра фигуры");
                Console.WriteLine("4. Проверка принадлежности точки (х,у)");
                Console.WriteLine("5. Выход");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.WriteLine("Введите начало интервала");
                        trap.A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите конец интервала");
                        trap.B = Convert.ToInt32(Console.ReadLine());
                        flag = 1;
                       break;
                    case 2:
                        if (flag != 0)
                        {
                            if (trap.IsExists())
                                Console.WriteLine("Фигура существует");
                            else Console.WriteLine("Вы не ввели координаты либо фигура не существует");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        if (trap.IsExists())
                        {
                            float P = 0;
                            float S = 0;
                            Console.WriteLine("S = " + trap.Square());
                            Console.WriteLine("P = " + trap.Perimeter());
                            Console.WriteLine("Top = " + trap.Top());
                            Console.WriteLine("Base = " + trap.Base());
                            Console.WriteLine("Left = " + trap.Left());
                            Console.WriteLine("Right = " + trap.Right());
                        }
                        else Console.WriteLine("Фигура не существует");
                        Console.ReadKey();
                        break;
                    case 4:
                        if (trap.IsExists())
                        {
                            Console.WriteLine("Введите x-координату точки");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите у-координату точки");
                            b = Convert.ToInt32(Console.ReadLine());
                            int key = 0;
                            Console.WriteLine("Выберите расположение точки: 1 - на границе / 2 - внутри фигуры");
                            key = Convert.ToInt32(Console.ReadLine());
                            if (key == 1)
                                if (trap.OnBorder(a, b))
                                    Console.WriteLine("Точка находится на границе фигуры");
                                else
                                    Console.WriteLine("Точка не находится на границе фигуры");
                            else if (key == 2)
                                if (trap.Contains(a, b))
                                    Console.WriteLine("Точка находится внутри фигуры");
                                else
                                    Console.WriteLine("Точка не находится внутри фигуры");
                            else Console.WriteLine("Ошибка ввода ключа, значение может быть только 1 или 2");
                        }
                        else Console.WriteLine("Фигура не существует");
                        Console.ReadKey();
                        break;
                }
                   
            }
        }
    }
}
