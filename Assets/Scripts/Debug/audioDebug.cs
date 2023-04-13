using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioDebug : MonoBehaviour
{
    public string lmb_sound;
    public string space_sound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<AudioController>().Play(space_sound);
            
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FindAnyObjectByType<AudioController>().Play(lmb_sound);
        }
    }
}
