using System.Text;
using BenchmarkDotNet.Attributes;

namespace AcademyScheduleAnalyzer;

public class ScheduleBenchmark
{
    
    private string[] sessionNames =
    {
        "C# Basics",
        "Arrays",
        "Functions",
        "Date and Time",
        "Exception Handling"
    };
        
    private DateTime[] sessionDates =
    {
        new DateTime(2026, 9, 10, 18, 0, 0),
        new DateTime(2026, 9, 13, 18, 0, 0),
        new DateTime(2026, 9, 17, 18, 0, 0),
        new DateTime(2026, 9, 20, 18, 0, 0),
        new DateTime(2026, 9, 24, 18, 0, 0)
    };
        
    private int[] sessionDurations =
    {
        180,
        240,
        180,
        240,
        180
    };

    [Benchmark]
    public string StringConcatenation()
    {
        string allDetails = "";
        int length = sessionNames.Length;
        for (int i = 0; i < length; i++)
        {
            allDetails +=
                $"Session Name: {sessionNames[i]}" +
                $" - Session Date: {sessionDates[i].ToString()}" +
                $" - Session Duration: {sessionDurations[i].ToString()} minutes \n";
        }

        return allDetails;
    }
    [Benchmark]
    public string StringBuilderConcatenation()
    {
        StringBuilder allDetails = new StringBuilder();
                int length = sessionNames.Length;
                for (int i = 0; i < length; i++)
                {
                    allDetails.Append($"Session Name: {sessionNames[i]}" +
                                      $" - Session Date: {sessionDates[i].ToString()}" +
                                      $" - Session Duration: {sessionDurations[i].ToString()} minutes \n");
                }
        
                return allDetails.ToString();
    }

}