namespace Figures.Tests;

public class CreationFigureTests
{
    private AbstractFigureFactory _abstractFigureFactory;

    [SetUp]
    public void Setup()
    {
        _abstractFigureFactory = AbstractFigureFactory.Instance;
    }

    [TestCase(3, 3, 1, 1.479)]
    [TestCase(1, 5, 2, 2.51)]
    [TestCase(4, 2, -1, 1.532)]
    [TestCase(-4, 2, 4, 3.873)]
    [TestCase(0, 4, -1, 2.32)]
    [TestCase(0, 4, 0, 1.23)]
    [TestCase(2, 4, 3, 2.905)]
    [TestCase(2, 5, 4, 3.8)]
    [TestCase(0, 4, 2, 4.123)]
    [TestCase(0, 4, 3, 0.98)]
    [TestCase(1, -2, -2, 0.968)]
    [TestCase(5, 5, 5, 10)]
    [TestCase(5, 5, 5, 10.825)]
    public void TriangleCreationTest(double a, double b, double c, double testValue)
    {
        var triangle = _abstractFigureFactory.CreateTriangle(a, b, c);

        var area = triangle.CalculateArea();

        if (area == testValue)
            Assert.Pass("Площадь: {0}, проверочное значение: {1}", area, testValue);
        else
            Assert.Fail("Площадь: {0}, проверочное значение: {1}", area, testValue);
    }

    [TestCase(-2, 12.566)]
    [TestCase(2, 12.566)]
    [TestCase(2, 14)]
    [TestCase(0, 0)]
    [TestCase(4, 50.265)]
    public void CircleCreationTest(double radius, double testValue)
    {
        var circle = _abstractFigureFactory.CreateCircle(radius);
        var area = circle.CalculateArea();

        if (area == testValue)
            Assert.Pass("Площадь: {0}, проверочное значение: {1}", area, testValue);
        else
            Assert.Fail("Площадь: {0}, проверочное значение: {1}", area, testValue);
    }

    [TestCase(12.566, -2)]
    [TestCase(50.265, 4)]
    [TestCase(0, 0)]
    [TestCase(10, 5, 5, 5)]
    [TestCase(10.825, 5, 5, 5)]
    [TestCase(2.32, 0, 4, -1)]
    [TestCase(1.23, 0, 4, 0)]
    [TestCase(2.905, 2, 4, 3)]
    public void FigureCreationTest(double testValue, params double[] values)
    {
        var area = _abstractFigureFactory.CalculateAreaByFigureParams(values);

        if (area == testValue)
            Assert.Pass("Площадь: {0}, проверочное значение: {1}", area, testValue);
        else
            Assert.Fail("Площадь: {0}, проверочное значение: {1}", area, testValue);
    }
}