using UnityEngine;
using UnityEngine.EventSystems;

public class MainMenuSceneButtons : MonoBehaviour
{
    [Header("References")]
    public GameObject MenuPanel;             // Your panel that opens when clicking "Menu"
    public GameObject mainMenuSceneButtons;  // Parent object of Start, Menu, Rules, Quit buttons

    void Start()
    {
        // Ensure MenuPanel is hidden at start
        if (MenuPanel != null)
            MenuPanel.SetActive(false);
    }

    // Call this when clicking "Menu"
    public void OpenMenu()
    {
        if (MenuPanel != null)
            MenuPanel.SetActive(true);

        // Disable main menu buttons to prevent hover/click
        if (mainMenuSceneButtons != null)
            mainMenuSceneButtons.SetActive(false);

        // Deselect any selected UI element to stop hover sounds
        EventSystem.current.SetSelectedGameObject(null);
    }

    // Call this when closing the MenuPanel
    public void CloseMenu()
    {
        if (MenuPanel != null)
            MenuPanel.SetActive(false);

        // Re-enable main menu buttons
        if (mainMenuSceneButtons != null)
            mainMenuSceneButtons.SetActive(true);
    }
}
