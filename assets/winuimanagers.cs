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

        // STOP CURRENT GAME MUSIC BEFORE SWITCHING SCENE
        if (AudioManager.instance != null)
            AudioManager.instance.Stop("GameSceneMusic");

        // PLAY MAIN MENU MUSIC
        if (AudioManager.instance != null)
            AudioManager.instance.Play("MainMenuMusic");

        // NOW LOAD SCENE
        SceneManager.LoadScene("MainMenu");
    }
}
