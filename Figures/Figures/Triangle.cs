using Figures.Interfaces;

namespace Figures.Figures;

internal class Triangle : ITriangle
{
    public Triangle(double a, double b, double c)
    {
        if (!IsParametersValid(a, b, c, out var parameterName))
            throw new ArgumentException("Сторона треугольника не может быть отрицательной или равной 0",
                parameterName);

        if (!IsExistTriangle(a, b, c))
            throw new Exception(
                $"Треугольника с заданными сторонами {nameof(a)}={a}, {nameof(b)}={b}, {nameof(c)}={c} не существует ");

        A = a;
        B = b;
        C = c;
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }

    public double CalculateArea()
    {
        double? area;

        if (A > B && A > C && Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
        {
            area = B * C / 2;
        }

        else if (B > A && B > C && Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2))
        {
            area = A * C / 2;
        }

        else if (C > A && C > B && Math.Pow(C, 2) == Math.Pow(B, 2) + Math.Pow(A, 2))
        {
            area = A * B / 2;
        }
        else
        {
            var semiPerimeter = (A + B + C) / 2;

            area = Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }

        return Math.Round(area.Value, 3);
    }

    private bool IsParametersValid(double a, double b, double c, out string parameterName)
    {
        if (a == 0)
        {
            parameterName = nameof(a);
            return false;
        }

        if (b == 0)
        {
            parameterName = nameof(b);
            return false;
        }

        if (c == 0)
        {
            parameterName = nameof(c);
            return false;
        }

        parameterName = null;

        return true;
    }

    private bool IsExistTriangle(double a, double b, double c)
    {
        if (a + b > c & a + c > b && b + c > a)
            return true;

        return false;
    }
}