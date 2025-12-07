using UnityEngine;

public class ModeManager : MonoBehaviour
{
    public enum Mode
    {
        NoTimer,
        Easy,
        Hard
    }

    public static Mode selectedMode = Mode.NoTimer;

    void Awake()
    {
        // Load saved mode when game starts
        if (PlayerPrefs.HasKey("SelectedMode"))
        {
            selectedMode = (Mode)PlayerPrefs.GetInt("SelectedMode");
        }
    }

    public static void SetMode(Mode mode)
    {
        selectedMode = mode;
        PlayerPrefs.SetInt("SelectedMode", (int)mode);
        PlayerPrefs.Save();
    }
}
