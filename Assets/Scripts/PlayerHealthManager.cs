using UnityEditor;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField] int startHealth = 100;
    public int currentHealth;

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
        FindObjectOfType<AudioController>().Play("GameOver01");
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
