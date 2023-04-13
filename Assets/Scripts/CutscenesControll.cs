using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CutscenesControll : MonoBehaviour
{
    [SerializeField] private TMP_Text textBox;
    [SerializeField] private TextLine[] lines;
    private float timer, startX, startY;
    private int currentLine;
    void Start()
    {
        timer = 0;
        currentLine = 0;
    }

    void FixedUpdate()
    {
        if (currentLine < lines.Length)
        {
            for (int i = 0; i <= lines.Length; i++)
            {
                textBox.text = lines[currentLine].text;
                if (timer >= lines[currentLine].textSpeed*2)
                {
                    timer = 0;
                    currentLine++;
                }

                timer += Time.fixedDeltaTime;
            }        
        }

    }
}
