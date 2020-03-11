using UnityEngine;
using UnityEngine.SceneManagement;

public class NavBottomBar : MonoBehaviour
{
    public void DisplayMap()
    {
        SceneManager.LoadScene(1);
    }

    public void DisplayTimeTable()
    {
        SceneManager.LoadScene(2);
    }
}
