using UnityEngine;

public class rulesmanager : MonoBehaviour
{
    public GameObject rulesPanel; // Assign the RulesPanel here

    void Start()
    {
        if (rulesPanel != null)
            rulesPanel.SetActive(false); // Hide panel at start
    }

    // Called when "Rules" button is clicked
    public void ShowRules()
    {
        if (rulesPanel != null)
            rulesPanel.SetActive(true);
    }

    // Called when "Back" button is clicked
    public void CloseRules()
    {
        if (rulesPanel != null)
            rulesPanel.SetActive(false);
    }
}
