using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;

namespace DuplicatesBenchmark
{
    public class DuplicatesBenchmark
    {
        private int[] dataWithDuplicates;

        [Params(10, 100, 1000, 10000)] public int DataSize { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            var distinctData = Enumerable.Range(1, DataSize).ToArray();
            var duplicates = Enumerable
                .Range(1, DataSize / 10) // Duplicate records of 10% of the total data are created
                .Select(_ => random.Next(1, DataSize))
                .ToArray();
            dataWithDuplicates = distinctData
                .Concat(duplicates)
                .ToArray();
        }

        [Benchmark]
        public bool ContainsDuplicatesWithDistinct()
        {
            return dataWithDuplicates.Distinct().Count() != dataWithDuplicates.Length;
        }

        [Benchmark]
        public bool ContainsDuplicatesWithHashSet()
        {
            var knownHashSet = new HashSet<int>();
            return dataWithDuplicates.Any(element => !knownHashSet.Add(element));
        }
    }

    public class Program
    {
        public static void Main()
        {
            var summary = BenchmarkRunner.Run<DuplicatesBenchmark>();
        }
    }

    public class Config : ManualConfig
    {
        public Config()
        {
            Add(MarkdownExporter.Default);
            Add(MarkdownExporter.GitHub);
        }
    }
}