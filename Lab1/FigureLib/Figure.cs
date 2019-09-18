using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace FigureLib
{
    /// <summary>
    /// Область фигуры
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Левая граница
        /// </summary>
        public float A { get; set; }
        /// <summary>
        /// Правая граница
        /// </summary>
        public float B { get; set; }
        /// <summary>
        ///существование фигуры 
        /// </summary>
      
        public bool IsExists()
        {
            if (A != B && (int)(A / PI) == (int)(B / PI))
                return true;
            else return false;
        }
        /// <summary>
        /// приндлежность точки
        /// </summary>
        public bool Contains(float x, float y)
        {
            if (Max(A, B) < x || Min(A, B) > x || x == 0)
                return false;
            var pr = x / PI;
            var xl = pr - Truncate(pr);
            if (Abs(xl) < 0.0001)
                return false;
            if (xl > PI / 2)
            {
                if (y > 1 / Tan(x))
                    return false;
            }
            else
            {
                if (y < 1 / Tan(x))
                    return false;
            }
            return true;
        }
        /// <summary>
        /// принадлежность точки границе
        /// </summary>
        public bool OnBorder(float x, float y)
        {
            if (Max(A, B) < x || Min(A, B) > x)
                return false;
            if (y == 0)
                return true;
            if (Abs(y - 1 / Tan(x)) < 0.0001)
                return true;
            var pr = x / PI;
            var xl = pr - Truncate(pr);
            if (Abs(x - A) < 0.0001 || Abs(x - B) < 0.0001)
                if (xl > PI / 2 && y < 0 && y > 1 / Tan(x) || xl < PI / 2 && y > 0 && y < 1 / Tan(x))
                    return true;
            return false;

        }
        /// <summary>
        /// площадь
        /// </summary>
        public double Square()
        {
            return Abs(Log(Abs(Sin(B))) - Log(Abs(Sin(A))));
        }
        /// <summary>
        /// правая сторона
        /// </summary>
        /// <returns>длина</returns>
        public double Left() => Math.Abs(1 / Tan(A));
        /// <summary>
        /// левая сторона
        /// </summary>
        /// <returns>длина</returns>
        public double Right() => Math.Abs(1 / Tan(B));
        /// <summary>
        /// основание
        /// </summary>
        /// <returns>длина</returns>
        public double Base() => Abs(B - A);
        /// <summary>
        /// верх
        /// </summary>
        /// <returns>длина</returns>
        public double Top()
        {
            var sb = Sin(B);
            var sa = Sin(A);
            return Abs(Sqrt(1 / (sb * sb * sb * sb) + 1) - Sqrt(1 / (sa * sa * sa * sa) + 1));
        }
        /// <summary>
        /// периметр
        /// </summary>
        /// <returns>длина</returns>
        public double Perimeter()
        {
            return Base() + Left() + Right() + Top();
        }
    }
}
