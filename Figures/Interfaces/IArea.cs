namespace Figures.Interfaces;

public interface IArea
{
    /// <summary>
    ///     Вычислить площадь фигуры
    /// </summary>
    /// <returns>Число с плавающей точкой, округленное до 3 знаков после запятой</returns>
    double CalculateArea();
}