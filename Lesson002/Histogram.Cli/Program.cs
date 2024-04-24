using System.Diagnostics;

Console.WriteLine("Please enter a string:");

var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Environment.Exit(0);
}

Debug.Assert(input != null);

var unique = Distinct(input);
var sorted = Sort(unique);

CharCount[] charCounts = new CharCount[sorted.Length];
int c = 0;
int max = 0;

for (int i = 0; i < sorted.Length; i++)
{
    int count = 0;
    for (int j = 0; j < input.Length; j++)
    {
        if (input[j] == sorted[i])
        {
            count++;
        }
    }
    if (count > max)
    {
        max = count;
    }
    charCounts[c++] = new CharCount()
    {
        Char = sorted[i],
        Count = count
    };
}

for (int row = max; row > 0; row--)
{
    for (int col = 0; col < charCounts.Length; col++)
    {
        if (charCounts[col].Count >= row)
        {
            Console.Write('*');
        }
        else
        {
            Console.Write(' ');
        } 
    }
    Console.WriteLine();
}

for (int i = 0; i < charCounts.Length; i++)
{
    Console.Write(charCounts[i].Char);
}

string Distinct(string text)
{
    var arr = text.ToCharArray();

    var result = new char[arr.Length];

    int pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        bool found = false;
        for (int j = 0; j <= pos; j++)
        {
            if (result[j] == arr[i])
            {
                found = true;
            }
        }
        if (!found)
        {
            result[pos++] = arr[i];
        }
    }

    Array.Resize(ref result, pos);

    return new string(result);
}

string Sort(string text)
{
    var arr = text.ToCharArray();

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                char t = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = t;
            }
        }
    }

    return new string(arr);
}

struct CharCount
{
    public char Char;
    public int Count;
}