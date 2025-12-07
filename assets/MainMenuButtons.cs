using UnityEngine;

public class MainMenuButtons : MonoBehaviour
{
    public void SelectNoTimer()
    {
        ModeManager.selectedMode = ModeManager.Mode.NoTimer;
        Debug.Log("Mode selected: NO TIMER");
    }

    public void SelectEasy()
    {
        ModeManager.selectedMode = ModeManager.Mode.Easy;
        Debug.Log("Mode selected: EASY");
    }

    public void SelectHard()
    {
        ModeManager.selectedMode = ModeManager.Mode.Hard;
        Debug.Log("Mode selected: HARD");
    }
}
