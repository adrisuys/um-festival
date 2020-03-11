using System.Collections.Generic;

public class LineUp
{

    public string Day { get; set; }
    public List<Artist> Artists { get; set; }

    public LineUp(string day)
    {
        Day = day;
        Artists = new List<Artist>();
    }

    public void AddArtist(Artist artist)
    {
        Artists.Add(artist);
        artist.LineUp = this;
    }

    public void RemoveArtist(Artist artist)
    {
        Artists.Remove(artist);
        artist.LineUp = null;
    }
}
