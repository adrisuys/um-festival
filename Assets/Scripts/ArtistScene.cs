using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArtistScene : MonoBehaviour
{
    public TextMeshProUGUI stageName;
    public TextMeshProUGUI intro;
    public TextMeshProUGUI description;
    public Image picture;
    [SerializeField] Sprite[] artistPictures;
    private Artist thisArtist;

    private void Start()
    {
        thisArtist = Constants.currentArtist;
        if (thisArtist != null)
        {
            DisplayInfos();
        }

    }

    private void DisplayInfos()
    {
        stageName.text = thisArtist.Name.ToUpper();
        description.text = thisArtist.Description;
        intro.text = SetIntroText();
        picture.sprite = SetPicture();
    }

    private Sprite SetPicture()
    {
        foreach (var item in artistPictures)
        {
            if (item.name.Equals(thisArtist.Name))
            {
                return item;
            }
            if (item.name.Equals("MinorMinor") && thisArtist.Name.Equals("Minor/Minor"))
            {
                return item;
            }
        }
        return artistPictures[artistPictures.Length - 1];
    }

    private string SetIntroText()
    {
        return thisArtist.Name + " will performed on the stage '" + thisArtist.Stage + "' at " + thisArtist.StartTime.TimeAsString() + " on " + thisArtist.LineUp.Day;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }
    }

    public void GoBack()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenUrl()
    {
        Application.OpenURL(thisArtist.Url);
    }
}
