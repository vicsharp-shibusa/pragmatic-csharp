using Structs;

var arr = new ImmutablePoint[10];
var objs = new object[10];

for (int i = 1, y = 10; i < 11; i++, y--)
{
    arr[i-1] = new ImmutablePoint(i / Math.PI, y / Math.PI);

    //objs[i - 1] = arr[i - 1];                 // boxing
    //arr[i - 1] = (ImmutablePoint)objs[i - 1]; // unboxing

    //var p = new Point(i, y);
    //var p2 = Point.Copy(p);
    //Console.WriteLine(p);
    //Console.WriteLine(p2);

    //if (p == p2)
    //{
    //    Console.WriteLine("Equal");
    //}
    //else
    //{
    //    Console.WriteLine("Not Equal");
    //}
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}