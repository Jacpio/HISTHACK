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
    public void ValueChanged()
    {
        Debug.Log($"current quality level is {QualitySettings.GetQualityLevel()}");
        GlobalAudioSettings.soundVolume = soundScroll.value;
        GlobalAudioSettings.musicVolume = musicScroll.value;
        switch (graphicsSettings.value)
        {
            case < 0.3f:
                QualitySettings.SetQualityLevel(0, true);
                break;

            case < 0.7f:
                QualitySettings.SetQualityLevel(1, true);
                break;

            case 1:
                QualitySettings.SetQualityLevel(2, true);
                break;

        }
    }
}
