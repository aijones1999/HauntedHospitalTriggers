using UnityEngine;

public class CursorVisible : MonoBehaviour
{
    private void Start()
    {
        // Show and unlock the cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}