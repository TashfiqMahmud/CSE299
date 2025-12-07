using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameControll : MonoBehaviour
{
    public static GameControll instance;

    [Header("UI")]
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI lose_score_text;
    public TextMeshProUGUI High_score_text;
    public TextMeshProUGUI level_text;
    public TextMeshProUGUI level_complete_text;

    [Header("Panels")]
    public GameObject pause_panel;
    public GameObject losepanel;
    public GameObject exitpanel;
    public GameObject nextlevel_panel;

    [Header("Game Settings")]
    public int score = 0;
    public int life = 0;
    public GameObject[] lifeobj;

    private int level;
    private int bestScore;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Time.timeScale = 1;

        // Load stored values
        level = PlayerPrefs.GetInt("level_count", 1);
        bestScore = PlayerPrefs.GetInt("highscore", 0);

        High_score_text.text = "BestScore " + bestScore;
        score_text.text = "0";

        AudioManager.instance.Play("GameSceneMusic");
    }

    void Update()
    {
        UpdateUI();
        UpdateHighScore();
        UpdateLevelSpeed();
        CheckLevelCompletion();
        CheckLoseCondition();
    }

    // -------------------------
    // UI UPDATE
    // -------------------------
    void UpdateUI()
    {
        score_text.text = score.ToString();
        lose_score_text.text = "Score: " + score;
        level_complete_text.text = "Level complete " + level;
        level_text.text = "Level " + level;
    }

    // -------------------------
    // HIGH SCORE
    // -------------------------
    void UpdateHighScore()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("highscore", bestScore);
            High_score_text.text = "BestScore " + bestScore;
        }
    }

 
// -------------------------
// SPEED CONTROL BASED ON LEVEL
// -------------------------
void SetSpeed(int threshold1, int threshold2, int threshold3)
{
    if (PlayerController.instance == null) return;

    float newSpeed = PlayerController.instance.forwardSpeed;

    if (score >= threshold3)
        newSpeed = threshold3 / 10f + 5f;   // float division
    else if (score >= threshold2)
        newSpeed = threshold2 / 10f + 5f;
    else if (score >= threshold1)
        newSpeed = threshold1 / 10f + 5f;

    PlayerController.instance.forwardSpeed = newSpeed;
}



    void UpdateLevelSpeed()
    {
        if (PlayerController.instance == null) return;

        switch (level)
        {
            case 1: SetSpeed(20, 50, 100); break;
            case 2: SetSpeed(50, 100, 200); break;
            case 3: SetSpeed(50, 100, 200); break;
            case 4: SetSpeed(50, 150, 500); break;
        }
    }

    // -------------------------
    // NEXT LEVEL HANDLING
    // -------------------------
    void CheckLevelCompletion()
    {
        if (level == 1 && score >= 200) UnlockNextLevel(2);
        if (level == 2 && score >= 500) UnlockNextLevel(3);
        if (level == 3 && score >= 1000) UnlockNextLevel(4);
    }

    void UnlockNextLevel(int nextLevel)
    {
        nextlevel_panel.SetActive(true);
        PlayerPrefs.SetInt("level_count", nextLevel);
        level = nextLevel;
        Time.timeScale = 0;
    }

    // -------------------------
    // LIFE SYSTEM
    // -------------------------
    public void LoseLife()
    {
        if (life < lifeobj.Length)
        {
            lifeobj[life].SetActive(false);
            life++;
        }
    }

    public void GainLife()
    {
        if (life > 0)
        {
            life--;
            lifeobj[life].SetActive(true);
        }
    }

    void CheckLoseCondition()
    {
        if (life >= 3)
        {
            losepanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    // -------------------------
    // BUTTONS
    // -------------------------
    public void next_btn()
    {
        Time.timeScale = 1;
        nextlevel_panel.SetActive(false);

        // Reset score & lives for new level
        score = 0;
        life = 0;

        foreach (var l in lifeobj) l.SetActive(true);

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
        Time.timeScale = 0;
        exitpanel.SetActive(true);
    }

    public void exityesno(int i)
    {
        if (i == 1)
        {
            SceneManager.LoadScene(0);
        }
        else
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
