using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubtitleController : MonoBehaviour
{
    public SubtitleGroup[] subGroups;
    public TextMeshProUGUI textObject;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        for(int i = 0; i < subGroups.Length;)
        {
            if (subGroups[i].autoPlay)
            {
                
                for (int j = 0; j < subGroups[i].subtitles.Length;)
                {
                    textObject.text = subGroups[i].subtitles[j].content;
                    if (_timer > subGroups[i].subtitles[j].lengh)
                    {
                        _timer = 0;
                        j += 1;

                    }
                }
                i++;
               
            }
           
        }
    }
}
