using Figures.Figures;
using Figures.Interfaces;

namespace Figures;

/// <summary>
///     Фабрика фигур
/// </summary>
public abstract class AbstractFigureFactory
{
    public static AbstractFigureFactory Instance => new FigureFactory();

    /// <summary>
    ///     Создать треугольник
    /// </summary>
    /// <param name="a">Сторона треугольник A</param>
    /// <param name="b">Сторона треугольник B</param>
    /// <param name="c">Сторона треугольник C</param>
    /// <returns></returns>
    /// <exception cref="Exception">Если треугольник с заданными сторонами не существует</exception>
    public virtual ITriangle CreateTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, c);
    }

    /// <summary>
    ///     Создать круг
    /// </summary>
    /// <param name="radius">Радиус</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Если радиус меньше или равен 0</exception>
    public virtual ICircle CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    public double CalculateAreaByFigureParams(params double[] values)
    {
        switch (values.Length)
        {
            case 0:
                throw new ArgumentException("Не указаны параметры для определения типа фигуры", nameof(values));
            case 3:
            {
                var type = typeof(Triangle);
                var instance = Activator.CreateInstance(type, values[0], values[1], values[2]);

                return ((Triangle)instance).CalculateArea();
            }
            case 1:
            {
                var type = typeof(Circle);
                var instance = Activator.CreateInstance(type, values[0]);

                return ((Circle)instance).CalculateArea();
            }
            default:
                throw new ArgumentException("Не удалось определить тип фигуры", nameof(values));
        }
    }
}