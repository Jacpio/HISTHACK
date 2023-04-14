using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] Scrollbar soundScroll;
    [SerializeField] Scrollbar musicScroll;
    [SerializeField] Scrollbar graphicsSettings;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ValueChanged()
    {
        GlobalAudioSettings.soundVolume = soundScroll.value;
        GlobalAudioSettings.musicVolume = musicScroll.value;
        switch (graphicsSettings.value)
        {
            case < 0:

                break;
        }
    }
}
