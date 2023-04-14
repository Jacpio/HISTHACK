using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField] int startHealth = 100;
    [HideInInspector]public float currentHealth;
    public GameObject explosion;

    private void Start()
    {
        currentHealth = startHealth;
    }

    private void Update()
    {
       
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {

        if (gameObject.layer == 6)
        {
            FindObjectOfType<AudioController>().Play("GameOver02");
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            Score.score += 100;
            FindObjectOfType<AudioController>().Play("GameOver01");
        }
        if (gameObject.layer == 8) {
            
        
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
