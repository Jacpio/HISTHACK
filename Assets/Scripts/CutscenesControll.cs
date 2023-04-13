using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutscenesControll : MonoBehaviour
{
    [SerializeField] private TMP_Text textBox;
    [SerializeField] private Transform movableSprite;
    [SerializeField] private Transform endPos;
    [SerializeField] private TextLine[] lines;
    [SerializeField] private float endLengh;    
    private float timer, startX, startY;
    private int currentLine;
    private float totalCutsceneLengh;
    void Start()
    {
        startX = movableSprite.position.x;
        startY = movableSprite.position.y;
        timer = 0;
        currentLine = 0;
        foreach (TextLine line in lines)
        {
            totalCutsceneLengh += line.textSpeed;
        }

        totalCutsceneLengh += endLengh;
    }
    void Update()
    {
        for (int i = 0; i < lines.Length; i++)
        {
           
            textBox.text = lines[_currentLine].text;
            if (timer >= lines[_currentLine].textSpeed)
            {
                timer = 0;
                currentLine++;
            }
           
        }
        timer += Time.fixedDeltaTime;
        float clampTime = Time.time / totalCutsceneLengh;
        float changeX = Mathf.Lerp(_startX,endPos.position.x, clampTime );
        float changeY = Mathf.Lerp(_startY,endPos.position.y, clampTime );
        movableSprite.position = new Vector3(changeX, changeY, 0);
    }
}
