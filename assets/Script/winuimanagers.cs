using UnityEngine;
using UnityEngine.SceneManagement;

public class winuimanagers : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;

        if (AudioManager.instance != null)
            AudioManager.instance.Stop("GameSceneMusic");

        if (AudioManager.instance != null)
            AudioManager.instance.Play("MainMenuMusic");

        SceneManager.LoadScene("MainMenu");
    }
}

