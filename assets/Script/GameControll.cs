using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameControll : MonoBehaviour
{
    public static GameControll instance;

    public TextMeshProUGUI score_text;
    public TextMeshProUGUI lose_score_text;
    public TextMeshProUGUI High_score_text;
    public int score;
    public int life;
    public GameObject[] lifeobj;
    public GameObject pause_panel;
    public GameObject losepanel;
    public GameObject exitpanel;
    public GameObject nextlevel_panel;
    public TextMeshProUGUI level_text;
    public TextMeshProUGUI level_complete_text;
   
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        score = 0;
        life = 0;
        score_text.text = "" + score;
        PlayerPrefs.SetInt("level_count", PlayerPrefs.GetInt("level_count", 1));
        //PlayerPrefs.SetInt("next", PlayerPrefs.GetInt("next", 0));
        //PlayerPrefs.SetInt("next", PlayerPrefs.GetInt("next1", 0));
        High_score_text.text = "BestScore " + PlayerPrefs.GetInt("highscore", 0).ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "" + score;
        lose_score_text.text = "Score: " + score;
        level_complete_text.text = "Level complete " + PlayerPrefs.GetInt("levelshow").ToString() ;
        if (score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);


            High_score_text.text = "BestScore " + score.ToString();


        }
        if (life == 3)
        {
            losepanel.SetActive(true);
            Time.timeScale = 0;
        }

        if (PlayerPrefs.GetInt("level_count") == 1)
        {
            level_text.text = "Level " + 1;
            if(score >= 20)
            {
                Player_Movement.instance.playerSpeed = 5;
            }
            if( score >= 50 && score <= 100)
            {
                Player_Movement.instance.playerSpeed = 6;
            }
            if (score > 100 && score <= 200)
            {
                Player_Movement.instance.playerSpeed = 7;
            }
           
        }
        if (PlayerPrefs.GetInt("level_count") == 2)
        {
            level_text.text = "Level " + 2;
            if (score >= 50)
            {
                Player_Movement.instance.playerSpeed = 6;
            }
            if (score >= 100 && score <= 200)
            {
                Player_Movement.instance.playerSpeed = 7;
            }
            if (score > 200 && score <= 500)
            {
                Player_Movement.instance.playerSpeed = 8;
            }
           
        }
        if (PlayerPrefs.GetInt("level_count") == 3)
        {
            level_text.text = "Level " + 3;
            if (score >= 50)
            {
                Player_Movement.instance.playerSpeed = 7;
            }
            if (score >= 100 && score <= 200)
            {
                Player_Movement.instance.playerSpeed = 8;
            }
            if (score > 200 && score <= 1000)
            {
                Player_Movement.instance.playerSpeed = 9;
            }
           
        }

        if (PlayerPrefs.GetInt("level_count") == 4)
        {
            level_text.text = "Level " + 4;
            if (score >= 50)
            {
                Player_Movement.instance.playerSpeed = 8;
            }
            if (score >= 150 && score <= 500)
            {
                Player_Movement.instance.playerSpeed = 9;
            }
            if (score > 500 )
            {
                Player_Movement.instance.playerSpeed = 10;
            }
           
        }

        if(score >= 200 && PlayerPrefs.GetInt("level_count") == 1 /*&& PlayerPrefs.GetInt("next") != 1*/)
        {
            nextlevel_panel.SetActive(true);
            //PlayerPrefs.SetInt("next", PlayerPrefs.GetInt("next", 1));
            PlayerPrefs.SetInt("level_count", 2);
            PlayerPrefs.SetInt("levelshow", PlayerPrefs.GetInt("levelshow",1));
           
            Time.timeScale = 0;
        }
        if (score >= 500 && PlayerPrefs.GetInt("level_count") == 2 /*&& PlayerPrefs.GetInt("next_l") != 1*/)
        {
            nextlevel_panel.SetActive(true);
           // PlayerPrefs.SetInt("next_l", PlayerPrefs.GetInt("next_l", 1));
            PlayerPrefs.SetInt("level_count", 3);
            PlayerPrefs.SetInt("levelshow", PlayerPrefs.GetInt("levelshow",2));
            Time.timeScale = 0;
        }
        if (score >= 1000 && PlayerPrefs.GetInt("level_count") == 3 /*&& PlayerPrefs.GetInt("next_ll") != 1*/)
        {
            nextlevel_panel.SetActive(true);
           // PlayerPrefs.SetInt("next_ll", PlayerPrefs.GetInt("next_ll", 1));
            PlayerPrefs.SetInt("level_count", 4);
            PlayerPrefs.SetInt("levelshow", PlayerPrefs.GetInt("levelshow", 3));
            Time.timeScale = 0;
        }

    }

    public void lifebk()
    {
        if (life != 3)
        {
            lifeobj[life].SetActive(false);
            life++;
        }
    }
    public void lifeless()
    {
       if(life == 1)
        {
            lifeobj[0].SetActive(true);
            life--;
        }
        if (life == 2)
        {
            lifeobj[1].SetActive(true);
            life--;
        }
    }
    public void next_btn()
    {
        Time.timeScale = 1;
        nextlevel_panel.SetActive(false);
        score = 0;
        for(int i = 0; i < lifeobj.Length; i++)
        {
            lifeobj[i].SetActive(true);
        }
        life = 0;
        SceneManager.LoadScene(1);
    }
    public void pause_game()
    {
        Time.timeScale = 0;
        pause_panel.SetActive(true);
    }
    public void play_game()
    {
        Time.timeScale = 1;
        pause_panel.SetActive(false);
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
            SceneManager.LoadScene(0);
        }
        if(i == 2)
        {
            exitpanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

  

    public void restart_game()
    {
        SceneManager.LoadScene(1);
    }
    public void Home_game()
    {
        SceneManager.LoadScene(0);
    }
}
