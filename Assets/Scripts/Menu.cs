using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Hospital_Level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}