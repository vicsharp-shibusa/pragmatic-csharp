using BenchmarkDotNet.Attributes;

namespace Collections;

[SimpleJob]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[MemoryDiagnoser]
public class CollectionReturns
{
    [Params(100, 1_000)]
    public int N;

    [Benchmark]
    public void EmptyEnumerable()
    {
        for (int i = 0; i < N; i++)
        {
            _ = ReturnEmptyEnumerable();
        }
    }

    [Benchmark]
    public void EmptyList()
    {
        for (int i = 0; i < N; i++)
        {
            _ = ReturnEmptyList();
        }
    }

    private IEnumerable<int> ReturnEmptyEnumerable()
    {
        return Enumerable.Empty<int>();
    }

    private IEnumerable<int> ReturnEmptyList()
    {
        return new List<int>();
    }

}
