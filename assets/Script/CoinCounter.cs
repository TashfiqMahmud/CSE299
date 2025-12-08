using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public int totalCoins = 100;
    private int currentCoins = 0;

    public GameObject winPanel; 
    public TMP_Text coinText;     
    public TMP_Text timeText;     

    private float timer = 0f;
    private bool gameRunning = true;

    void Awake()
    {
        instance = this;
        UpdateUI();
    }

    void Update()
    {
        if (gameRunning)
        {
            timer += Time.deltaTime;
        }
    }

    public void AddCoin()
    {
        currentCoins++;
        UpdateUI();

        if (currentCoins >= totalCoins)
        {
            ShowWinScreen();
        }
    }

    void UpdateUI()
    {
        if (coinText != null)
            coinText.text = currentCoins.ToString();
    }

    void ShowWinScreen()
    {
        gameRunning = false;

        if (winPanel != null)
            winPanel.SetActive(true);

        if (timeText != null)
            timeText.text = "Time Taken: " + timer.ToString("F2") + "s";
        AudioManager.instance.Play("winsound");

        Time.timeScale = 0f;
    }
}

