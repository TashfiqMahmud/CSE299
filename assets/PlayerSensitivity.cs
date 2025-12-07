using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSensitivity : MonoBehaviour
{
    [Header("References")]
    public Slider sensitivitySlider;          // Assign your slider here
    public PlayerController playerController; // Assign your PlayerController here
    public TMP_Text valueText;                // Assign TMP Text to display value

    void Start()
    {
        if (playerController == null || sensitivitySlider == null) 
        {
            Debug.LogError("PlayerController or Slider not assigned!");
            return;
        }

        // Initialize slider with current player laneSpeed
        sensitivitySlider.value = playerController.laneSpeed;

        // Update the text
        UpdateValueText(playerController.laneSpeed);

        // Listen to slider changes
        sensitivitySlider.onValueChanged.AddListener(SetSensitivity);
    }

    public void SetSensitivity(float value)
    {
        if (playerController != null)
        {
            playerController.laneSpeed = value; // Update player speed
        }

        // Update display text
        UpdateValueText(value);
    }

    private void UpdateValueText(float value)
    {
        if (valueText != null)
        {
            valueText.text = value.ToString("F1"); // Show 1 decimal place
        }
    }
}
