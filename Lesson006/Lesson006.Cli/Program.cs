#region Logical Operations
//var t = true;
//var f = false;
//bool? nb = null;

//Console.WriteLine($"t = {t}");
//Console.WriteLine($"!t = {!t}");
//Console.WriteLine($"f = {f}");
//Console.WriteLine($"!f = {!f}");
//Console.WriteLine($"nb = {WriteNullable(nb)}");
//Console.WriteLine($"!nb = {WriteNullable(!nb)}");

//Console.WriteLine($"t & f = {t & f}");
//Console.WriteLine($"t & t = {t & t}");
//Console.WriteLine($"f & f = {f & f}");

//Console.WriteLine($"t && f = {t && f}");
//Console.WriteLine($"t && t = {t && t}");
//Console.WriteLine($"f && f = {f && f}");

//Console.WriteLine($"t | f = {t | f}");
//Console.WriteLine($"t | t = {t | t}");
//Console.WriteLine($"f | f = {f | f}");

//Console.WriteLine($"t || f = {t || f}");
//Console.WriteLine($"t || t = {t || t}");
//Console.WriteLine($"f || f = {f || f}");

//if (nb == null || nb.Value == false)
//{
//    Console.WriteLine("not breaking");
//}

//Console.WriteLine($"t ^ f = {t ^ f}");
//Console.WriteLine($"f ^ t = {f ^ t}");
//Console.WriteLine($"f ^ f = {f ^ f}");
//Console.WriteLine($"t ^ t = {t ^ t}");
#endregion

#region Bit Operations
//WriteBits(7);
//WriteNumber("111");

//Console.WriteLine(int.MinValue);
//Console.WriteLine(Math.Pow(2, 31) * -1);
//Console.WriteLine();
//Console.WriteLine(int.MaxValue);
//Console.WriteLine(Math.Pow(2, 31) - 1);

//int x = 1;

//for (int i = 0; i < 15; i = i++)
//{
//    WriteBits(x << i);
//}

//int y = -327;
//WriteBits(y >> 5);
//WriteBits(y >>> 5);

//int x = 7;
//int y = 13;
//int z = x | y;
//WriteBits(x);
//WriteBits(y);
//WriteBits(z);
//Console.WriteLine();
//z = x & y;
//WriteBits(x);
//WriteBits(y);
//WriteBits(z);
//Console.WriteLine();
//z = x ^ y;
//WriteBits(x);
//WriteBits(y);
//WriteBits(z);
//Console.WriteLine();
//x |= z;
//WriteBits(x);
//y &= x;
//WriteBits(y);
//z ^= y;
//WriteBits(z);
//WriteBits(~z);
#endregion

//string WriteNullable(bool? val) => val == null ? "null" : val.GetValueOrDefault().ToString();

//void WriteBits(int value, int size = 32) =>
//    Console.WriteLine($"{value,-10}\t{Convert.ToString(value, toBase: 2).PadLeft(size, '0')}");

//void WriteNumber(string value, int size = 10) =>
//    Console.WriteLine($"{Convert.ToInt32(value, fromBase: 2).ToString().PadRight(size, ' ')}\t{value}");


//using System.Text.RegularExpressions;

//var regex = new Regex("patten", RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled);

Console.WriteLine((int)Color.Red);
Console.WriteLine(Color.Red);
Console.WriteLine((int)Color.Blue);
Console.WriteLine(Color.Blue);

void DoSomething(Days days)
{
    if (days.HasFlag(Days.Sunday))
    {
        Console.WriteLine("Do the thing for Sunday");
    }
    if (days.HasFlag(Days.Monday))
    {

    }
}

enum Color
{
    Red = 1,
    Blue,
    Green,
    Yellow
}

[Flags]
enum Days
{
    None = 0,
    Sunday = 1 << 0,
    Monday = 1 << 1,
    Tuesday = 1 << 2,
    Wednesday = 1 << 3,
    Thursday = 1 << 4,
    Friday = 1 << 5,
    Saturday = 1 << 6,
    Weekend = Sunday | Saturday,
    All = ~None
}