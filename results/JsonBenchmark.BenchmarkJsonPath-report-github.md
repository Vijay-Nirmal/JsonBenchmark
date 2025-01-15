```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
13th Gen Intel Core i9-13900HX, 1 CPU, 32 logical and 24 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method                           | JsonPath                                                   |         Mean |       Error |         Ratio |       Gen0 |   Gen1 |  Allocated | Alloc Ratio |
| -------------------------------- | ---------------------------------------------------------- | -----------: | ----------: | ------------: | ---------: | -----: | ---------: | ----------: |
| **Newtonsoft.Json**              | **$..['bicycle','price']**                                 | **719.6 ns** | **2.88 ns** |  **baseline** | **0.0362** |  **-** |  **696 B** |        **** |
| JsonCraft.JsonPath               | $..['bicycle','price']                                     |     693.8 ns |     2.46 ns |  1.04x faster |     0.0792 |      - |     1504 B |  2.16x more |
| 'JsonPath.Net (json-everything)' | $..['bicycle','price']                                     |   6,390.9 ns |    47.26 ns |  8.88x slower |     0.7172 |      - |    13568 B | 19.49x more |
| BlushingPenguin.JsonPath         | $..['bicycle','price']                                     |   1,940.9 ns |    13.76 ns |  2.70x slower |     0.1984 |      - |     3736 B |  5.37x more |
| Hyperbee.Json                    | $..['bicycle','price']                                     |   3,183.2 ns |    15.71 ns |  4.42x slower |     0.1183 |      - |     2264 B |  3.25x more |
| JsonCons.JsonPath                | $..['bicycle','price']                                     |   1,374.9 ns |     5.34 ns |  1.91x slower |     0.2003 |      - |     3784 B |  5.44x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$..***                                                   | **650.3 ns** | **1.70 ns** |  **baseline** | **0.0162** |  **-** |  **320 B** |        **** |
| JsonCraft.JsonPath               | $..*                                                       |     440.4 ns |     1.83 ns |  1.48x faster |     0.0367 |      - |      696 B |  2.17x more |
| 'JsonPath.Net (json-everything)' | $..*                                                       |   9,065.7 ns |    58.13 ns | 13.94x slower |     0.8545 |      - |    16352 B | 51.10x more |
| BlushingPenguin.JsonPath         | $..*                                                       |   1,894.2 ns |    19.57 ns |  2.91x slower |     0.1755 |      - |     3344 B | 10.45x more |
| Hyperbee.Json                    | $..*                                                       |   4,896.8 ns |    33.73 ns |  7.53x slower |     0.1984 |      - |     3856 B | 12.05x more |
| JsonCons.JsonPath                | $..*                                                       |   1,299.5 ns |     4.66 ns |  2.00x slower |     0.2232 |      - |     4200 B | 13.12x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$..author**                                              | **569.1 ns** | **2.59 ns** |  **baseline** | **0.0172** |  **-** |  **336 B** |        **** |
| JsonCraft.JsonPath               | $..author                                                  |     526.7 ns |     1.97 ns |  1.08x faster |     0.0362 |      - |      696 B |  2.07x more |
| 'JsonPath.Net (json-everything)' | $..author                                                  |   5,681.2 ns |    30.80 ns |  9.98x slower |     0.6256 |      - |    11784 B | 35.07x more |
| BlushingPenguin.JsonPath         | $..author                                                  |   1,749.3 ns |    11.24 ns |  3.07x slower |     0.1774 |      - |     3360 B | 10.00x more |
| Hyperbee.Json                    | $..author                                                  |   2,305.0 ns |     9.05 ns |  4.05x slower |     0.1068 |      - |     2056 B |  6.12x more |
| JsonCons.JsonPath                | $..author                                                  |   1,044.0 ns |     8.09 ns |  1.83x slower |     0.1354 |      - |     2560 B |  7.62x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$..book[0,1]**                                           | **649.7 ns** | **2.73 ns** |  **baseline** | **0.0305** |  **-** |  **584 B** |        **** |
| JsonCraft.JsonPath               | $..book[0,1]                                               |     636.1 ns |     1.80 ns |  1.02x faster |     0.0486 |      - |      920 B |  1.58x more |
| 'JsonPath.Net (json-everything)' | $..book[0,1]                                               |   5,996.4 ns |    48.13 ns |  9.23x slower |     0.6714 |      - |    12776 B | 21.88x more |
| BlushingPenguin.JsonPath         | $..book[0,1]                                               |   1,887.8 ns |     8.12 ns |  2.91x slower |     0.1907 |      - |     3616 B |  6.19x more |
| Hyperbee.Json                    | $..book[0,1]                                               |   2,541.3 ns |    14.47 ns |  3.91x slower |     0.1068 |      - |     2056 B |  3.52x more |
| JsonCons.JsonPath                | $..book[0,1]                                               |   1,372.0 ns |     7.24 ns |  2.11x slower |     0.1678 |      - |     3168 B |  5.42x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store..price**                                         | **576.1 ns** | **1.98 ns** |  **baseline** | **0.0248** |  **-** |  **472 B** |        **** |
| JsonCraft.JsonPath               | $.store..price                                             |     603.2 ns |     1.58 ns |  1.05x slower |     0.0505 |      - |      952 B |  2.02x more |
| 'JsonPath.Net (json-everything)' | $.store..price                                             |   5,829.3 ns |    14.98 ns | 10.12x slower |     0.6561 |      - |    12360 B | 26.19x more |
| BlushingPenguin.JsonPath         | $.store..price                                             |   1,478.1 ns |     7.10 ns |  2.57x slower |     0.1755 |      - |     3320 B |  7.03x more |
| Hyperbee.Json                    | $.store..price                                             |   1,985.5 ns |    16.44 ns |  3.45x slower |     0.0916 |      - |     1792 B |  3.80x more |
| JsonCons.JsonPath                | $.store..price                                             |   1,057.2 ns |     6.78 ns |  1.84x slower |     0.1297 |      - |     2472 B |  5.24x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.***                                              | **170.5 ns** | **0.86 ns** |  **baseline** | **0.0300** |  **-** |  **568 B** |        **** |
| JsonCraft.JsonPath               | $.store.*                                                  |     123.0 ns |     0.43 ns |  1.39x faster |     0.0203 |      - |      384 B |  1.48x less |
| 'JsonPath.Net (json-everything)' | $.store.*                                                  |     748.8 ns |     3.75 ns |  4.39x slower |     0.1354 |      - |     2552 B |  4.49x more |
| BlushingPenguin.JsonPath         | $.store.*                                                  |     153.0 ns |     0.93 ns |  1.11x faster |     0.0272 |      - |      512 B |  1.11x less |
| Hyperbee.Json                    | $.store.*                                                  |     763.1 ns |     4.80 ns |  4.47x slower |     0.0763 |      - |     1440 B |  2.54x more |
| JsonCons.JsonPath                | $.store.*                                                  |     335.9 ns |     2.42 ns |  1.97x slower |     0.0648 |      - |     1224 B |  2.15x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.bicycle.color**                                  | **198.4 ns** | **0.55 ns** |  **baseline** | **0.0334** |  **-** |  **632 B** |        **** |
| JsonCraft.JsonPath               | $.store.bicycle.color                                      |     169.8 ns |     1.02 ns |  1.17x faster |     0.0203 |      - |      384 B |  1.65x less |
| 'JsonPath.Net (json-everything)' | $.store.bicycle.color                                      |   1,031.2 ns |     6.11 ns |  5.20x slower |     0.1678 |      - |     3184 B |  5.04x more |
| BlushingPenguin.JsonPath         | $.store.bicycle.color                                      |     224.1 ns |     1.01 ns |  1.13x slower |     0.0365 |      - |      688 B |  1.09x more |
| Hyperbee.Json                    | $.store.bicycle.color                                      |     305.6 ns |     0.93 ns |  1.54x slower |     0.0110 |      - |      208 B |  3.04x less |
| JsonCons.JsonPath                | $.store.bicycle.color                                      |     372.3 ns |     1.82 ns |  1.88x slower |     0.0625 |      - |     1184 B |  1.87x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[-1:]**                                      | **205.9 ns** | **0.83 ns** |  **baseline** | **0.0348** |  **-** |  **656 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[-1:]                                          |     188.3 ns |     1.09 ns |  1.09x faster |     0.0250 |      - |      472 B |  1.39x less |
| 'JsonPath.Net (json-everything)' | $.store.book[-1:]                                          |   1,078.8 ns |     8.79 ns |  5.24x slower |     0.1678 |      - |     3184 B |  4.85x more |
| BlushingPenguin.JsonPath         | $.store.book[-1:]                                          |     234.1 ns |     1.48 ns |  1.14x slower |     0.0367 |      - |      696 B |  1.06x more |
| Hyperbee.Json                    | $.store.book[-1:]                                          |     737.4 ns |     6.12 ns |  3.58x slower |     0.0648 |      - |     1232 B |  1.88x more |
| JsonCons.JsonPath                | $.store.book[-1:]                                          |     512.6 ns |     6.37 ns |  2.49x slower |     0.0782 |      - |     1480 B |  2.26x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[:2]**                                       | **201.9 ns** | **1.21 ns** |  **baseline** | **0.0343** |  **-** |  **648 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[:2]                                           |     186.6 ns |     0.71 ns |  1.08x faster |     0.0250 |      - |      472 B |  1.37x less |
| 'JsonPath.Net (json-everything)' | $.store.book[:2]                                           |   1,306.3 ns |     6.65 ns |  6.47x slower |     0.1850 |      - |     3496 B |  5.40x more |
| BlushingPenguin.JsonPath         | $.store.book[:2]                                           |     242.0 ns |     1.21 ns |  1.20x slower |     0.0362 |      - |      688 B |  1.06x more |
| Hyperbee.Json                    | $.store.book[:2]                                           |     834.0 ns |     2.21 ns |  4.13x slower |     0.0648 |      - |     1232 B |  1.90x more |
| JsonCons.JsonPath                | $.store.book[:2]                                           |     524.2 ns |     4.37 ns |  2.60x slower |     0.0792 |      - |     1504 B |  2.32x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(!@.isbn)]**                               |       **NA** |      **NA** |         **?** |     **NA** | **NA** |     **NA** |       **?** |
| JsonCraft.JsonPath               | $.store.book[?(!@.isbn)]                                   |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| 'JsonPath.Net (json-everything)' | $.store.book[?(!@.isbn)]                                   |   2,074.5 ns |    13.77 ns |             ? |     0.3052 |      - |     5752 B |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(!@.isbn)]                                   |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| Hyperbee.Json                    | $.store.book[?(!@.isbn)]                                   |   1,521.7 ns |     3.76 ns |             ? |     0.1125 |      - |     2120 B |           ? |
| JsonCons.JsonPath                | $.store.book[?(!@.isbn)]                                   |     933.0 ns |     6.20 ns |             ? |     0.1278 |      - |     2408 B |           ? |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(@.author && @.title)]**                   | **550.1 ns** | **1.71 ns** |  **baseline** | **0.0925** |  **-** | **1752 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[?(@.author && @.title)]                       |     489.7 ns |     1.73 ns |  1.12x faster |     0.0572 |      - |     1088 B |  1.61x less |
| 'JsonPath.Net (json-everything)' | $.store.book[?(@.author && @.title)]                       |   3,127.1 ns |    19.92 ns |  5.68x slower |     0.4730 |      - |     8936 B |  5.10x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.author && @.title)]                       |     616.4 ns |     2.06 ns |  1.12x slower |     0.1001 |      - |     1896 B |  1.08x more |
| Hyperbee.Json                    | $.store.book[?(@.author && @.title)]                       |   2,122.6 ns |    14.85 ns |  3.86x slower |     0.1488 |      - |     2856 B |  1.63x more |
| JsonCons.JsonPath                | $.store.book[?(@.author && @.title)]                       |   1,331.9 ns |     6.22 ns |  2.42x slower |     0.1564 |      - |     2944 B |  1.68x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(@.author =~ /.*Waugh/)]**                 | **769.9 ns** | **3.11 ns** |  **baseline** | **0.0772** |  **-** | **1456 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[?(@.author =~ /.*Waugh/)]                     |   1,016.2 ns |     4.47 ns |  1.32x slower |     0.0687 |      - |     1296 B |  1.12x less |
| 'JsonPath.Net (json-everything)' | $.store.book[?(@.author =~ /.*Waugh/)]                     |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(@.author =~ /.*Waugh/)]                     |   1,213.7 ns |     5.96 ns |  1.58x slower |     0.1011 |      - |     1912 B |  1.31x more |
| Hyperbee.Json                    | $.store.book[?(@.author =~ /.*Waugh/)]                     |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| JsonCons.JsonPath                | $.store.book[?(@.author =~ /.*Waugh/)]                     |   2,301.0 ns |    15.56 ns |  2.99x slower |     0.2747 |      - |     5224 B |  3.59x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(@.category == 'fiction')]**               | **478.6 ns** | **3.81 ns** |  **baseline** | **0.0782** |  **-** | **1480 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[?(@.category == 'fiction')]                   |     629.1 ns |     3.95 ns |  1.31x slower |     0.0601 |      - |     1144 B |  1.29x less |
| 'JsonPath.Net (json-everything)' | $.store.book[?(@.category == 'fiction')]                   |   2,850.1 ns |    15.65 ns |  5.96x slower |     0.3853 |      - |     7256 B |  4.90x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.category == 'fiction')]                   |     951.6 ns |     3.26 ns |  1.99x slower |     0.1125 |      - |     2120 B |  1.43x more |
| Hyperbee.Json                    | $.store.book[?(@.category == 'fiction')]                   |   1,795.3 ns |    13.01 ns |  3.75x slower |     0.1354 |      - |     2584 B |  1.75x more |
| JsonCons.JsonPath                | $.store.book[?(@.category == 'fiction')]                   |   1,157.9 ns |     7.39 ns |  2.42x slower |     0.1354 |      - |     2560 B |  1.73x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(@.category in ['fiction','reference'])]** |       **NA** |      **NA** |         **?** |     **NA** | **NA** |     **NA** |       **?** |
| JsonCraft.JsonPath               | $.store.book[?(@.category in ['fiction','reference'])]     |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| 'JsonPath.Net (json-everything)' | $.store.book[?(@.category in ['fiction','reference'])]     |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(@.category in ['fiction','reference'])]     |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| Hyperbee.Json                    | $.store.book[?(@.category in ['fiction','reference'])]     |   2,764.0 ns |    11.92 ns |             ? |     0.2174 |      - |     4136 B |           ? |
| JsonCons.JsonPath                | $.store.book[?(@.category in ['fiction','reference'])]     |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(@.price < 10)].title**                    | **530.9 ns** | **2.87 ns** |  **baseline** | **0.0858** |  **-** | **1632 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[?(@.price < 10)].title                        |     815.8 ns |     2.40 ns |  1.54x slower |     0.0601 |      - |     1136 B |  1.44x less |
| 'JsonPath.Net (json-everything)' | $.store.book[?(@.price < 10)].title                        |   3,198.0 ns |    13.15 ns |  6.02x slower |     0.4234 | 0.0038 |     8040 B |  4.93x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.price < 10)].title                        |     945.9 ns |     2.11 ns |  1.78x slower |     0.1011 |      - |     1912 B |  1.17x more |
| Hyperbee.Json                    | $.store.book[?(@.price < 10)].title                        |   2,068.3 ns |     7.92 ns |  3.90x slower |     0.1373 |      - |     2592 B |  1.59x more |
| JsonCons.JsonPath                | $.store.book[?(@.price < 10)].title                        |   1,476.9 ns |     6.11 ns |  2.78x slower |     0.1488 |      - |     2824 B |  1.73x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(@.price > 10 && @.price < 20)]**          | **686.8 ns** | **3.79 ns** |  **baseline** | **0.1183** |  **-** | **2232 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[?(@.price > 10 && @.price < 20)]              |   1,101.2 ns |     6.02 ns |  1.60x slower |     0.0801 |      - |     1528 B |  1.46x less |
| 'JsonPath.Net (json-everything)' | $.store.book[?(@.price > 10 && @.price < 20)]              |   4,498.3 ns |    18.98 ns |  6.55x slower |     0.5875 |      - |    11056 B |  4.95x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.price > 10 && @.price < 20)]              |   1,361.7 ns |     4.05 ns |  1.98x slower |     0.1411 |      - |     2680 B |  1.20x more |
| Hyperbee.Json                    | $.store.book[?(@.price > 10 && @.price < 20)]              |   2,912.4 ns |    19.29 ns |  4.24x slower |     0.1793 |      - |     3384 B |  1.52x more |
| JsonCons.JsonPath                | $.store.book[?(@.price > 10 && @.price < 20)]              |   2,270.3 ns |    18.15 ns |  3.31x slower |     0.2022 |      - |     3832 B |  1.72x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(@.price in [8.95, 12.99])]**              |       **NA** |      **NA** |         **?** |     **NA** | **NA** |     **NA** |       **?** |
| JsonCraft.JsonPath               | $.store.book[?(@.price in [8.95, 12.99])]                  |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| 'JsonPath.Net (json-everything)' | $.store.book[?(@.price in [8.95, 12.99])]                  |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(@.price in [8.95, 12.99])]                  |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| Hyperbee.Json                    | $.store.book[?(@.price in [8.95, 12.99])]                  |   2,966.5 ns |    19.18 ns |             ? |     0.2060 |      - |     3944 B |           ? |
| JsonCons.JsonPath                | $.store.book[?(@.price in [8.95, 12.99])]                  |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[?(length(@.author) > 5)]**                  |       **NA** |      **NA** |         **?** |     **NA** | **NA** |     **NA** |       **?** |
| JsonCraft.JsonPath               | $.store.book[?(length(@.author) > 5)]                      |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| 'JsonPath.Net (json-everything)' | $.store.book[?(length(@.author) > 5)]                      |   4,520.4 ns |    36.18 ns |             ? |     0.5035 |      - |     9504 B |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(length(@.author) > 5)]                      |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| Hyperbee.Json                    | $.store.book[?(length(@.author) > 5)]                      |           NA |          NA |             ? |         NA |     NA |         NA |           ? |
| JsonCons.JsonPath                | $.store.book[?(length(@.author) > 5)]                      |   2,120.2 ns |     9.79 ns |             ? |     0.2441 |      - |     4600 B |           ? |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[*]**                                        | **202.7 ns** | **0.76 ns** |  **baseline** | **0.0334** |  **-** |  **632 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[*]                                            |     161.0 ns |     1.20 ns |  1.26x faster |     0.0198 |      - |      376 B |  1.68x less |
| 'JsonPath.Net (json-everything)' | $.store.book[*]                                            |   1,339.3 ns |     6.91 ns |  6.61x slower |     0.1831 |      - |     3472 B |  5.49x more |
| BlushingPenguin.JsonPath         | $.store.book[*]                                            |     217.3 ns |     1.08 ns |  1.07x slower |     0.0343 |      - |      648 B |  1.03x more |
| Hyperbee.Json                    | $.store.book[*]                                            |     809.0 ns |     1.68 ns |  3.99x slower |     0.0696 |      - |     1320 B |  2.09x more |
| JsonCons.JsonPath                | $.store.book[*]                                            |     372.5 ns |     1.30 ns |  1.84x slower |     0.0663 |      - |     1248 B |  1.97x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[*].author**                                 | **292.7 ns** | **1.01 ns** |  **baseline** | **0.0415** |  **-** |  **784 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[*].author                                     |     318.2 ns |     1.49 ns |  1.09x slower |     0.0272 |      - |      520 B |  1.51x less |
| 'JsonPath.Net (json-everything)' | $.store.book[*].author                                     |   2,083.4 ns |    16.37 ns |  7.12x slower |     0.2632 |      - |     4992 B |  6.37x more |
| BlushingPenguin.JsonPath         | $.store.book[*].author                                     |     331.1 ns |     2.10 ns |  1.13x slower |     0.0429 |      - |      816 B |  1.04x more |
| Hyperbee.Json                    | $.store.book[*].author                                     |   1,218.1 ns |     5.73 ns |  4.16x slower |     0.0801 |      - |     1528 B |  1.95x more |
| JsonCons.JsonPath                | $.store.book[*].author                                     |     504.8 ns |     1.85 ns |  1.72x slower |     0.0734 |      - |     1384 B |  1.77x more |
|                                  |                                                            |              |             |               |            |        |            |             |
| **Newtonsoft.Json**              | **$.store.book[0].title**                                  | **253.8 ns** | **1.65 ns** |  **baseline** | **0.0401** |  **-** |  **760 B** |        **** |
| JsonCraft.JsonPath               | $.store.book[0].title                                      |     228.3 ns |     1.11 ns |  1.11x faster |     0.0234 |      - |      440 B |  1.73x less |
| 'JsonPath.Net (json-everything)' | $.store.book[0].title                                      |   1,478.5 ns |    15.78 ns |  5.83x slower |     0.2155 |      - |     4088 B |  5.38x more |
| BlushingPenguin.JsonPath         | $.store.book[0].title                                      |     302.0 ns |     2.56 ns |  1.19x slower |     0.0439 |      - |      832 B |  1.09x more |
| Hyperbee.Json                    | $.store.book[0].title                                      |     363.7 ns |     2.01 ns |  1.43x slower |     0.0110 |      - |      208 B |  3.65x less |
| JsonCons.JsonPath                | $.store.book[0].title                                      |     472.4 ns |     2.10 ns |  1.86x slower |     0.0668 |      - |     1264 B |  1.66x more |

Benchmarks with issues:
  BenchmarkJsonPath.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(!@.isbn)]]
  BenchmarkJsonPath.JsonCraft.JsonPath: DefaultJob [JsonPath=$.store.book[?(!@.isbn)]]
  BenchmarkJsonPath.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(!@.isbn)]]
  BenchmarkJsonPath.'JsonPath.Net (json-everything)': DefaultJob [JsonPath=$.store.book[?(@.author =~ /.*Waugh/)]]
  BenchmarkJsonPath.Hyperbee.Json: DefaultJob [JsonPath=$.store.book[?(@.author =~ /.*Waugh/)]]
  BenchmarkJsonPath.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkJsonPath.JsonCraft.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkJsonPath.'JsonPath.Net (json-everything)': DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkJsonPath.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkJsonPath.JsonCons.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkJsonPath.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkJsonPath.JsonCraft.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkJsonPath.'JsonPath.Net (json-everything)': DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkJsonPath.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkJsonPath.JsonCons.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkJsonPath.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(length(@.author) > 5)]]
  BenchmarkJsonPath.JsonCraft.JsonPath: DefaultJob [JsonPath=$.store.book[?(length(@.author) > 5)]]
  BenchmarkJsonPath.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(length(@.author) > 5)]]
  BenchmarkJsonPath.Hyperbee.Json: DefaultJob [JsonPath=$.store.book[?(length(@.author) > 5)]]
