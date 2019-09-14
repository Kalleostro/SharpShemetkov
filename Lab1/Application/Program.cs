using System;
using FigureLib;
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure trap = new Figure();

            Console.WriteLine("Меню: ");
            Console.WriteLine("1. Ввести координаты фигуры");
            Console.WriteLine("2. Проверка существования заданной фигуры");
            Console.WriteLine("3. Найти приближенные длины сторон, площади и периметра фигуры");
            Console.WriteLine("4. Проверка принадлежности точки (х,у)");
            Console.WriteLine("5. Очистка буфера");
            Console.WriteLine("6. Выход");
        }
    }
}
