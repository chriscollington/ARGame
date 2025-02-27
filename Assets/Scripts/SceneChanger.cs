using UnityEngine;
using UnityEngine.SceneManagement; // Import this to use SceneManager

public class SceneChanger : MonoBehaviour
{
    // Function to change the scene to "GameScene"
    public void ChangeToGameScene()
    {
        // Load the scene named "GameScene"
        SceneManager.LoadScene("GameScene");
    }
}
