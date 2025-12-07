using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonSelector : MonoBehaviour
{
    public Button noTimerButton;
    public Button easyButton;
    public Button hardButton;

    public Color normalColor = Color.white;
    public Color selectedColor = Color.green;

    private Button selectedButton;

    void Start()
    {
        // Default selection
        SelectButton(noTimerButton);
    }

    public void SelectNoTimer() => SelectButton(noTimerButton);
    public void SelectEasy() => SelectButton(easyButton);
    public void SelectHard() => SelectButton(hardButton);

    void SelectButton(Button button)
    {
        // Reset previous button color
        if (selectedButton != null)
            selectedButton.image.color = normalColor;

        // Set new button color
        selectedButton = button;
        selectedButton.image.color = selectedColor;

        // Update ModeManager
        if (button == noTimerButton) ModeManager.selectedMode = ModeManager.Mode.NoTimer;
        else if (button == easyButton) ModeManager.selectedMode = ModeManager.Mode.Easy;
        else if (button == hardButton) ModeManager.selectedMode = ModeManager.Mode.Hard;
    }
}
