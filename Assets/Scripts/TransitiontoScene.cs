using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionTrigger : MonoBehaviour
{
    // Name of the scene to transition to
    public string Toon_Hospital_Level;

    // Trigger when player enters the collider
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Load the specified scene
            SceneManager.LoadScene(Toon_Hospital_Level);
        }
    }
}