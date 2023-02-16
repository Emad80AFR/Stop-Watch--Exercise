namespace C_sharp.Exercises__2_;

public static class StopWatch
{   
    private static DateTime _startTime;
    private static DateTime _endTime;
    public static void Start()
    {
        _startTime = DateTime.Now;
    }

    public static void Stop()
    {
        _endTime = DateTime.Now;
    }

    public static TimeSpan DurationStopWatch()
    {
        var durationTimeSpan = _endTime - _startTime;
        return durationTimeSpan;
    }

    public static void ResetStopWatch()
    {
        _startTime = DateTime.MinValue;
        _endTime = DateTime.MinValue;
    }

    public static bool CheckStopWatchForStart()
    {
        if (_startTime == DateTime.MinValue)
            return true;
        return false;

    }
    public static bool CheckStopWatchForStop()
    {
        if (_endTime == DateTime.MinValue)
            return true;
        return false;

    }

}