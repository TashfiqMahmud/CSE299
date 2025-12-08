using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSensitivity : MonoBehaviour
{
    [Header("References")]
    public Slider sensitivitySlider;          
    public PlayerController playerController; 
    public TMP_Text valueText;               

    void Start()
    {
        if (playerController == null || sensitivitySlider == null) 
        {
            Debug.LogError("PlayerController or Slider not assigned!");
            return;
        }

      
        sensitivitySlider.value = playerController.laneSpeed;

      
        UpdateValueText(playerController.laneSpeed);

    
        sensitivitySlider.onValueChanged.AddListener(SetSensitivity);
    }

    public void SetSensitivity(float value)
    {
        if (playerController != null)
        {
            playerController.laneSpeed = value;
        }

       
        UpdateValueText(value);
    }

    private void UpdateValueText(float value)
    {
        if (valueText != null)
        {
            valueText.text = value.ToString("F1");
        }
    }
}

