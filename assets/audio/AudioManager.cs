using UnityEngine;
using System;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;
    public bool loop;          // true for music, false for SFX
    [HideInInspector] public AudioSource source;
}

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [Header("Background Music")]
    public Sound[] musicSounds;

    [Header("Sound Effects")]
    public Sound[] sfxSounds;

    void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Setup AudioSources for music
        foreach (Sound s in musicSounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;
            s.source.playOnAwake = false;
        }

        // Setup AudioSources for SFX
        foreach (Sound s in sfxSounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;
            s.source.playOnAwake = false;
        }
    }

    // Play music or SFX by name
    public void Play(string name)
    {
        Sound s = Array.Find(musicSounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Play();
            return;
        }

        s = Array.Find(sfxSounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.PlayOneShot(s.clip);
            return;
        }

        Debug.LogWarning("AudioManager: Sound not found - " + name);
    }

    // Stop music or SFX by name
    public void Stop(string name)
    {
        Sound s = Array.Find(musicSounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Stop();
            return;
        }

        s = Array.Find(sfxSounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Stop();
            return;
        }

        Debug.LogWarning("AudioManager: Sound not found - " + name);
    }

    // Optional: Adjust volume
    public void SetVolume(string name, float volume)
    {
        Sound s = Array.Find(musicSounds, sound => sound.name == name);
        if (s != null) s.source.volume = volume;
    }
}
