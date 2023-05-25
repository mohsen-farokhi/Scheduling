namespace Scheduling.Domain.Periodic;

public class TimeRage
{
    public TimeRage(TimeOnly beginTime, TimeOnly endTime)
    {
        BeginTime = beginTime;
        EndTime = endTime;
    }

    public TimeOnly BeginTime { get; private set; }
    public TimeOnly EndTime { get; private set; }
}