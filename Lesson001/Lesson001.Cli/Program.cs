int min = 1;
int max = 100;

Random rnd = new Random(29873);

var answer = rnd.Next(min, max + 1);

Console.WriteLine($"I have selected a number between {min} and {max}; please guess.");

int guess = 0;
int numGuesses = 0;

while (guess != answer)
{
    Console.Write("Your guess: ");
    var guessStr = Console.ReadLine();

    if (!int.TryParse(guessStr, out guess))
    {
        Console.WriteLine($"'{guessStr}' is not a number.");
    }
    else
    {
        guess = Convert.ToInt32(guessStr);

        if (guess < answer)
        {
            Console.WriteLine("Too low");
        }
        else if (guess > answer)
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine("Yes!");
        }
        numGuesses++;
    }
}

Console.WriteLine();
Console.WriteLine($"You got it in {numGuesses} guesses!");
