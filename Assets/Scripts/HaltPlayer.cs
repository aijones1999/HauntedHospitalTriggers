using UnityEngine;

public class HaltMovementOnCollision : MonoBehaviour
{
    private bool movementHalted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Change "Player" to the tag of your player GameObject
        {
            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();
            if (playerRigidbody != null && !movementHalted)
            {
                // Halt player movement by setting velocity to zero
                playerRigidbody.velocity = Vector3.zero;

                // Set a flag to indicate that movement is halted
                movementHalted = true;

                // Invoke the ResumeMovement function after 5 seconds
                Invoke("ResumeMovement", 5f);
            }
        }
    }

    private void ResumeMovement()
    {
        // Reset the flag to allow movement again
        movementHalted = false;
    }
}