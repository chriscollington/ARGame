using UnityEngine;

public class MenuChange : MonoBehaviour
{
    // Function to exit the game (in Build) or log a message in the Editor
    public void ExitGame()
    {
        // Check if the game is running in the Unity Editor
        if (Application.isPlaying)
        {
            // Log a message when in Play Mode
            Debug.Log("Quit button pressed - exiting game.");
        }
        else
        {
            // If not in Play Mode (i.e., in the Editor), show a debug message
            Debug.Log("In Play Mode - Would quit here.");
        }

        // For actual builds, you can still use Application.Quit() (in non-Editor mode)
#if !UNITY_EDITOR
        Application.Quit();
#endif
    }
}
