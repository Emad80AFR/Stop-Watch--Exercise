using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace C_sharp.Exercises__2_;

public static class Menu
{
    public static void ShowMenu()
    {   Console.Clear();
        Console.WriteLine("---------------------------STOP WATCH------------------------------");
        Console.WriteLine("1.start stop watch\n" +
                          "2.stop stop watch\n" +
                          "3.get duration\n" +
                          "4.reset stop watch\n" +
                          "5.exit");
        var inputValue = Console.ReadLine();
        if (inputValue != null) Process(inputValue);
    }

    public static void Process(string process)
    {
        switch (process)
        {
            case "1":
                if (StopWatch.CheckStopWatchForStart())
                {
                    StopWatch.Start();
                    ShowMenu();
                }
                else
                    throw new InvalidOperationException();
                break;
            case "2":
                if (StopWatch.CheckStopWatchForStop())
                {
                    StopWatch.Stop();
                    ShowMenu();
                }
                else
                    throw new InvalidOperationException();
                break;
            case "3":
                if (!StopWatch.CheckStopWatchForStart() && !StopWatch.CheckStopWatchForStop())
                {
                    Console.WriteLine(StopWatch.DurationStopWatch());
                    Console.WriteLine("For seeing menu , press any key!");
                    Console.ReadLine();
                    ShowMenu();
                }
                else
                    throw new InvalidOperationException();
                break;
            case "4": 
                StopWatch.ResetStopWatch();
                ShowMenu();
                break;
            case "5":
                Console.Clear();
                Environment.Exit(0);
                break;



        }
    } 

}