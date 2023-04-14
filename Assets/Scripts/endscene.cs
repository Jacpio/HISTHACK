using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscene : MonoBehaviour
{
    
    void Update()
    {
        if(Score.score>200)
        {
            SceneManager.LoadScene("Cutscene3");

        }
    }
}
