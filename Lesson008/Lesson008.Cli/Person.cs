namespace Lesson008.Cli;

internal class Person
{
    public string? Name { get; init; }
    public int Age { get; init; }
}

internal class AgeTooOldException : Exception
{
    public AgeTooOldException(string? message) : base(message)
    {
    }
}