using BenchmarkDotNet.Attributes;
using System.Collections.ObjectModel;

namespace Collections;

[SimpleJob]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[MemoryDiagnoser]
public class CollectionPerformance
{
    private int[] _data = Array.Empty<int>();
    private Random _random = new Random(Guid.NewGuid().GetHashCode());

    [Params(100, 1_000, 10_000)]
    public int N;

    [GlobalSetup]
    public void Setup()
    {
        _data = new int[N];

        for (int i = 0; i < N; i++)
        {
            _data[i] = _random.Next(int.MinValue, int.MaxValue);
        }
    }

    [Benchmark]
    public void AddToArray()
    {
        var sut = new int[N];
        for (int i = 0; i < N; i++)
        {
            sut[i] = _data[i];
        }
    }

    [Benchmark]
    public void AddToList()
    {
        var sut = new List<int>(N);
        for (int i = 0; i < N; i++)
        {
            sut.Add(_data[i]);
        }
    }

    [Benchmark]
    public void AddToCollection()
    {
        var sut = new Collection<int>();
        for (int i = 0; i < N; i++)
        {
            sut.Add(_data[i]);
        }
    }

    [Benchmark]
    public void AddToHashSet()
    {
        var sut = new HashSet<int>(N);
        for (int i = 0; i < N; i++)
        {
            sut.Add(_data[i]);
        }
    }

    [Benchmark]
    public void AddToSortedSet()
    {
        var sut = new SortedSet<int>();
        for (int i = 0; i < N; i++)
        {
            sut.Add(_data[i]);
        }
    }
}
