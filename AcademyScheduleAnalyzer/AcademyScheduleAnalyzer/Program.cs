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
}