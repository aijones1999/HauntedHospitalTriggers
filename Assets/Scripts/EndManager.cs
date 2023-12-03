using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}