

var p = new Records.Classes.Point(1,2) { Z = 1 };
var p2 = new Records.Classes.Point(2,1) { Z = 1 };

Console.WriteLine(p);
Console.WriteLine(p2);

var s = new Records.Structs.Point(1,2);
var ro = new Records.Structs.ImmutablePoint(2, 1);

Console.WriteLine(s);
Console.WriteLine(ro);
