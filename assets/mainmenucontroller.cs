using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenucontroller : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.Play("MainMenuMusic");
    }

    public void StartGame()
    {
        AudioManager.instance.Stop("MainMenuMusic");
        AudioManager.instance.Play("GameSceneMusic");
        SceneManager.LoadScene("Part1"); 
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

    public GameObject MenuPanel; 

  
    public void CloseMenu()
    {
        MenuPanel.SetActive(false);
    }
}

