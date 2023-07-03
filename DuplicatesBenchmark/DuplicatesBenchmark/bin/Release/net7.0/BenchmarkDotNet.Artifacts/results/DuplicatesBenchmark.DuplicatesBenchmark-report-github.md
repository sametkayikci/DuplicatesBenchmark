``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1702/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                         Method | DataSize |         Mean |       Error |      StdDev |       Median |
|------------------------------- |--------- |-------------:|------------:|------------:|-------------:|
| **ContainsDuplicatesWithDistinct** |       **10** |     **119.6 ns** |     **2.32 ns** |     **2.58 ns** |     **118.9 ns** |
|  ContainsDuplicatesWithHashSet |       10 |     182.2 ns |     2.68 ns |     2.51 ns |     183.0 ns |
| **ContainsDuplicatesWithDistinct** |      **100** |     **849.4 ns** |    **16.45 ns** |    **21.39 ns** |     **846.2 ns** |
|  ContainsDuplicatesWithHashSet |      100 |   1,408.6 ns |    25.90 ns |    20.22 ns |   1,405.4 ns |
| **ContainsDuplicatesWithDistinct** |     **1000** |   **7,611.8 ns** |    **99.79 ns** |    **77.91 ns** |   **7,607.6 ns** |
|  ContainsDuplicatesWithHashSet |     1000 |  13,299.1 ns |   263.40 ns |   599.89 ns |  13,051.8 ns |
| **ContainsDuplicatesWithDistinct** |    **10000** | **111,315.9 ns** | **1,663.52 ns** | **3,205.03 ns** | **110,377.0 ns** |
|  ContainsDuplicatesWithHashSet |    10000 | 180,427.2 ns | 3,516.57 ns | 5,154.55 ns | 179,076.2 ns |
