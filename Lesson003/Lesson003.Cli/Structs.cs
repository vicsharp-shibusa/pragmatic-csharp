namespace Structs;

public struct Point : IEquatable<Point>
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X},{Y})";

    public Point Copy() => new Point(X, Y);

    public static Point Copy(Point point)  => point.Copy();

    public override bool Equals(object? obj)
    {
        return obj is Point point && Equals(point);
    }

    public bool Equals(Point other)
    {
        return X == other.X &&
               Y == other.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    public static bool operator ==(Point left, Point right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Point left, Point right)
    {
        return !(left == right);
    }
}

public readonly struct ImmutablePoint
{
    public ImmutablePoint(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double X { get;  }
    public double Y { get;  }

    public override string ToString() => $"({X:#,##0.00},{Y:#,##0.00})";
}

public ref struct RefPoint
{
    public RefPoint(double x, double y)
    {
        X = x;
        Y = y;
    }
    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X},{Y})";
}

