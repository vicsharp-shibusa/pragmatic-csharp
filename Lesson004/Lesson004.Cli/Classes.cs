
namespace Classes;

public abstract class Person : IEquatable<Person?>
{
    private readonly Guid _id;

    public Person(string name)
        : this(name, DateOnly.MinValue)
    {
    }

    public Person(string name, DateOnly dateOfBirth)
        : this(Guid.NewGuid(), name, dateOfBirth)
    {
    }

    public Person(Guid id, string name, DateOnly dateOfBirth)
    {
        _id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    public abstract string? Title { get; }

    public Guid Id => _id;
    public string Name { get; set; }
    public DateOnly DateOfBirth { get; set; }

    public override string ToString() => $"{Name} ({DateOfBirth}) - {Title}";
    public override bool Equals(object? obj)
    {
        return Equals(obj as Person);
    }

    public bool Equals(Person? other)
    {
        return other is not null &&
               Id.Equals(other.Id) &&
               Name == other.Name &&
               DateOfBirth.Equals(other.DateOfBirth);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, DateOfBirth);
    }
}

public class Mechanic : Person
{
    public Mechanic(string name) : base(name)
    {
    }

    public Mechanic(string name, DateOnly dateOfBirth) : base(name, dateOfBirth)
    {
    }

    public Mechanic(Guid id, string name, DateOnly dateOfBirth) : base(id, name, dateOfBirth)
    {
    }

    public override string? Title => "Mechanic";

    public static Mechanic Copy(Mechanic mechanic)
    {
        return new Mechanic(mechanic.Id, mechanic.Name, mechanic.DateOfBirth);
    }
}

public sealed class SeniorMechanic : Mechanic
{
    public override string? Title => "Senior Mechanic";

    public SeniorMechanic(string name) : base(name)
    {
    }

    public SeniorMechanic(string name, DateOnly dateOfBirth) : base(name, dateOfBirth)
    {
    }

    public SeniorMechanic(Guid id, string name, DateOnly dateOfBirth) : base(id, name, dateOfBirth)
    {
    }
}

public static class PersonFactory
{
    public static Person? Create(string type)
    {
        Person? p = null;
        switch (type.ToLower())
        {
            case "m":
            case "mechanic":
                p = new Mechanic("Bob Smith", new DateOnly(2001, 12, 6));
                break;
            case "s":
            case "sm":
            case "senior":
            case "senior mechanic":
                p = new SeniorMechanic("John Jones", new DateOnly(1995, 3, 20));
                break;
            default:
                break;
        };
        return p;
    }

    public static void WritePerson(Person? p)
    {
        Console.WriteLine(p);
    }
}