using System;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _activityDescription;
    private string _activityName;
    private static int _spinnerCounter = 0;
    private static int _userSessionLengthInput = 0;

    public Activity()
    {
        _spinnerCounter = 0;
        _userSessionLengthInput = 0;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public int GetUserSessionLengthInput()
    {
        return _userSessionLengthInput;
    }

    public void DisplayStartingMessage()
    {
        _startingMessage = $"Welcome to the {_activityName}.";
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        _endingMessage = $"You have completed {_userSessionLengthInput} seconds of the {_activityName}.";

        Console.WriteLine();
        Console.WriteLine("Well done!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        DisplaySpinner(5);
        // Optionally clear console after some time
        // Console.Clear();
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Console.Write(" ");
    }

    public void DisplayCountdown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLength()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int sessionLength))
        {
            _userSessionLengthInput = sessionLength;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            DisplayGetSessionLength(); // Recursive call to handle invalid input
        }
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        DisplaySpinner(5);
    }

    public void RunActivityParentStart()
    {
        DisplayStartingMessage();
        DisplayDescription();
        DisplayGetSessionLength();
        DisplayGetReady();
        // Console.Clear(); // Consider removing or moving this for better user experience
    }

    public void RunActivityParentEnd()
    {
        DisplayEndingMessage();
    }
}
