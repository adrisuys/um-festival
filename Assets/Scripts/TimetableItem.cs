using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimetableItem : MonoBehaviour
{
    [HideInInspector] public Timetable timeTable;

    public void OnClick(Button button)
    {
        string artistName = button.name;
        Artist artist = GetArtistFromName(artistName);
        if (artist != null)
        {
            Constants.currentArtist = artist;
        }
        SceneManager.LoadScene(3);
    }

    private Artist GetArtistFromName(string name)
    {
        foreach (var lineUp in timeTable.LineUps)
        {
            foreach (var artist in lineUp.Artists)
            {
                if (artist.Name.Equals(name))
                {
                    return artist;
                }
            }
        }
        return null;
    }
}
