using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SubtitleGroup
{
    public Subtitle[] subtitles;
    public bool autoPlay;
    [HideInInspector] public int totalLengh;
}
