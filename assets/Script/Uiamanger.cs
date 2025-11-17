using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Uiamanger : MonoBehaviour
{
    // Start is called before the first frame update




    public TextMeshProUGUI best_score;
    public GameObject[] lockbtn;
    public GameObject exitpanel;
    public GameObject about_panel_game;
    void Start()
    {
        best_score.text = "BestScore: " + PlayerPrefs.GetInt("highscore").ToString();
        Debug.Log(PlayerPrefs.GetInt("level_count"));
        if (PlayerPrefs.GetInt("lock") == 1)
        {
            lockbtn[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("lockl") == 1)
        {
            lockbtn[1].SetActive(false);
            lockbtn[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("lockll") == 1)
        {
            lockbtn[2].SetActive(false);
            lockbtn[1].SetActive(false);
            lockbtn[0].SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        best_score.text = "BestScore: " + PlayerPrefs.GetInt("highscore").ToString();

        if (PlayerPrefs.GetInt("level_count") == 2)
        {
            lockbtn[0].SetActive(false);
            PlayerPrefs.SetInt("lock", PlayerPrefs.GetInt("lock", 1));
        }
        if (PlayerPrefs.GetInt("level_count") == 3)
        {
            lockbtn[1].SetActive(false);
            lockbtn[0].SetActive(false);
            PlayerPrefs.SetInt("lockl", PlayerPrefs.GetInt("lockl", 1));
        }
        if (PlayerPrefs.GetInt("level_count") == 4)
        {
            lockbtn[2].SetActive(false);
            lockbtn[1].SetActive(false);
            lockbtn[0].SetActive(false);
            PlayerPrefs.SetInt("lockll", PlayerPrefs.GetInt("lockll", 1));
        }
    }

    public void level1_play()
    {
       // PlayerPrefs.SetInt("level_count", PlayerPrefs.GetInt("level_count", 1));
        SceneManager.LoadScene(1);
    }


    public void level(int lv)
    {
        if (lv != 0)
        {
          
            if (lv == 1)
            {
                PlayerPrefs.SetInt("level_count", 1);

            }
            if (lv == 2)
            {
                PlayerPrefs.SetInt("level_count", 2);

            }
            if (lv == 3)
            {
                PlayerPrefs.SetInt("level_count", 3);

            }
            if (lv == 4)
            {
                PlayerPrefs.SetInt("level_count", 4);

            }

            SceneManager.LoadScene(1);
        }
    }
    public void exit()
    {
        exitpanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void exityesno(int i)
    {
        if (i == 1)
        {
            Application.Quit();
        }
        if (i == 2)
        {
            exitpanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void about_panel()
    {
        about_panel_game.SetActive(true);
    }
    public void about_panel_exit()
    {
        about_panel_game.SetActive(false);
    }
}
