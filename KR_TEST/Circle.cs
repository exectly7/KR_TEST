using System.Drawing;

namespace KR_TEST
{
    /// <summary>
    /// Класс окружность, содержит две точки - концы диаметра.
    /// Имеет радиус. Окружности можно сравнивать.
    /// </summary>
    public class Circle
    {
        private Point _point1;
        private Point _point2;
        private double _r;

        /// <summary>
        /// Конструктор окружности по 2 точкам.
        /// </summary>
        /// <param name="point1">Одна из концевых точек диаметра.</param>
        /// <param name="point2">Одна из концевых точек диаметра.</param>
        public Circle(Point point1, Point point2)
        {
            _point1 = point1;
            _point2 = point2;
        }

        private double R => Math.Sqrt(Math.Pow(_point2.X - _point1.X, 2) + Math.Pow(_point2.Y - _point1.Y, 2));

        public static bool operator < (Circle c1, Circle c2)
        {
            return Math.Round(c1.R, 3) < Math.Round(c2.R, 3);
        }
        
        public static bool operator > (Circle c1, Circle c2)
        {
            return Math.Round(c1.R, 3) > Math.Round(c2.R, 3);
        }

        public static bool operator ==(Circle c1, Circle c2)
        {
            return Math.Abs(c1.R - c2.R) < 0.001;
        }
        
        public static bool operator !=(Circle c1, Circle c2)
        {
            return Math.Abs(c1.R - c2.R) > 0.001;
        }
    }
}