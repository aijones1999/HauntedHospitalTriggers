using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioClip audioClip; // Drag and drop your audio clip to this variable in the Unity Editor
    private AudioSource audioSource;

    void Start()
    {
        // Initialize the AudioSource component
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If there is no AudioSource component, add one
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Play the selected audio clip
            if (audioClip != null)
            {
                audioSource.PlayOneShot(audioClip);
            }
        }
    }
}