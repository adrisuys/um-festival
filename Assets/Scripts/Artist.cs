public class Artist
{
    public string Name { get; set; }
    public TimeSlot StartTime { get; set; }
    public int Duration { get; set; }
    public string Description { get; set; }
    public string Stage { get; set; }
    public LineUp LineUp { get; set; }
    public string Url { get; set; }

    public Artist(string name, TimeSlot startTime, int duration, string description, string stage, string url)
    {
        Name = name;
        StartTime = startTime;
        Duration = duration;
        Description = description;
        Stage = stage;
        Url = url;
    }
}
