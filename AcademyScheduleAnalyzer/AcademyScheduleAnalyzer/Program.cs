using System.Globalization;
using System.Text;

namespace AcademyScheduleAnalyzer;

class Program
{
    static void Main(string[] args)
    {
        #region Part 1 — Starter Data

        string[] sessionNames =
        {
            "C# Basics",
            "Arrays",
            "Functions",
            "Date and Time",
            "Exception Handling"
        };
        
        DateTime[] sessionDates =
        {
            new DateTime(2026, 9, 10, 18, 0, 0),
            new DateTime(2026, 9, 13, 18, 0, 0),
            new DateTime(2026, 9, 17, 18, 0, 0),
            new DateTime(2026, 9, 20, 18, 0, 0),
            new DateTime(2026, 9, 24, 18, 0, 0)
        };
        
        int[] sessionDurations =
        {
            180,
            240,
            180,
            240,
            180
        };

        #endregion

        #region Run Part 2 — Display All Sessions

        // DisplayAllSessions(sessionNames,sessionDates,sessionDurations);

        #endregion

        #region Run  Part 3 — Search for a Session

        // Console.Write("Enter a session name: ");
        // string sessionName = Console.ReadLine()!;
        //
        // SearchForASession(sessionName, sessionNames, sessionDates, sessionDurations);
        #endregion

        #region Run Part 4 — Array Methods Practice

        #region Run 4.1 Sort Session Names

        // Console.WriteLine("4.1 Sort Session Names");
        // Console.WriteLine($"----------------------");
        // SortSessionNames(sessionNames);
        // Console.WriteLine($"----------------------");

        #endregion

        #region Run 4.2 Reverse Session Names

        // Console.WriteLine("4.2 Reverse Session Names");
        // Console.WriteLine($"----------------------");
        // ReverseSessionNames(sessionNames);
        // Console.WriteLine($"----------------------");

        #endregion

        #region Run 4.3 Find Session Index

        // Console.WriteLine("4.3 Find Session Index");
        // Console.WriteLine($"----------------------");
        // FindSessionIndex(sessionNames);
        // Console.WriteLine($"----------------------");

        #endregion

        #region Run 4.4 Check if a Session Exists

        // Console.WriteLine("4.4 Check if a Session Exists");
        // Console.WriteLine($"----------------------");
        // CheckIfSessionExists(sessionNames);
        // Console.WriteLine($"----------------------");

        #endregion

        #region Run 4.5 Find a Session
        
        // Console.WriteLine("4.5 Find a Session");
        // Console.WriteLine($"----------------------");
        // FindSession(sessionNames);
        // Console.WriteLine($"----------------------");

        #endregion

        #region Run 4.6 Find a Session Index Using a Condition

        // Console.WriteLine("4.6 Find a Session Index Using a Condition");
        // Console.WriteLine($"----------------------");
        // FindSessionIndexUsingCondition(sessionNames);
        // Console.WriteLine($"----------------------");

        #endregion

        #region Run 4.7 Copy an Array

        // Console.WriteLine("4.7 Copy an Array");
        // Console.WriteLine($"----------------------");
        // CopyAnArray(sessionNames);
        // Console.WriteLine($"----------------------");

        #endregion

        #endregion
        
        #region Run Part 5 — Duration Analysis

        // Console.WriteLine("Part 5 — Duration Analysis");
        // Console.WriteLine($"----------------------");
        // Console.WriteLine($"Total Duration: {GetTotalDuration(sessionDurations)} minutes");
        // Console.WriteLine($"Average Duration: {GetAverageDuration(sessionDurations)} minutes");
        // Console.WriteLine($"Shortest Duration: {GetShortestDuration(sessionDurations)} minutes");
        // Console.WriteLine($"Longest Duration: {GetLongestDuration(sessionDurations)} minutes");
        // Console.WriteLine($"Sorted Duration: ");
        // SortSessionDurations(sessionDurations);
        //
        // Console.WriteLine($"----------------------");

        #endregion

        #region Run Part 6 — Functions

        // DisplaySessions(sessionNames);
        // DateTime? endTime = GetSessionEndTime("Functions", sessionNames, sessionDates, sessionDurations);
        // Console.WriteLine($"End Time: {endTime}");
        //
        //
        // DateTime? date = ReadSessionDate();
        // Console.WriteLine($"date: {date}");

        // string s = BuildReportUsingStringBuilder(sessionNames, sessionDates, sessionDurations);
        // Console.WriteLine(s);
        #endregion

        #region Run Part 7 — ref, out, and Reference-Type Parameters

        #region Run 7.1 ref

        // Console.WriteLine("7.1 ref");
        // Console.WriteLine("-------------------");
        // int num = 10;
        // Console.WriteLine($"Before calling TryRefKeyword function: {num}");
        // TryRefKeyword(ref num);
        // Console.WriteLine($"After calling TryRefKeyword function: {num}");
        // Console.WriteLine("-------------------");

        #endregion

        #region Run 7.2 out
        // Console.WriteLine("7.2 out");
        // Console.WriteLine("-------------------");
        // Console.Write("Enter session:");
        // string session = Console.ReadLine()!;
        // bool isExist= GetSessionIndexAndDuration(session, sessionNames, sessionDurations, out int index , out int duration);
        // if(isExist)
        //     Console.WriteLine($"Index: {index}\nDuration: {duration} minutes");
        // else
        //     Console.WriteLine("Session not found.");
        // Console.WriteLine("-------------------");

        #endregion

        #region Run 7.3 Reference Type Without ref

        // Console.WriteLine("7.3 Reference Type Without ref");
        // Console.WriteLine("-------------------");
        // int[] arr = [1,2,3,4,5];
        //
        // Console.WriteLine($"Before calling CheckArrayIfChanged function:");
        // foreach (var item in arr)
        //     Console.Write($"{item}  ");
        //
        // CheckArrayIfChanged(arr);
        //
        // Console.WriteLine($"\nAfter calling CheckArrayIfChanged function: ");
        // foreach (var item in arr)
        //     Console.Write($"{item}  ");
        //
        // Console.WriteLine("\n-------------------");

        #endregion
        
        
        #endregion

        #region Run Part 8 — params Keyword

        // int total = CalculateTotalDuration(120, 180);
        // Console.WriteLine($"Total Duration = {total}");
        // total = CalculateTotalDuration(60, 90, 120, 180, 240);
        // Console.WriteLine($"Total Duration = {total}");

        #endregion


    }

    #region Part 2 — Display All Sessions

    static void DisplayAllSessions(string[] sessionNames , DateTime[] sessionDates , int[] sessionDurations )
    {
        int length = sessionNames.Length;
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"{i+1}. {sessionNames[i]}\n" +
                              $"Date: {DateOnly.FromDateTime(sessionDates[i]).ToString("dd MMMM yyyy")}\n" +
                              $"Start Time: {TimeOnly.FromDateTime(sessionDates[i]).ToString("hh:mm tt")}\n" +
                              $"Duration: {sessionDurations[i]} minutes\n");
            
        }
    }

    #endregion

    #region Part 3 — Search for a Session

    static void SearchForASession(string sessionName , string[] sessionNames , DateTime[] sessionDates , int[] sessionDurations )
    {
        int index = sessionNames.IndexOf(sessionName);
        if (index == -1)
        {
            Console.WriteLine("Session not found.");
            return;
        }
        DisplayAllSessions([sessionNames[index]],[sessionDates[index]],[sessionDurations[index]]);
    }

    #endregion

    #region Part 4 — Array Methods Practice

    #region 4.1 Sort Session Names

    static void SortSessionNames(string[] sessionNames)
    {
        string[] copyOfSessionNames = new string[sessionNames.Length];
        Array.Copy(sessionNames, copyOfSessionNames, sessionNames.Length);
        Array.Sort(copyOfSessionNames);
        foreach (var item in copyOfSessionNames)
        {
            Console.WriteLine(item);
        }
    }

    #endregion

    #region 4.2 Reverse Session Names

    static void ReverseSessionNames(string[] sessionNames)
    {
        string[] copyOfSessionNames = new string[sessionNames.Length];
        Array.Copy(sessionNames, copyOfSessionNames, sessionNames.Length);
        Array.Reverse(copyOfSessionNames);
        foreach (var item in copyOfSessionNames)
        {
            Console.WriteLine(item);
        }
    }

    #endregion

    #region 4.3 Find Session Index

    static void FindSessionIndex(string[] sessionNames)
    {
        Console.Write("Enter session name: ");
        string sessionName = Console.ReadLine()!;
        int index = sessionNames.IndexOf(sessionName);
        if(index == -1)
            Console.WriteLine($"session not found.");
        else
            Console.WriteLine($"Index: {index}");

    }

    #endregion

    #region 4.4 Check if a Session Exists

    static void CheckIfSessionExists(string[] sessionNames)
    {
        Console.Write("Enter session name: ");
        string sessionName = Console.ReadLine()!;
        bool isExist =Array.Exists(sessionNames, name => name.Equals(sessionName,StringComparison.OrdinalIgnoreCase));
        if(isExist)
            Console.WriteLine("Session exists.");
        else
            Console.WriteLine("Session does not exist.");
    }

    #endregion

    #region 4.5 Find a Session

    static void FindSession(string[] sessionNames)
    {
        var sessionName =Array.Find(sessionNames, name => name.Length > 5);
        Console.WriteLine($"Session name: {sessionName}");
    }

    #endregion

    #region 4.6 Find a Session Index Using a Condition

    static void FindSessionIndexUsingCondition(string[] sessionNames)
    {
        var sessionIndex =Array.FindIndex(sessionNames, name => name.Equals("Functions", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine($"Session Index: {sessionIndex}");
    }

    #endregion

    #region 4.7 Copy an Array

    static void CopyAnArray(string[] sessionNames)
    {
        string[] copyOfSessionNames = new string[sessionNames.Length];
        Array.Copy(sessionNames , copyOfSessionNames , sessionNames.Length);
        copyOfSessionNames[0] = "Interfaces";
        
        Console.WriteLine("Original array :");
        foreach (var item in sessionNames)
            Console.WriteLine(item);
        Console.WriteLine("-------------------");
        Console.WriteLine("Copied array :");
        foreach (var item in copyOfSessionNames)
            Console.WriteLine(item);
    }

    #endregion

    #endregion

    #region Part 5 — Duration Analysis

    static int GetTotalDuration(int[] sessionDurations)
    {
        int total = 0;
        for (int i = 0; i < sessionDurations.Length; i++)
        {
            total += sessionDurations[i];
        }
        return total;
    }

    static double GetAverageDuration(int[] sessionDurations)
    {
        return (double)GetTotalDuration(sessionDurations) / sessionDurations.Length;
    }

    static int GetShortestDuration(int[] sessionDurations)
    {
        int shortest = sessionDurations[0];
        foreach (var item in sessionDurations)
            shortest= Math.Min(shortest, item);
        return shortest;
    }
    
    static int GetLongestDuration(int[] sessionDurations)
    {
        int longest = sessionDurations[0];
        foreach (var item in sessionDurations)
            longest= Math.Max(longest, item);
        return longest;
    }

    static void SortSessionDurations(int[] sessionDurations)
    {
        int[] copyOfSessionDurations =  new int[sessionDurations.Length];
        Array.Copy(sessionDurations , copyOfSessionDurations ,  sessionDurations.Length);
        Array.Sort(copyOfSessionDurations);
        foreach (var item in copyOfSessionDurations)
        {
            Console.WriteLine(item);
        }
    }

    #endregion

    #region Part 6 — Functions
    
    /*
     * i already have SearchSession function in part 3 .
     * and i have GetLongestDuration ,GetShortestDuration, GetAverageDuration and GetTotalDuration functions in part 5.
     * and i have DisplaySessionDetails function in part 2.
     */

    static void DisplaySessions(string[] sessionNames)
    {
        for (int i = 0; i < sessionNames.Length; i++)
            Console.WriteLine($"{i+1}- {sessionNames[i]}.");
    }

    static int GetSessionIndex(string sessionName,string[] sessionNames)
    {
        return sessionNames.IndexOf(sessionName);
    }
    static DateTime? GetSessionEndTime(string sessionName, string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        int index =GetSessionIndex(sessionName, sessionNames);
        if (index == -1)
            return null;
        DateTime endTime = sessionDates[index].AddMinutes(sessionDurations[index]);
        return endTime;

    }

    static DateTime? ReadSessionDate()
    {
        Console.Write("Enter session date (yyyy/MM/dd HH:mm): ");
        string date = Console.ReadLine()!;
        if (DateTime.TryParse(date ,out DateTime result))
            return result;
        else
        {
            Console.WriteLine("Invalid date format.");
            return null;
        }
        
    
    }

    static string BuildReportUsingString(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
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

    static string BuildReportUsingStringBuilder(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
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
    

    #endregion

    #region Part 7 — ref, out, and Reference-Type Parameters

    #region 7.1 ref

    static void TryRefKeyword(ref int value) => value++;
    

    #endregion

    #region 7.2 out

    static bool GetSessionIndexAndDuration(string sessionName, string[] sessionNames, int[] sessionDurations,
        out int index, out int duration)
    {
        int ind = GetSessionIndex(sessionName, sessionNames);
        if (ind == -1)
        {
            index = -1;
            duration = -1;
            return false;
        }

        index = ind;
        duration = sessionDurations[ind];
        return true;
    }

    #endregion

    #region 7.3 Reference Type Without ref

    static void CheckArrayIfChanged(int[] arr)
    {
        if (arr.Length > 0)
            arr[0]++;
    }

    #endregion

    #endregion

    #region Part 8 — params Keyword

    static int CalculateTotalDuration(params int[] durations)
    {
        int total = 0;
        foreach (var item in durations)
            total += item;
        
        return total;
    }

    #endregion
    
    
    
    
    
    
}