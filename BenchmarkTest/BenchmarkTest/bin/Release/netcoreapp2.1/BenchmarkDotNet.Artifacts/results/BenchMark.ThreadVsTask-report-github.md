``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742189 Hz, Resolution=364.6722 ns, Timer=TSC
.NET Core SDK=2.1.508
  [Host]     : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT


```
|     Method |        Mean |       Error |      StdDev |      Median |   Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|----------- |------------:|------------:|------------:|------------:|--------:|-------:|-------:|----------:|
| ThreadTest | 3,503.55 us | 142.4413 us | 417.7558 us | 3,666.41 us | 42.9688 | 3.9063 | 3.9063 |   2.73 KB |
|   TaskTest |    23.66 us |   0.2831 us |   0.2510 us |    23.69 us |  1.6785 |      - |      - |   2.03 KB |
