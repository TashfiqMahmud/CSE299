using UnityEngine;

public class rulesmanager : MonoBehaviour
{
    public GameObject rulesPanel; 

    void Start()
    {
        if (rulesPanel != null)
            rulesPanel.SetActive(false); 
    }

    
    public void ShowRules()
    {
        if (rulesPanel != null)
            rulesPanel.SetActive(true);
    }

   
    public void CloseRules()
    {
        if (rulesPanel != null)
            rulesPanel.SetActive(false);
    }
}

