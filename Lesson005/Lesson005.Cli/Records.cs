using System.Text;

namespace Records.Classes
{

    //public interface IPoint
    //{
    //    double X { get; set; }
    //    double Y { get; set; }
    //}

    public record class Point(double X, double Y)
    {
        public double Z { get; set; }

        protected virtual bool PrintMembers(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"({X},{Y})");
            return true;
        }
    }

    //public abstract record class BasePoint
    //{
    //    public Guid Id { get; set; } = Guid.NewGuid();
    //    public virtual double Z { get; set; }

    //}
}

namespace Records.Structs
{
    public record struct Point(double X, double Y) {
        private bool PrintMembers(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"({X},{Y})");
            return true;
        }
    };

    public readonly record struct ImmutablePoint(double X, double Y) {
        private bool PrintMembers(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"({X},{Y})");
            return true;
        }
    };
}