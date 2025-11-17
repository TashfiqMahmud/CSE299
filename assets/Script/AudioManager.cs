using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] sounds;
    bool Issoundoff;
   
    bool IsVibratiionOff;
    public GameObject sound_On;
   
   // public GameObject vibrateon;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

        }
       // DontDestroyOnLoad(this);

    }
    void Start()
    {
        Issoundoff = PlayerPrefs.GetInt("Muted") == 1;
       // Ismusicooff = PlayerPrefs.GetInt("Music") == 1;
        IsVibratiionOff = PlayerPrefs.GetInt("VibrateOf") == 1;
        AudioListener.pause = Issoundoff;
        if (PlayerPrefs.GetInt("Muted") == 1)
        {
            sound_On.SetActive(false);


        }
        else
        {
            sound_On.SetActive(true);

        }
       

        if (PlayerPrefs.GetInt("VibrateOf") == 1)
        {
          //  vibrateon.SetActive(false);
        }
        else
        {

           // vibrateon.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found! ");
            return;
        }

        s.source.Play();
    }
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found! ");
            return;
        }

        s.source.Stop();
    }
    public void soundon()
    {
        Issoundoff = !Issoundoff;
        AudioListener.pause = Issoundoff;
        PlayerPrefs.SetInt("Muted", Issoundoff ? 1 : 0);
        if (PlayerPrefs.GetInt("Muted") == 1)
        {
            sound_On.SetActive(false);
        }
        else
        {
            sound_On.SetActive(true);

        }
       // AudioManager.instance.Play("Button");
    }
    //public void musicon()
    //{
    //    Ismusicooff = !Ismusicooff;
    //    PlayerPrefs.SetInt("Music", Ismusicooff ? 1 : 0);
    //    if (PlayerPrefs.GetInt("Music") == 1)
    //    {

    //        Music_on.SetActive(false);
    //        Stop("Main");
    //        Debug.Log("ff");
    //    }
    //    else
    //    {

    //        Music_on.SetActive(true);
    //        Play("Main");
    //        Debug.Log(" On");

    //    }

    //}
    public void VibrateOn()
    {
        IsVibratiionOff = !IsVibratiionOff;


        PlayerPrefs.SetInt("VibrateOf", IsVibratiionOff ? 1 : 0);


        if (PlayerPrefs.GetInt("VibrateOf") == 1)
        {
           // vibrateon.SetActive(false);
        }
        else
        {

           // vibrateon.SetActive(true);
        }
        AudioManager.instance.Play("Button");
    }


    public void VibrationButton()
    {
        if (isVibrationOn())
        {
            Handheld.Vibrate();
        }
    }

    public bool isVibrationOn()
    {



        if (PlayerPrefs.GetInt("VibrateOf") == 0)
        {

            return true;
        }
        else
        {


            return false;
        }
    }

}
