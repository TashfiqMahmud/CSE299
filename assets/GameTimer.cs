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
       
        if (ModeManager.selectedMode == ModeManager.Mode.NoTimer)
        {
            timerUI.SetActive(false);
            return;
        }

       
        if (ModeManager.selectedMode == ModeManager.Mode.Easy)
            timeRemaining = 120f; //

      
        else if (ModeManager.selectedMode == ModeManager.Mode.Hard)
            timeRemaining = 30f;  // 

        timerUI.SetActive(true);
        startTimer = true;
    }

    void Update()
    {
        if (!startTimer) return;

        timeRemaining -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timeRemaining / 60);
int seconds = Mathf.FloorToInt(timeRemaining % 60);


timerText.text = $"{minutes:00}:{seconds:00}";


        if (timeRemaining <= 0)
        {
            startTimer = false;
            PlayerController.instance.GameOverFromTimer();
        }
    }
}

