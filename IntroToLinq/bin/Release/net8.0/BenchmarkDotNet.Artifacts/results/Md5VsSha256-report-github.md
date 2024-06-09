```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3593/22H2/2022Update/SunValley2)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method | Mean     | Error    | StdDev   |
|------- |---------:|---------:|---------:|
| Sha256 | 56.66 μs | 0.968 μs | 0.808 μs |
| Md5    | 22.58 μs | 0.121 μs | 0.101 μs |
