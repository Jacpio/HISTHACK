using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public SoundClip[] sounds;

 

    void Awake()
    {

        

        DontDestroyOnLoad(gameObject);

        foreach (SoundClip s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.isLoop;
        }
    }

    void Start()
    {
        Play("Theme");

    }

    public void Play(string name)
    {
        SoundClip s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found");
            return;
        }

        s.source.Play();
    }

    public void Stop(string name)
    {
        SoundClip s = Array.Find(sounds, sound => sound.name == name);

        s.source.Stop();
    }
}
