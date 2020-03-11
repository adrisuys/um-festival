using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Constants;

public class DayPanel : MonoBehaviour
{
    public GameObject leftPanel;
    public GameObject centerPanel;
    public GameObject rightPanel;
    public Button btnPrefab;
    public Timetable timetable;

    public void InstantiatePanel(LineUp lineup)
    {
        GenerateLineUp(lineup);
    }

    private void GenerateLineUp(LineUp lineUp)
    {
        float ratio = 40 / 60f;
        foreach (var artist in lineUp.Artists)
        {
            float size = ratio * artist.Duration;
            float positionY = 185 - (ratio * artist.StartTime.GetTotalMinutes());
            Button btn = Instantiate(btnPrefab);
            btn.name = artist.Name;
            btn.gameObject.GetComponent<TimetableItem>().timeTable = timetable;
            SetPositionX(artist, btn);
            btn.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0.5f);
            btn.GetComponent<RectTransform>().anchorMax = new Vector2(1, 0.5f);
            btn.GetComponent<RectTransform>().pivot = new Vector2(0.5f, 1);
            btn.GetComponent<RectTransform>().localScale = new Vector3(1, size / 40, 1);
            btn.GetComponent<RectTransform>().localPosition = new Vector3(0, positionY, 0);
            btn.GetComponentInChildren<TextMeshProUGUI>().text = artist.StartTime.TimeAsString() + " - " + artist.Name;
            btn.GetComponent<Image>().color = Color.black;
            btn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(231 / 255f, 154 / 255f, 65 / 255f, 1);
        }
    }

    private void SetPositionX(Artist a, Button obj)
    {
        if (a.Stage.Equals(Stage.STAGE_01))
        {
            obj.gameObject.transform.SetParent(leftPanel.transform); // blanc cassé sur noir/gris
        }
        else if (a.Stage.Equals(Stage.STAGE_02))
        {
            obj.gameObject.transform.SetParent(centerPanel.transform); // noir sur orange
        }
        else
        {
            obj.gameObject.transform.SetParent(rightPanel.transform); // orange sur noir
        }
    }
}
