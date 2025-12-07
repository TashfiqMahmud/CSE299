using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuPanel;

    private bool isPaused = false;

    void Start()
    {
        pauseMenuPanel.SetActive(false); 
    }


    public void TogglePause()
    {
        isPaused = !isPaused;
        pauseMenuPanel.SetActive(isPaused);

        if (isPaused)
            Time.timeScale = 0f; 
        else
            Time.timeScale = 1f;  
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
       
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); 
        AudioManager.instance.Stop("GameSceneMusic");
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Part1"); 
        
    }
}

