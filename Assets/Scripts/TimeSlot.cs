public class TimeSlot
{
    public int Hour { get; set; }
    public int Minutes { get; set; }

    public TimeSlot(int hour, int minutes)
    {
        Hour = hour;
        Minutes = minutes;
    }

    public int GetTotalMinutes()
    {
        return Minutes + (60 * (Hour - 14));
    }

    public string TimeAsString()
    {
        return Hour.ToString() + ":" + Minutes.ToString("00");
    }
}
