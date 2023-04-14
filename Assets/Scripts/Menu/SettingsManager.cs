using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] Scrollbar soundScroll;
    [SerializeField] Scrollbar musicScroll;
    [SerializeField] Scrollbar graphicsSettings;
    void Start()
    {
        DebugValues();
    }

   
    public void ValueChanged()
    {
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
        DebugValues();
    }
    void DebugValues()
    {
        Debug.Log($"current quality level is {QualitySettings.GetQualityLevel()}");
        Debug.Log($"current sound level is {GlobalAudioSettings.soundVolume}");
        Debug.Log($"current music level is {GlobalAudioSettings.musicVolume}");
    }
    public void ReturnToMenu ()
    {
        SceneManager.LoadScene(0);
    }
}
