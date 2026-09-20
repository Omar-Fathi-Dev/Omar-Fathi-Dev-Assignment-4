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

        DisplayAllSessions(sessionNames,sessionDates,sessionDurations);

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
}