using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Required to manage scenes

public class SceneChanger : MonoBehaviour
{
    // This method will be called when the Play button is clicked
    public void OnPlayButtonClicked()
    {
        // Change the scene to the game scene (replace "GameScene" with the name of your scene)
        SceneManager.LoadScene("GameScene");
    }
}