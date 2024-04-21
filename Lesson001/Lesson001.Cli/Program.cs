
Random rnd = new Random(29873);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(rnd.Next(1, 101));
}

string? name = null;
string? age = null;
string? gender = null;

for (int i = 2; i >= 0; i--)
{
    if (i == 0)
    {
        name = GetAnswer("Please enter your name: ");
    }
    else if (i == 1)
    {
        age = GetAnswer("What is your age?: ");
    }
    else
    {
        gender = GetAnswer("What is your gender?: ");
    }
}

Console.WriteLine(string.Format("Hello, {0}", name));
Console.WriteLine($"{name}, it's a beautiful day.");
Console.WriteLine($"It's a good time to be a {age} year old {gender}.");


string? GetAnswer(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}