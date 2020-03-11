using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void GoToLineUp()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToMap()
    {
        SceneManager.LoadScene(1);
    }
}
