using UnityEngine;
using UnityEngine.EventSystems; // Needed for hover events

public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    [Header("Sounds")]
    public string clickSound = "ButtonClick";
    public string hoverSound = "ButtonHover";

    // Play hover sound
    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioManager.instance.Play(hoverSound); // use variable, not undefined name
    }

    // Play click sound
    public void PlayClickSound()
    {
        AudioManager.instance.Play(clickSound); // use variable
    }
}
