using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField] int startHealth = 100;
    public float currentHealth;
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
        }
        else
        {
            Score.score += 100;
            FindObjectOfType<AudioController>().Play("GameOver01");
        }
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
