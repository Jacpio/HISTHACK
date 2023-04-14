using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SoundClip
{
    public string name;
    public AudioClip clip;
    [HideInInspector] public AudioSource source;
    [Range(0f, 1f)]
    public float volume;
    [Range(0f, 3f)]
    public float pitch;
    public enum channel
    {
        sound,
        music

    }
    public channel soundChannel;
    public bool isLoop;
}
