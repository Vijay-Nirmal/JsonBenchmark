﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Json.More;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using JsonCraft.JsonPath;

namespace JsonBenchmark;

[MemoryDiagnoser]
//[ShortRunJob]
public class BenchmarkJsonPath
{
    private string _jsonString;
    private JsonDocument _jsonDocument;
    private System.Text.Json.Nodes.JsonNode _jsonNode;
    private JToken _newtonsoftJson;
    private readonly Consumer _consumer = new Consumer();

    [Params(
        "$.store.book[0].title",
        "$.store.book[*].author",
        "$.store.book[?(@.price < 10)].title",
        "$.store.bicycle.color",
        "$.store.book[*]",                                    // all books
        "$.store..price",                                     // all prices using recursive descent
        "$..author",                                          // all authors using recursive descent
        "$.store.book[?(@.price > 10 && @.price < 20)]",     // filtered by price range
        "$.store.book[?(@.category == 'fiction')]",          // filtered by category
        "$.store.book[-1:]",                                 // last book
        "$.store.book[:2]",                                  // first two books
        "$.store.book[?(@.author =~ /.*Waugh/)]",            // regex match on author
        "$..book[0,1]",                                     // union of array indices
        "$.store.book[?(@.price in [8.95, 12.99])]",       // value in array match
        "$.store.book[?(@.category in ['fiction','reference'])]", // multiple value match
        "$..*",                                             // recursive descent all nodes
        "$..['bicycle','price']",                            // recursive descent specfic node with name match 
        "$.store.book[?(@.author && @.title)]",            // existence check
        "$.store.book[?(!@.isbn)]",                        // non-existence check
        "$.store.*",                                       // wildcard child
        "$.store.book[?(length(@.author) > 5)]"            // function usage
    )]
    public string JsonPath { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _jsonString = """
        {
            "store": {
                "book": [
                    {
                        "category": "reference",
                        "author": "Nigel Rees",
                        "title": "Sayings of the Century",
                        "price": 8.95
                    },
                    {
                        "category": "fiction",
                        "author": "Evelyn Waugh",
                        "title": "Sword of Honour",
                        "price": 12.99
                    }
                ],
                "bicycle": {
                    "color": "red",
                    "price": 19.95
                }
            }
        }
        """;

        _jsonDocument = JsonDocument.Parse(_jsonString);
        _newtonsoftJson = JToken.Parse(_jsonString);
        _jsonNode = _jsonDocument.RootElement.AsNode();
    }

    [Benchmark(Baseline = true, Description = "Newtonsoft.Json")]
    public void Get_NewtonsoftJson()
    {
        var result = _newtonsoftJson.SelectTokens(JsonPath);
        result.Consume(_consumer);
    }

    [Benchmark(Description = "JsonCraft.JsonPath")]
    public void Get_JsonCraftJsonPath()
    {
        var result = _jsonDocument.SelectElements(JsonPath);
        result.Consume(_consumer);
    }

    [Benchmark(Description = "JsonPath.Net (json-everything)")]
    public void Get_JsonPathNet()
    {
        var path = Json.Path.JsonPath.Parse(JsonPath);
        var result = path.Evaluate(_jsonNode);
        result.Matches.Consume(_consumer);
    }

    [Benchmark(Description = "BlushingPenguin.JsonPath")]
    public void Get_BenchmarkBlushingPenguinJsonPath()
    {
        var result = BlushingPenguin.JsonPath.JsonExtensions.SelectTokens(_jsonDocument, JsonPath);
        result.Consume(_consumer);
    }

    [Benchmark(Description = "Hyperbee.Json")]
    public void Get_HyperbeeJson()
    {
        var resut = Hyperbee.Json.Path.JsonPath<JsonElement>.Select(_jsonDocument.RootElement, JsonPath);
        resut.Consume(_consumer);
    }

    [Benchmark(Description = "JsonCons.JsonPath")]
    public void Get_JsonConsJsonPath()
    {
        var result = JsonCons.JsonPath.JsonSelector.Select(_jsonDocument.RootElement, JsonPath);
        result.Consume(_consumer);
    }
}
