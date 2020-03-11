using UnityEngine;
using UnityEngine.UI;

public class PoI : MonoBehaviour
{
    public GameObject infosBox;

    public void DisplayInfosBox()
    {
        infosBox.GetComponentInChildren<Text>().text = transform.name;
        infosBox.SetActive(true);
        Invoke("HideInfosBox", 5f);
    }

    private void HideInfosBox()
    {
        infosBox.SetActive(false);
    }

}
