var dtNow = DateTime.Now;
var dtNowUtc = DateTime.UtcNow;

Console.WriteLine(dtNow.ToString("yyyy-MM-dd HH:mm:ss zzz"));
Console.WriteLine(dtNow.Kind);
Console.WriteLine(dtNowUtc.ToString("yyyy-MM-dd HH:mm:ss zzz"));
Console.WriteLine(dtNowUtc.Kind);

Console.WriteLine(StartOfDay(dtNow));
Console.WriteLine(EndOfDay(dtNow));

Console.WriteLine($"{dtNow} - {dtNowUtc} = {dtNow - dtNowUtc}");

var tomorrow = DateTime.Now.AddDays(1);
var yesterday = DateTime.Now.AddDays(-1);
Console.WriteLine(tomorrow);
Console.WriteLine(yesterday);

var ts = new TimeSpan(4, 4, 4, 4, 4, 4);

var x = dtNow.Add(ts);
Console.WriteLine(x);

var dtO = new DateOnly(2000, 1, 1);
Console.WriteLine(dtO);
var dt1 = dtO.AddDays(365);
Console.WriteLine(dt1);

var dt3 = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(dt3);

var start = dtO.ToDateTime(TimeOnly.MinValue);
var finish = dtO.ToDateTime(TimeOnly.MaxValue);
var midday = dtO.ToDateTime(new TimeOnly(12,0,0));
Console.WriteLine(start);
Console.WriteLine(midday);
Console.WriteLine(finish);

var offsetNow = DateTimeOffset.Now;
var offsetUtcNow = DateTimeOffset.UtcNow;

Console.WriteLine(offsetNow);
Console.WriteLine(offsetUtcNow);

Console.WriteLine($"{offsetNow} - {offsetUtcNow} = {offsetNow - offsetUtcNow}");

Console.WriteLine(offsetNow.Date);
Console.WriteLine(offsetNow.Offset);

Console.WriteLine(DateOnly.FromDateTime(offsetNow.Date));

DateTime StartOfDay(DateTime dt)
{
    return new DateTime(dt.Year, dt.Month, dt.Day, 0,0,0, dt.Kind);
}

DateTime EndOfDay(DateTime dt)
{
    return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, dt.Kind);
}
