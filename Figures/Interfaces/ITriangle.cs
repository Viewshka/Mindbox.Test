namespace Figures.Interfaces;

/// <summary>
///     Треугольник
/// </summary>
public interface ITriangle : IArea
{
    /// <summary>
    ///     Сторона A
    /// </summary>
    double A { get; }

    /// <summary>
    ///     Сторона B
    /// </summary>
    double B { get; }

    /// <summary>
    ///     Сторона C
    /// </summary>
    double C { get; }
}