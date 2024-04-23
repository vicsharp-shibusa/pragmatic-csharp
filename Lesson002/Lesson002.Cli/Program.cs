#region Multiplication
//int i = 2;
//float f = 0.5f;
//double d = 1.01D;
//decimal m = 2.0003M;

//Console.WriteLine(--i);
//Console.WriteLine(--f);
//Console.WriteLine(--d);
//Console.WriteLine(--m);

//Console.WriteLine(-(-m));

//Console.WriteLine(i * f);
//Console.WriteLine(i * d);
//Console.WriteLine(i * m);
//Console.WriteLine(f * d);

//var dbl = d * (double)m;
//var dec = (decimal)d * m;

//Console.WriteLine(dbl);
//Console.WriteLine(dbl.GetType());
//Console.WriteLine(dec);
//Console.WriteLine(dec.GetType());
#endregion

#region Division
//Console.WriteLine(3 / 1);
//Console.WriteLine(1 / 3);

//Console.WriteLine(1f / 3f);
//Console.WriteLine(1d / 3d);
//Console.WriteLine(1m / 3m);

//float f = 0;
//double a = 0;
//Console.WriteLine(5d / a);
//Console.WriteLine(5f / f);

#endregion

#region Remainders
//Console.WriteLine(5 % 3);
//Console.WriteLine(5f % 3f);
//Console.WriteLine(5d % 3d);
//Console.WriteLine(5m % 3m);

//for (int i = 0; i < 10; i++)
//{
//    if (IsEven(i))
//    {
//        Console.WriteLine($"{i} is even");
//    }
//    if (IsDivisibleByThree(i))
//    {
//        Console.WriteLine($"{i} is divisible by 3");
//    }
//}

//bool IsEven(int x) => x % 2 == 0;

//bool IsDivisibleByThree(int x) => x % 3 == 0;
#endregion

#region Compound Assignments

//int a = 2;
//int b = 3;
//int c = 4;

//Console.WriteLine(a);
//a += b;
//Console.WriteLine(a);
//a *= b;
//Console.WriteLine(a);
//a -= c;
//Console.WriteLine(a);
//a /= b;
//Console.WriteLine(a);

#endregion

#region Precendence and Associativity

//Console.WriteLine(3 * 4 / 6);
//Console.WriteLine(3f * (4f / (7f - 2f)));

#endregion

#region Checked vs Unchecked
//int minInt = int.MinValue;
//int maxInt = int.MaxValue;

//Console.WriteLine(minInt);
//Console.WriteLine(maxInt);

//int a = maxInt + 1;
//Console.WriteLine(a);

//Console.WriteLine(unchecked(maxInt + 2));

//unchecked
//{
//    a = maxInt + 1;
//    Console.WriteLine(a);
//}

//Console.WriteLine(uint.MinValue);
//Console.WriteLine(uint.MaxValue);

//Console.WriteLine(ulong.MinValue);
//Console.WriteLine(ulong.MaxValue);
#endregion

#region ByRef
//int a = 1;
//Increment(ref a);
//Console.WriteLine(a);

//Point p = new Point()
//{
//    X = 1,
//    Y = 3
//};

//IncrementX(ref p);

//Console.WriteLine($"{p.X},{p.Y}");

//void Increment(ref int x)
//{
//    x++;
//}

//void IncrementX(ref Point p)
//{
//    p.X++;
//}

//struct Point
//{
//    public int X;
//    public int Y;
//}
#endregion

#region params and out
//Console.WriteLine(Multiply(out string m, 3, 5,-4,150,-900,6,5,4,8,212));
//Console.WriteLine(m);

//int Sum(params int[] vals)
//{
//    int x = 0;
//    foreach (var v in vals)
//    {
//        x += v;
//    }
//    return x;
//}

//int Multiply(out string message, params int[] vals)
//{
//    message = $"There were {vals.Length} arguments";

//    int x = 1;
//    foreach (var v in vals)
//    {
//        x *= v;
//    }

//    return x;
//}
#endregion

#region continue and break
//int i = 0;

//while (true)
//{
//    i++;

//    if (i % 2 == 0)
//    {
//        continue;
//    }

//    Console.WriteLine(i);

//    if (i % 15 == 0)
//    {
//        break;
//    }
//}
#endregion

#region Arrays
//int[] arr = new int[10];
//Console.WriteLine(arr.Length);

//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = i;
//}

//Console.WriteLine(string.Join(',', arr));

//int[,] twoDim = new int[3, 3];
//Console.WriteLine(twoDim.Length);
//Console.WriteLine(twoDim.GetLength(0));
//Console.WriteLine(twoDim.GetLength(1));

//int i = 0;
//for (int row = 0; row < twoDim.GetLength(0); row++)
//{
//    for (int col = 0; col < twoDim.GetLength(1); col++)
//    {
//        twoDim[row, col] = ++i;
//    }
//}

//for (int row = 0; row < twoDim.GetLength(0); row++)
//{
//    for (int col = 0; col < twoDim.GetLength(1); col++)
//    {
//        Console.Write(twoDim[row, col] + "\t");

//        if ((col + 1) % 3 == 0)
//        {
//            Console.WriteLine();
//        }
//    }
//}


//int[][] jagged = new int[3][];

//for (int i = 0; i < 3; i++)
//{
//    jagged[i] = new int[i + 3];
//}

//string str = "This is my string.";
//Console.WriteLine(str);
//Console.WriteLine(Reverse(str));
//Console.WriteLine(Scramble(str));

//string Reverse(string s)
//{
//    var arr = s.ToCharArray();
//    var result = new char[arr.Length];
//    int r = 0;
//    for (int i = arr.Length - 1; i >= 0; i--)
//    {
//        result[r++] = arr[i];
//    }
//    return new string(result);
//}

//string Scramble(string s)
//{
//    var arr = s.ToCharArray();
//    var result = new char[arr.Length];
//    int r = 0;
//    for (int i = 0; i < arr.Length - 1; i++)
//    {
//        if (i % 2 == 0)
//        {
//            char t = arr[i];
//            result[r] = arr[i + 1];
//            result[r + 1] = t;
//        }
//        r++;
//    }
//    return new string(result);
//}

//for (int c = 0; c < 255; c++)
//{
//    Console.WriteLine($"{c}\t{(char)c}");
//}

//char a = 'A';
//char b = 'a';

//if (a < b)
//{
//    Console.WriteLine($"{a} < {b}");
//}


//int[] arr = new int[200];

//int a = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (i % 3 == 0)
//    {
//        arr[a++] = i;
//    }

//    if (i > 100)
//    {
//        break;
//    }
//}

//Array.Resize(ref arr, a);

//Console.WriteLine(string.Join(',', arr));
//Console.WriteLine(arr.Length);
#endregion