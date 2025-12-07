using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public Slider audioSlider; // Music Slider
    public Slider soundSlider; // SFX Slider

    void Start()
    {
        // Load saved values (default = 1)
        float savedMusic = PlayerPrefs.GetFloat("MusicVolume", 1f);
        float savedSFX = PlayerPrefs.GetFloat("SFXVolume", 1f);

        // Set slider positions
        audioSlider.value = savedMusic;
        soundSlider.value = savedSFX;

        // Apply the saved volumes
        SetMusicVolume(savedMusic);
        SetSFXVolume(savedSFX);

        // Add listeners
        audioSlider.onValueChanged.AddListener(SetMusicVolume);
        soundSlider.onValueChanged.AddListener(SetSFXVolume);
    }

    void SetMusicVolume(float value)
    {
        // Save the value
        PlayerPrefs.SetFloat("MusicVolume", value);

        // Apply to all music sounds
        foreach (var music in AudioManager.instance.musicSounds)
        {
            music.source.volume = value;
        }
    }

    void SetSFXVolume(float value)
    {
        // Save the value
        PlayerPrefs.SetFloat("SFXVolume", value);

        // Apply to all SFX sounds
        foreach (var sfx in AudioManager.instance.sfxSounds)
        {
            sfx.source.volume = value;
        }
    }
}
