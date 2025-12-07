using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenucontroller : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.Play("MainMenuMusic"); // Play gameplay music
    }

    public void StartGame()
    {
        AudioManager.instance.Stop("MainMenuMusic");
        AudioManager.instance.Play("GameSceneMusic");
        SceneManager.LoadScene("Part1"); // Replace with your gameplay scene name
    }

    public void OpenMenu()
    {
        MenuPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public GameObject MenuPanel; // Drag your MenuPanel here in Inspector

    // Optional: Close menu panel (add a Close button)
    public void CloseMenu()
    {
        MenuPanel.SetActive(false);
    }
}
