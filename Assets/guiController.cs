using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class guiController : MonoBehaviour
{
    [SerializeField] Image healthDisplay;
    [SerializeField] Image boostDisplay;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Update()
    {
        UpdateHealth();
        UpdateScore();
        UpdateBoost();
    }
    private void UpdateHealth()
    {
        if (FindObjectOfType<PlayerShooting>() != null)
        {

        healthDisplay.fillAmount = FindObjectOfType<PlayerShooting>().gameObject.GetComponent<PlayerHealthManager>().currentHealth / 100;
        }
    }
    private void UpdateBoost ()
    {
        
    }
    private void UpdateScore ()
    {
        scoreText.text = $"Wynik: {Score.score}";
        if (Score.score == 1000)
        {
            SceneManager.LoadScene("Cutscene2");
        }else if(Score.score == 1200)
        {
            SceneManager.LoadScene("Cutscene3");
        }
    }
}
