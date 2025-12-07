using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public Slider audioSlider; 
    public Slider soundSlider; 

    void Start()
    {
       
        float savedMusic = PlayerPrefs.GetFloat("MusicVolume", 1f);
        float savedSFX = PlayerPrefs.GetFloat("SFXVolume", 1f);

       
        audioSlider.value = savedMusic;
        soundSlider.value = savedSFX;

       
        SetMusicVolume(savedMusic);
        SetSFXVolume(savedSFX);

     
        audioSlider.onValueChanged.AddListener(SetMusicVolume);
        soundSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    void SetMusicVolume(float value)
    {
       
        PlayerPrefs.SetFloat("MusicVolume", value);

       
        foreach (var music in AudioManager.instance.musicSounds)
        {
            music.source.volume = value;
        }
    }

    void SetSFXVolume(float value)
    {
      
        PlayerPrefs.SetFloat("SFXVolume", value);


        foreach (var sfx in AudioManager.instance.sfxSounds)
        {
            sfx.source.volume = value;
        }
    }
}

