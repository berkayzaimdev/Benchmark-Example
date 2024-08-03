using BenchmarkDotNet.Attributes;

public class Benchmarks
{
    private int[] data;

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        data = new int[1000];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = random.Next(0, 10000);
        }
    }

    [Benchmark]
    public void BubbleSortBenchmark()
    {
        var dataCopy = (int[])data.Clone();
        SortingAlgorithms.BubbleSort(dataCopy);
    }

    [Benchmark]
    public void QuickSortBenchmark()
    {
        var dataCopy = (int[])data.Clone();
        SortingAlgorithms.QuickSort(dataCopy);
    }
}
