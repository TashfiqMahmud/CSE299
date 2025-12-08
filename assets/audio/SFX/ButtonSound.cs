using UnityEngine;
using UnityEngine.EventSystems; 

public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    [Header("Sounds")]
    public string clickSound = "ButtonClick";
    public string hoverSound = "ButtonHover";

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioManager.instance.Play(hoverSound); 
    }

    
    public void PlayClickSound()
    {
        AudioManager.instance.Play(clickSound); 
    }
}
