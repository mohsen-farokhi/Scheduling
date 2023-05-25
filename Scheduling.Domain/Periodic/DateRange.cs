namespace Scheduling.Domain.Periodic;

public class DateRange
{
    public DateRange(DateOnly fromDate, DateOnly toDate)
    {
        FromDate = fromDate;
        ToDate = toDate;
    }

    public DateOnly FromDate { get; private set; }
    public DateOnly ToDate { get; private set; }

    public IEnumerable<DateOnly> EachDay()
    {
        for (var day = FromDate; day <= ToDate; day = day.AddDays(1))
            yield return day;
    }

    public bool IsBetween(DateOnly date) =>
        FromDate <= date && ToDate >= date;
}
