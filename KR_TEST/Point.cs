namespace KR_TEST
{
    /// <summary>
    /// Класс точка на плоскости.
    /// Имеет две координаты по x и y, на которые наложены ограничения.
    /// </summary>
    public class Point
    {
        private double _x;
        private double _y;

        /// <summary>
        /// Конструктор класса точка по координатам.
        /// </summary>
        /// <param name="x">Задает координату X.</param>
        /// <param name="y">Задает координату Y.</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        /// <summary>
        /// Свойства доступа к X, для наложения ограничений на координаты.
        /// </summary>
        /// <exception cref="Exception">Выкидывается при некорректном вводе.</exception>
        public double X
        {
            get => _x;
            set => _x = value is < 200 and > 0 ? value : throw new Exception();
        }
        
        /// <summary>
        /// Свойства доступа к X, для наложения ограничений на координаты.
        /// </summary>
        /// <exception cref="Exception">Выкидывается при некорректном вводе.</exception>
        public double Y
        {
            get => _y;
            set => _y = Math.Abs(value) < 150 ? value : throw new Exception();
        }
    }
}

