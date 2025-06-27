using UnityEngine;

public class ExitGame : MonoBehaviour
{
    void Update()
    {
        // Exit when the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Stops Play Mode in Editor
        #else
            Application.Quit(); // Quits the application in a build
        #endif
    }
}