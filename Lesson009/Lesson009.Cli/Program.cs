using System.Collections.ObjectModel;

const int Size = 10;

var list = new List<Point>(Size);
var dictionary = new Dictionary<int, Point>();

var keyValuePairs = new Collection<KeyValuePair<int, Point>>();

for (int i = 0; i < Size; i++)
{
    list.Add(new Point(i, i));
    dictionary.TryAdd(i, new Point(i, i));
    dictionary.TryAdd(i, new Point(i, i));
    keyValuePairs.Add(new KeyValuePair<int, Point>(i, new Point(i,i)));
    keyValuePairs.Add(new KeyValuePair<int, Point>(i, new Point(i, i)));
}

list.Clear();
var itemsWeCareAbout = list.FirstOrDefault(x => x.X % 2 == 0);

Console.WriteLine(itemsWeCareAbout);
//foreach (var item in itemsWeCareAbout)
//{
//    Console.WriteLine(item);
//}

//foreach (var key in dictionary.Keys)
//{
//    Console.WriteLine(key);

//    Console.WriteLine(dictionary[key]);
//}

//Console.WriteLine("----");
//foreach (var item in keyValuePairs)
//{
//    Console.WriteLine(item.Value);
//}


//List<Point> l = new(Size);
//Collection<Point> c = new();

//HashSet<Point> h = new();
//SortedSet<Point> ss = new();

//for (int i = Size -1; i >= 0; i--)
//{
//    var p = new Point(i, i);
//    l.Add(p);
//    l.Add(p);
//    c.Add(p);
//    c.Add(p);
//    h.Add(p);
//    h.Add(p);
//    ss.Add(p);
//    ss.Add(p);
//}

//var ss2 = new SortedSet<Point>(l);

//l.Add(new Point(-1, -1));
//Console.WriteLine(h.IsSubsetOf(l));
//Console.WriteLine(h.IsProperSubsetOf(l));

//Console.WriteLine(ss2.IsSubsetOf(l));
//Console.WriteLine(ss2.IsProperSubsetOf(l));





//Console.WriteLine($"size of l = {l.Count}");
//Console.WriteLine($"size of c = {c.Count}");
//Console.WriteLine($"size of h = {h.Count}");
//Console.WriteLine($"size of ss = {ss.Count}");

//WriteCollection(l);
//WriteCollection(ss);

void WriteCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
}


readonly struct Point : IComparable<Point>
{
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public int CompareTo(Point other)
    {
        if (X == other.X)
        {
            return Y.CompareTo(other.Y);
        }
        else
        {
            return X.CompareTo(other.X);
        }
    }

    public override string ToString() => $"({X},{Y})";
}


//var arr = Array.CreateInstance(typeof(int), 10);

//for (int i = 0; i < arr.Length; i++)
//{
//    arr.SetValue(Convert.ToInt32(Math.Pow(2, i)), i);
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr.GetValue(i));
//}


//var arr = new int[10];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = Convert.ToInt32(Math.Pow(2, i));
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//class MyCollection<T>
//{
//    List<T> _list = new List<T>();

//    public MyCollection(IEnumerable<T> collection)
//    {
//        foreach (var item in collection)
//        {
//            _list.Add(item);
//        }
//    }

//    public IEnumerable<T> GetSorted()
//    {
//        var copy = new List<T>(_list);
//        copy.Sort();
//        return copy;
//    }
//}

//var p = new Person();
//p.Addresses.Add(new Address());
//p.Addresses.RemoveAt(0);
//class Person
//{
//    public Person()
//    {
//    }
//    public IList<Address> Addresses { get; } = new List<Address>();
//}

//class Address
//{

//}