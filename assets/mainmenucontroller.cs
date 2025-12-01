using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenucontroller : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Part1"); // Replace with your gameplay scene name
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("MenuScene"); // Optional
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
