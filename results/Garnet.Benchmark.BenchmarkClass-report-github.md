```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
13th Gen Intel Core i9-13900HX, 1 CPU, 32 logical and 24 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method                           | JsonPath                                               | Mean       | Error     | Median     | Ratio         | Gen0   | Gen1   | Allocated | Alloc Ratio |
|--------------------------------- |------------------------------------------------------- |-----------:|----------:|-----------:|--------------:|-------:|-------:|----------:|------------:|
| **Newtonsoft.Json**                  | **$..***                                                   |   **633.8 ns** |  **12.34 ns** |   **628.2 ns** |      **baseline** | **0.0162** |      **-** |     **320 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $..*                                                   | 6,426.0 ns | 123.34 ns | 6,428.1 ns | 10.15x slower | 1.0757 | 0.0153 |   20344 B | 63.58x more |
| BlushingPenguin.JsonPath         | $..*                                                   | 1,706.4 ns |  33.88 ns | 1,713.4 ns |  2.69x slower | 0.1774 |      - |    3344 B | 10.45x more |
| Hyperbee.Json                    | $..*                                                   | 4,325.3 ns |  84.51 ns | 4,304.2 ns |  6.83x slower | 0.1984 |      - |    3856 B | 12.05x more |
| JsonCons.JsonPath                | $..*                                                   | 1,161.6 ns |  13.05 ns | 1,162.9 ns |  1.83x slower | 0.2232 |      - |    4200 B | 13.12x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$..author**                                              |   **502.1 ns** |   **7.93 ns** |   **500.8 ns** |      **baseline** | **0.0172** |      **-** |     **336 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $..author                                              | 4,624.7 ns |  60.28 ns | 4,608.7 ns |  9.21x slower | 0.8011 | 0.0076 |   15088 B | 44.90x more |
| BlushingPenguin.JsonPath         | $..author                                              | 1,610.4 ns |  24.08 ns | 1,617.4 ns |  3.21x slower | 0.1774 |      - |    3360 B | 10.00x more |
| Hyperbee.Json                    | $..author                                              | 1,933.2 ns |  15.40 ns | 1,932.4 ns |  3.85x slower | 0.1087 |      - |    2056 B |  6.12x more |
| JsonCons.JsonPath                | $..author                                              |   796.9 ns |  13.67 ns |   796.5 ns |  1.59x slower | 0.1354 |      - |    2560 B |  7.62x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$..book[0,1]**                                           |   **568.0 ns** |   **9.90 ns** |   **571.1 ns** |      **baseline** | **0.0305** |      **-** |     **584 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $..book[0,1]                                           | 4,856.8 ns |  53.52 ns | 4,866.7 ns |  8.55x slower | 0.8545 | 0.0153 |   16136 B | 27.63x more |
| BlushingPenguin.JsonPath         | $..book[0,1]                                           | 1,745.5 ns |  34.32 ns | 1,759.8 ns |  3.07x slower | 0.1907 |      - |    3616 B |  6.19x more |
| Hyperbee.Json                    | $..book[0,1]                                           | 2,182.4 ns |  41.25 ns | 2,180.1 ns |  3.84x slower | 0.1068 |      - |    2056 B |  3.52x more |
| JsonCons.JsonPath                | $..book[0,1]                                           | 1,156.3 ns |  17.85 ns | 1,156.5 ns |  2.04x slower | 0.1678 |      - |    3168 B |  5.42x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store..price**                                         |   **502.4 ns** |   **8.65 ns** |   **502.3 ns** |      **baseline** | **0.0248** |      **-** |     **472 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store..price                                         | 4,726.4 ns |  90.52 ns | 4,688.5 ns |  9.41x slower | 0.8316 | 0.0076 |   15728 B | 33.32x more |
| BlushingPenguin.JsonPath         | $.store..price                                         | 1,326.8 ns |  25.66 ns | 1,327.1 ns |  2.64x slower | 0.1755 |      - |    3320 B |  7.03x more |
| Hyperbee.Json                    | $.store..price                                         | 1,703.8 ns |  27.38 ns | 1,710.7 ns |  3.39x slower | 0.0935 |      - |    1792 B |  3.80x more |
| JsonCons.JsonPath                | $.store..price                                         |   910.9 ns |  16.62 ns |   909.5 ns |  1.81x slower | 0.1297 |      - |    2472 B |  5.24x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.***                                              |   **148.5 ns** |   **3.00 ns** |   **148.0 ns** |      **baseline** | **0.0300** |      **-** |     **568 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.*                                              |   906.6 ns |  17.97 ns |   909.4 ns |  6.11x slower | 0.1822 | 0.0010 |    3440 B |  6.06x more |
| BlushingPenguin.JsonPath         | $.store.*                                              |   128.1 ns |   1.76 ns |   128.5 ns |  1.16x faster | 0.0272 |      - |     512 B |  1.11x less |
| Hyperbee.Json                    | $.store.*                                              |   652.5 ns |   6.95 ns |   651.3 ns |  4.40x slower | 0.0763 |      - |    1440 B |  2.54x more |
| JsonCons.JsonPath                | $.store.*                                              |   293.9 ns |   4.10 ns |   294.2 ns |  1.98x slower | 0.0648 |      - |    1224 B |  2.15x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.bicycle.color**                                  |   **172.7 ns** |   **2.29 ns** |   **173.0 ns** |      **baseline** | **0.0334** |      **-** |     **632 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.bicycle.color                                  | 1,225.3 ns |  15.74 ns | 1,227.7 ns |  7.10x slower | 0.2346 | 0.0019 |    4440 B |  7.03x more |
| BlushingPenguin.JsonPath         | $.store.bicycle.color                                  |   203.4 ns |   3.21 ns |   202.9 ns |  1.18x slower | 0.0365 |      - |     688 B |  1.09x more |
| Hyperbee.Json                    | $.store.bicycle.color                                  |   244.0 ns |   4.06 ns |   244.4 ns |  1.41x slower | 0.0110 |      - |     208 B |  3.04x less |
| JsonCons.JsonPath                | $.store.bicycle.color                                  |   331.8 ns |   6.58 ns |   332.8 ns |  1.92x slower | 0.0625 |      - |    1184 B |  1.87x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[-1:]**                                      |   **173.4 ns** |   **2.87 ns** |   **172.5 ns** |      **baseline** | **0.0348** |      **-** |     **656 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[-1:]                                      | 1,114.1 ns |  18.94 ns | 1,113.2 ns |  6.43x slower | 0.2270 |      - |    4280 B |  6.52x more |
| BlushingPenguin.JsonPath         | $.store.book[-1:]                                      |   200.5 ns |   2.78 ns |   199.8 ns |  1.16x slower | 0.0370 |      - |     696 B |  1.06x more |
| Hyperbee.Json                    | $.store.book[-1:]                                      |   601.2 ns |  10.02 ns |   602.0 ns |  3.47x slower | 0.0648 |      - |    1232 B |  1.88x more |
| JsonCons.JsonPath                | $.store.book[-1:]                                      |   442.1 ns |   7.65 ns |   442.1 ns |  2.55x slower | 0.0782 |      - |    1480 B |  2.26x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[:2]**                                       |   **181.4 ns** |   **3.56 ns** |   **181.4 ns** |      **baseline** | **0.0343** |      **-** |     **648 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[:2]                                       | 1,311.9 ns |  19.99 ns | 1,308.7 ns |  7.23x slower | 0.2460 | 0.0019 |    4648 B |  7.17x more |
| BlushingPenguin.JsonPath         | $.store.book[:2]                                       |   199.9 ns |   3.88 ns |   199.7 ns |  1.10x slower | 0.0365 |      - |     688 B |  1.06x more |
| Hyperbee.Json                    | $.store.book[:2]                                       |   693.9 ns |  12.08 ns |   696.5 ns |  3.83x slower | 0.0648 |      - |    1232 B |  1.90x more |
| JsonCons.JsonPath                | $.store.book[:2]                                       |   440.5 ns |   8.55 ns |   442.0 ns |  2.43x slower | 0.0796 |      - |    1504 B |  2.32x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(!@.isbn)]**                               |         **NA** |        **NA** |         **NA** |             **?** |     **NA** |     **NA** |        **NA** |           **?** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(!@.isbn)]                               | 2,482.6 ns |  37.17 ns | 2,480.6 ns |             ? | 0.4234 | 0.0038 |    8008 B |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(!@.isbn)]                               |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| Hyperbee.Json                    | $.store.book[?(!@.isbn)]                               | 1,295.0 ns |  11.02 ns | 1,294.4 ns |             ? | 0.1125 |      - |    2120 B |           ? |
| JsonCons.JsonPath                | $.store.book[?(!@.isbn)]                               |   818.8 ns |  13.10 ns |   815.1 ns |             ? | 0.1278 |      - |    2408 B |           ? |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(@.author &amp;&amp; @.title)]**                   |   **486.2 ns** |   **7.26 ns** |   **484.7 ns** |      **baseline** | **0.0925** |      **-** |    **1752 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(@.author &amp;&amp; @.title)]                   | 3,442.9 ns |  49.84 ns | 3,452.3 ns |  7.08x slower | 0.6065 | 0.0076 |   11416 B |  6.52x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.author &amp;&amp; @.title)]                   |   542.6 ns |  10.31 ns |   544.6 ns |  1.12x slower | 0.1001 |      - |    1896 B |  1.08x more |
| Hyperbee.Json                    | $.store.book[?(@.author &amp;&amp; @.title)]                   | 1,796.4 ns |  26.38 ns | 1,798.6 ns |  3.70x slower | 0.1507 |      - |    2856 B |  1.63x more |
| JsonCons.JsonPath                | $.store.book[?(@.author &amp;&amp; @.title)]                   | 1,175.6 ns |  23.24 ns | 1,174.3 ns |  2.42x slower | 0.1564 |      - |    2944 B |  1.68x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(@.author =~ /.*Waugh/)]**                 |   **673.3 ns** |  **12.18 ns** |   **670.7 ns** |      **baseline** | **0.0772** |      **-** |    **1456 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(@.author =~ /.*Waugh/)]                 |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(@.author =~ /.*Waugh/)]                 | 1,073.9 ns |  18.70 ns | 1,074.8 ns |  1.60x slower | 0.1011 |      - |    1912 B |  1.31x more |
| Hyperbee.Json                    | $.store.book[?(@.author =~ /.*Waugh/)]                 |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| JsonCons.JsonPath                | $.store.book[?(@.author =~ /.*Waugh/)]                 | 2,006.2 ns |  38.55 ns | 2,007.5 ns |  2.98x slower | 0.2747 |      - |    5208 B |  3.58x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(@.category == &#39;fiction&#39;)]**               |   **408.3 ns** |   **7.23 ns** |   **406.9 ns** |      **baseline** | **0.0782** |      **-** |    **1480 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(@.category == &#39;fiction&#39;)]               | 3,228.2 ns |  46.22 ns | 3,214.1 ns |  7.91x slower | 0.5150 | 0.0076 |    9720 B |  6.57x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.category == &#39;fiction&#39;)]               |   954.7 ns |  18.83 ns |   958.5 ns |  2.34x slower | 0.1125 |      - |    2120 B |  1.43x more |
| Hyperbee.Json                    | $.store.book[?(@.category == &#39;fiction&#39;)]               | 1,475.3 ns |  25.20 ns | 1,476.7 ns |  3.61x slower | 0.1354 |      - |    2584 B |  1.75x more |
| JsonCons.JsonPath                | $.store.book[?(@.category == &#39;fiction&#39;)]               |   983.7 ns |  18.75 ns |   980.4 ns |  2.41x slower | 0.1354 |      - |    2560 B |  1.73x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(@.category in [&#39;fiction&#39;,&#39;reference&#39;])]** |         **NA** |        **NA** |         **NA** |             **?** |     **NA** |     **NA** |        **NA** |           **?** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(@.category in [&#39;fiction&#39;,&#39;reference&#39;])] |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(@.category in [&#39;fiction&#39;,&#39;reference&#39;])] |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| Hyperbee.Json                    | $.store.book[?(@.category in [&#39;fiction&#39;,&#39;reference&#39;])] | 2,383.3 ns |  45.84 ns | 2,369.9 ns |             ? | 0.2174 |      - |    4136 B |           ? |
| JsonCons.JsonPath                | $.store.book[?(@.category in [&#39;fiction&#39;,&#39;reference&#39;])] |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(@.price &lt; 10)].title**                    |   **507.1 ns** |  **13.07 ns** |   **493.9 ns** |      **baseline** | **0.0858** |      **-** |    **1632 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(@.price &lt; 10)].title                    | 3,598.3 ns |  42.02 ns | 3,610.0 ns |  7.13x slower | 0.5608 | 0.0076 |   10560 B |  6.47x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.price &lt; 10)].title                    |   835.9 ns |  14.62 ns |   834.9 ns |  1.66x slower | 0.1011 |      - |    1912 B |  1.17x more |
| Hyperbee.Json                    | $.store.book[?(@.price &lt; 10)].title                    | 1,713.7 ns |  31.19 ns | 1,703.2 ns |  3.40x slower | 0.1373 |      - |    2592 B |  1.59x more |
| JsonCons.JsonPath                | $.store.book[?(@.price &lt; 10)].title                    | 1,325.2 ns |  26.19 ns | 1,329.3 ns |  2.63x slower | 0.1488 |      - |    2824 B |  1.73x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(@.price &gt; 10 &amp;&amp; @.price &lt; 20)]**          |   **623.9 ns** |  **12.05 ns** |   **621.3 ns** |      **baseline** | **0.1183** |      **-** |    **2232 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(@.price &gt; 10 &amp;&amp; @.price &lt; 20)]          | 5,013.7 ns |  94.93 ns | 5,020.8 ns |  8.04x slower | 0.7324 | 0.0076 |   13784 B |  6.18x more |
| BlushingPenguin.JsonPath         | $.store.book[?(@.price &gt; 10 &amp;&amp; @.price &lt; 20)]          | 1,253.7 ns |  16.05 ns | 1,252.0 ns |  2.01x slower | 0.1411 |      - |    2680 B |  1.20x more |
| Hyperbee.Json                    | $.store.book[?(@.price &gt; 10 &amp;&amp; @.price &lt; 20)]          | 2,510.4 ns |  49.62 ns | 2,520.6 ns |  4.03x slower | 0.1793 |      - |    3384 B |  1.52x more |
| JsonCons.JsonPath                | $.store.book[?(@.price &gt; 10 &amp;&amp; @.price &lt; 20)]          | 2,048.9 ns |  35.93 ns | 2,054.1 ns |  3.29x slower | 0.2022 |      - |    3832 B |  1.72x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(@.price in [8.95, 12.99])]**              |         **NA** |        **NA** |         **NA** |             **?** |     **NA** |     **NA** |        **NA** |           **?** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(@.price in [8.95, 12.99])]              |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(@.price in [8.95, 12.99])]              |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| Hyperbee.Json                    | $.store.book[?(@.price in [8.95, 12.99])]              | 2,544.0 ns |  33.98 ns | 2,541.4 ns |             ? | 0.2060 |      - |    3944 B |           ? |
| JsonCons.JsonPath                | $.store.book[?(@.price in [8.95, 12.99])]              |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[?(length(@.author) &gt; 5)]**                  |         **NA** |        **NA** |         **NA** |             **?** |     **NA** |     **NA** |        **NA** |           **?** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[?(length(@.author) &gt; 5)]                  | 4,859.1 ns |  76.47 ns | 4,847.7 ns |             ? | 0.6485 | 0.0076 |   12264 B |           ? |
| BlushingPenguin.JsonPath         | $.store.book[?(length(@.author) &gt; 5)]                  |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| Hyperbee.Json                    | $.store.book[?(length(@.author) &gt; 5)]                  |         NA |        NA |         NA |             ? |     NA |     NA |        NA |           ? |
| JsonCons.JsonPath                | $.store.book[?(length(@.author) &gt; 5)]                  | 1,845.0 ns |  36.69 ns | 1,840.7 ns |             ? | 0.2441 |      - |    4600 B |           ? |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[*]**                                        |   **181.0 ns** |   **3.63 ns** |   **179.9 ns** |      **baseline** | **0.0334** |      **-** |     **632 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[*]                                        | 1,262.3 ns |  20.40 ns | 1,264.6 ns |  6.98x slower | 0.2441 | 0.0019 |    4624 B |  7.32x more |
| BlushingPenguin.JsonPath         | $.store.book[*]                                        |   180.5 ns |   1.84 ns |   180.7 ns |  1.00x faster | 0.0343 |      - |     648 B |  1.03x more |
| Hyperbee.Json                    | $.store.book[*]                                        |   651.7 ns |   9.25 ns |   654.0 ns |  3.60x slower | 0.0696 |      - |    1320 B |  2.09x more |
| JsonCons.JsonPath                | $.store.book[*]                                        |   320.4 ns |   4.54 ns |   320.7 ns |  1.77x slower | 0.0663 |      - |    1248 B |  1.97x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[*].author**                                 |   **244.1 ns** |   **4.90 ns** |   **244.2 ns** |      **baseline** | **0.0415** |      **-** |     **784 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[*].author                                 | 2,388.4 ns |  25.10 ns | 2,391.0 ns |  9.79x slower | 0.3891 | 0.0038 |    7360 B |  9.39x more |
| BlushingPenguin.JsonPath         | $.store.book[*].author                                 |   276.4 ns |   3.90 ns |   276.5 ns |  1.13x slower | 0.0429 |      - |     816 B |  1.04x more |
| Hyperbee.Json                    | $.store.book[*].author                                 | 1,004.5 ns |  20.03 ns | 1,006.7 ns |  4.12x slower | 0.0801 |      - |    1528 B |  1.95x more |
| JsonCons.JsonPath                | $.store.book[*].author                                 |   422.0 ns |   8.34 ns |   421.1 ns |  1.73x slower | 0.0734 |      - |    1384 B |  1.77x more |
|                                  |                                                        |            |           |            |               |        |        |           |             |
| **Newtonsoft.Json**                  | **$.store.book[0].title**                                  |   **224.1 ns** |   **4.38 ns** |   **225.0 ns** |      **baseline** | **0.0403** |      **-** |     **760 B** |            **** |
| &#39;JsonPath.Net (json-everything)&#39; | $.store.book[0].title                                  | 1,729.0 ns |  33.04 ns | 1,724.3 ns |  7.72x slower | 0.3071 | 0.0019 |    5792 B |  7.62x more |
| BlushingPenguin.JsonPath         | $.store.book[0].title                                  |   249.4 ns |   4.88 ns |   249.2 ns |  1.11x slower | 0.0439 |      - |     832 B |  1.09x more |
| Hyperbee.Json                    | $.store.book[0].title                                  |   311.4 ns |   4.52 ns |   311.7 ns |  1.39x slower | 0.0110 |      - |     208 B |  3.65x less |
| JsonCons.JsonPath                | $.store.book[0].title                                  |   405.3 ns |   4.69 ns |   404.6 ns |  1.81x slower | 0.0668 |      - |    1264 B |  1.66x more |

Benchmarks with issues:
  BenchmarkClass.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(!@.isbn)]]
  BenchmarkClass.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(!@.isbn)]]
  BenchmarkClass.'JsonPath.Net (json-everything)': DefaultJob [JsonPath=$.store.book[?(@.author =~ /.*Waugh/)]]
  BenchmarkClass.Hyperbee.Json: DefaultJob [JsonPath=$.store.book[?(@.author =~ /.*Waugh/)]]
  BenchmarkClass.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkClass.'JsonPath.Net (json-everything)': DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkClass.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkClass.JsonCons.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.category in ['fiction','reference'])]]
  BenchmarkClass.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkClass.'JsonPath.Net (json-everything)': DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkClass.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkClass.JsonCons.JsonPath: DefaultJob [JsonPath=$.store.book[?(@.price in [8.95, 12.99])]]
  BenchmarkClass.Newtonsoft.Json: DefaultJob [JsonPath=$.store.book[?(length(@.author) > 5)]]
  BenchmarkClass.BlushingPenguin.JsonPath: DefaultJob [JsonPath=$.store.book[?(length(@.author) > 5)]]
  BenchmarkClass.Hyperbee.Json: DefaultJob [JsonPath=$.store.book[?(length(@.author) > 5)]]
