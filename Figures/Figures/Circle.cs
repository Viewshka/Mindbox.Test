using Figures.Interfaces;

namespace Figures.Figures;

internal class Circle : ICircle
{
    /// <summary>
    ///     Круг
    /// </summary>
    /// <param name="radius"></param>
    /// <exception cref="ArgumentException">Если радиус меньше или равен 0</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус должен быть больше 0", nameof(radius));

        Radius = radius;
    }

    public double Radius { get; }

    public double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
    }
}