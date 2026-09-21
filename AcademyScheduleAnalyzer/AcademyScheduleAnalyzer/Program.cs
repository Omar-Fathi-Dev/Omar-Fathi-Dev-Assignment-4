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

        #region Run Part 9 — Session Date Details

        // Console.Write("Enter Session Name: ");
        // string name = Console.ReadLine()!;
        //
        // GetSessionDateDetails(name ,sessionNames, sessionDates, sessionDurations);

        #endregion

        #region Run Part 10 — Date Difference

        // Console.WriteLine("Date Difference");
        // Console.WriteLine("---------------");
        // Console.Write("First Session: ");
        // string sessionOne = Console.ReadLine()!;
        //
        // Console.Write("Second Session: ");
        // string sessionTwo = Console.ReadLine()!;
        // GetTwoSessionsDateDifference(sessionOne, sessionTwo , sessionNames, sessionDates);

        #endregion

        #region Run Part 11 — Past and Upcoming Sessions

        // DisplayPastOrUpcomingSessions(sessionNames, sessionDates);

        #endregion

        #region Run Part 12 — Find the Next Session

        // FindNextSession(sessionNames, sessionDates);

        #endregion

        #region Run Part 13 — Date Formatting

        // Console.Write("Enter Session Name: ");
        // string session = Console.ReadLine()!;
        // DisplaySessionDateFormats(session, sessionNames, sessionDates);

        #endregion

        #region Run Part 14 — Read and Validate a Date

        // DateTime dateTime = ReadDateTimeInput();
        // Console.WriteLine($"User Date: {dateTime}");

        #endregion

        #region Run Part 15 — Exception Handling: Menu Input

        // int option = ReadMenuInput();
        // Console.WriteLine($"Option: {option}");

        #endregion

        #region Run Part 16 — Exception Handling: Invalid Array Index

        // GetSessionByIndex(sessionNames);

        #endregion

        #region Run Part 17 — Throw an Exception And Part 18 — finally

        // try
        // {
        //     CheckValidDuration();
        // }
        // catch (ArgumentException e)
        // {
        //     Console.WriteLine(e.Message);
        // }
        // finally{
        //     Console.WriteLine("Input operation finished.");
        // }

        #endregion

        #region Run Part 19 — Build a Schedule Report Using string

        // string report = BuildScheduleReportUsingString(sessionNames, sessionDates, sessionDurations);
        // Console.WriteLine(report);
        #endregion

        #region Run Part 20 — Build the Same Report Using StringBuilder

        // string report = BuildScheduleReportUsingStringBuilder(sessionNames, sessionDates, sessionDurations);
        // Console.WriteLine(report);

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
        return Array.FindIndex(sessionNames, name => name.Equals(sessionName, StringComparison.OrdinalIgnoreCase));
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

    #region Part 9 — Session Date Details

    static void GetSessionDateDetails(string sessionName, string[] sessionNames, DateTime[] sessionDates,
        int[] sessionDurations)
    {
       
       int index = GetSessionIndex(sessionName,  sessionNames);
       if (index == -1)
       {
           Console.WriteLine("Session not found.");
           return;
       }
       
       Console.WriteLine($"Date: {sessionDates[index].ToString("dd MMMM yyyy")}");
       Console.WriteLine($"Day: {sessionDates[index].DayOfWeek}");
       Console.WriteLine($"Year: {sessionDates[index].Year}");
       Console.WriteLine($"Month: {sessionDates[index].Month}");
       Console.WriteLine($"Day Number: {sessionDates[index].Day}");
       Console.WriteLine($"Start Time: {sessionDates[index].ToString("hh:mm tt")}");
       Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
       DateTime endTime = sessionDates[index].AddMinutes(sessionDurations[index]);
       Console.WriteLine($"End Time: {endTime.ToString("hh:mm tt")}");
    }

    #endregion

    #region  Part 10 — Date Difference

    static void GetTwoSessionsDateDifference(string sessionOne , string sessionTwo , string[] sessionNames , DateTime[] sessionDates)
    {
        int index1 = GetSessionIndex(sessionOne,  sessionNames);
        if (index1 == -1)
        {
            Console.WriteLine($"{sessionOne} session not found.");
            return;
        }
        int index2 = GetSessionIndex(sessionTwo,  sessionNames);
        if (index2 == -1)
        {
            Console.WriteLine($"{sessionTwo} session not found.");
            return;
        }

        TimeSpan diff;
        if (sessionDates[index1] > sessionDates[index2])
            diff = sessionDates[index1] - sessionDates[index2];
        else
            diff = sessionDates[index2] - sessionDates[index1];

        Console.WriteLine("Difference: ");
        Console.WriteLine($"{diff.Days} days\n" +
                          $"{diff.TotalHours} hours");
    }

    #endregion

    #region Part 11 — Past and Upcoming Sessions

    static void DisplayPastOrUpcomingSessions(string[] sessionNames , DateTime[] sessionDates)
    {
        DateTime now =  DateTime.Now;
        for (int i = 0; i < sessionNames.Length; i++)
        {
            if(now > sessionDates[i])
                Console.WriteLine($"{sessionNames[i]} Past");
            else
                Console.WriteLine($"{sessionNames[i]} Upcoming");
        }
    }

    #endregion
    
    #region Part 12 — Find the Next Session

    static void FindNextSession(string[] sessionNames, DateTime[] sessionDates)
    {
        DateTime now =  DateTime.Now;
        int index =-1;
        for (int i = 0; i < sessionNames.Length; i++)
        {
            if (sessionDates[i] > now)
            {
                index = i;
                break;
            }
                
        }

        if (index == -1)
        {
            Console.WriteLine("No session found.");
            return;
        }

        Console.WriteLine("Next Session: ");
        Console.WriteLine(sessionNames[index]);
        Console.WriteLine(sessionDates[index].ToString("dd MMMM yyyy"));
        Console.WriteLine(sessionDates[index].ToString("hh:mm tt"));
        Console.WriteLine("Time Remaining: ");
        TimeSpan timeSpan =sessionDates[index] -  now ;
        Console.WriteLine($"{timeSpan.Days} days");
        Console.WriteLine($"{timeSpan.Hours} hours");
        
            
        
    }

    #endregion

    #region Part 13 — Date Formatting

    static void DisplaySessionDateFormats(string sessionName , string[] sessionNames, DateTime[] sessionDates)
    {
        int index = GetSessionIndex(sessionName,  sessionNames);
        if (index == -1)
        {
            Console.WriteLine("Session  not found.");
            return;
        }
        Console.WriteLine(sessionDates[index].ToString("yyyy-MM-dd"));
        Console.WriteLine(sessionDates[index].ToString("dd/MM/yyyy"));
        Console.WriteLine(sessionDates[index].ToString("dd MMMM yyyy"));
        Console.WriteLine(sessionDates[index].ToString("dddd, dd MMMM yyyy"));
        Console.WriteLine(sessionDates[index].ToString("hh:mm tt"));
        
        
        
    }

    #endregion

    #region Part 14 — Read and Validate a Date

    static bool CheckValidateDate(string input, string format , out DateTime dateTime) 
    {
        return (DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
            out dateTime));
    }
    
    static DateTime ReadDateTimeInput()
    {
        DateTime dateTime;
        string format = "yyyy-MM-dd HH:mm";
        string input;
        bool isValid  = false;
        do
        {
            Console.Write($"Please enter the date and time in the following format: {format}: ");
            input = Console.ReadLine()!;
            isValid  = CheckValidateDate(input, format, out dateTime);

        } while (isValid  == false);

        return dateTime;
    }

    #endregion

    #region Part 15 — Exception Handling: Menu Input

    static int ReadMenuInput()
    {
        string input;
        int option = 0 ;
        bool isValid = false;
        do
        {
            Console.Write("Choose an option: ");
            input = Console.ReadLine()!;
            try
            {
                option = int.Parse(input);
                isValid = true;
            }
            catch (FormatException) 
            {
                Console.WriteLine("Invalid menu option. Enter a number.");
            }
            
        } while (!isValid);

        return option;
    }
    
    #endregion
    
    #region Part 16 — Exception Handling: Invalid Array Index

    static int GetNumberFromUser()
    {
        int number;
        bool isValid ;
        string input;
        do
        {
            
            input = Console.ReadLine()!;
            isValid = int.TryParse(input, out number);
            if (!isValid)
            {
                Console.WriteLine("Invalid input. Enter a number.");
                Console.Write("Enter a number: ");
            }
        } while (!isValid);

        return number;
    }
    static void GetSessionByIndex(string[] sessionNames)
    {
        Console.Write("Enter session index: ");
        int index = GetNumberFromUser();
        
        try
        {
            Console.WriteLine($"Session: {sessionNames[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("The selected session index is out of range.");
        }
    }

    #endregion

    #region Part 17 — Throw an Exception And Part 18 — finally

    static void CheckValidDuration()
    {
        int duration;
        Console.Write("Enter duration: ");
        duration = GetNumberFromUser();
        
        if (duration > 0)
            Console.WriteLine("Duration accepted.");
        else
            throw new ArgumentException("Duration must be greater than zero.");

    }

    #endregion

    #region Part 19 — Build a Schedule Report Using string

    // I will reuse this function from part 6.
    
    static string BuildScheduleReportUsingString(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        return BuildReportUsingString(sessionNames , sessionDates , sessionDurations );
    }

    #endregion

    #region Part 20 — Build the Same Report Using StringBuilder

    // I will reuse this function from part 6.
    
    static string BuildScheduleReportUsingStringBuilder(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
    {
        return BuildReportUsingStringBuilder(sessionNames , sessionDates , sessionDurations );
    }

    #endregion

    #region Part 21 — BenchmarkDotNet

        

    #endregion

    
    
}