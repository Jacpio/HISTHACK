using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class TextLine
{
    public float textSpeed;
    [Multiline]
    public string text;
    [SerializeField]
    public Sprite Sprite;
}
