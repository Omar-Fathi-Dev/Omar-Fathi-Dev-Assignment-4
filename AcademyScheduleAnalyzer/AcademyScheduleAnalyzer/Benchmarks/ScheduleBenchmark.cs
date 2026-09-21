using System.Text;
using BenchmarkDotNet.Attributes;

namespace AcademyScheduleAnalyzer;

[MemoryDiagnoser]
public class ScheduleBenchmark
{
    
    [Params(100, 1000, 10000, 100000)]
    public int Iterations;
    
    [Benchmark]
    public string StringConcatenation()
    {
        string result = "";

        for (int i = 0; i < Iterations; i++)
        {
            result += "Hello";
        }

        return result;
    }
    [Benchmark]
    public string StringBuilderConcatenation()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < Iterations; i++)
        {
            result.Append("Hello");
        }

        return result.ToString();
    }

}