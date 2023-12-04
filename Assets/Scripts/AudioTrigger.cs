using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip audioClip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(audioClip, transform.position);
           
        }
    }
}