using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // For Slider UI element

public class MenuAudioManager : MonoBehaviour
{
    public AudioClip mainMenuMusic;  // Main menu background music
    public AudioClip buttonClickSound; // Button click sound effect
    private AudioSource audioSource;

    // Slider to control volume
    public Slider volumeSlider; // Reference to the Slider UI component

    // Menu options (you can expand this to more options as needed)
    private enum MenuOption { StartGame, Options, Quit }

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Start playing the main menu music
        PlayBackgroundMusic(mainMenuMusic);

        // Set initial volume based on Slider value
        if (volumeSlider != null)
        {
            volumeSlider.value = audioSource.volume;  // Set slider to current volume
            volumeSlider.onValueChanged.AddListener(OnVolumeChanged);  // Add listener to volume slider change
        }
    }

    // Function to play the background music
    void PlayBackgroundMusic(AudioClip musicClip)
    {
        if (audioSource && musicClip)
        {
            audioSource.clip = musicClip;
            audioSource.loop = true;  // Loop the music
            audioSource.Play();
        }
    }

    // Function to play button click sound
    void PlayButtonClickSound()
    {
        if (audioSource && buttonClickSound)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }
    }

    // Called when the "Start Game" button is clicked
    public void OnStartGameClicked()
    {
        PlayButtonClickSound();
        // Load the game scene (you can change "GameScene" to your actual game scene name)
        SceneManager.LoadScene("GameScene");
    }

    // Called when the "Options" button is clicked
    public void OnOptionsClicked()
    {
        PlayButtonClickSound();
        // Here you would show the options menu (implement your options menu logic)
        Debug.Log("Options menu clicked!");
    }

    // Called when the "Quit" button is clicked
    public void OnQuitClicked()
    {
        PlayButtonClickSound();
        // Quit the game (works in the built version, not in the editor)
        Application.Quit();
    }

    // Function that updates the audio volume based on the slider value
    public void OnVolumeChanged(float value)
    {
        if (audioSource != null)
        {
            audioSource.volume = value;  // Set audio volume based on slider value
        }
    }

    public void ChangeToOptionsMusic()
    {
        // Play options music (if defined)
        // PlayBackgroundMusic(optionsMusic); // Uncomment this line if you have options music.
    }
}