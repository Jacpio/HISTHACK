using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public GameObject shootingText, controlText, speedText,next;
    private float textnum=0;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            textnum++;
        }
        switch (textnum)
        {
            case 0:
                shootingText.SetActive(false);
                controlText.SetActive(true);
                speedText.SetActive(false);
                next.SetActive(true);
            return;
                
            case 1:
                shootingText.SetActive(true);
                controlText.SetActive(false);
                speedText.SetActive(false);
                return;

            case 2:
                shootingText.SetActive(false);
                controlText.SetActive(false);
                speedText.SetActive(true);
                return;
            case 3:
                shootingText.SetActive(false);
                controlText.SetActive(false);
                speedText.SetActive(false);
                next.SetActive(false);

                return;

        }
        
    }
}
