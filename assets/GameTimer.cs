using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject timerUI;

    float timeRemaining;
    bool startTimer = false;

    void Start()
    {
        // NO TIMER mode → hide UI
        if (ModeManager.selectedMode == ModeManager.Mode.NoTimer)
        {
            timerUI.SetActive(false);
            return;
        }

        // EASY MODE
        if (ModeManager.selectedMode == ModeManager.Mode.Easy)
            timeRemaining = 120f; // 2 minutes

        // HARD MODE
        else if (ModeManager.selectedMode == ModeManager.Mode.Hard)
            timeRemaining = 30f;  // 30 seconds

        timerUI.SetActive(true);
        startTimer = true;
    }

    void Update()
    {
        if (!startTimer) return;

        timeRemaining -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timeRemaining / 60);
int seconds = Mathf.FloorToInt(timeRemaining % 60);

// Format → 02:05, 01:30, 00:09 etc.
timerText.text = $"{minutes:00}:{seconds:00}";


        if (timeRemaining <= 0)
        {
            startTimer = false;
            PlayerController.instance.GameOverFromTimer();
        }
    }
}
