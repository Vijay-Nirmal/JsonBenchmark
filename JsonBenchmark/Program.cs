using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using JsonBenchmark;

var config = ManualConfig.Create(DefaultConfig.Instance)
                        .WithOptions(ConfigOptions.DisableOptimizationsValidator)
                        .HideColumns("StdDev", "RatioSD")
                        .WithSummaryStyle(SummaryStyle.Default.WithMaxParameterColumnWidth(100)
                                                                .WithRatioStyle(RatioStyle.Trend));

var report = BenchmarkRunner.Run<BenchmarkJsonPath>(config);
