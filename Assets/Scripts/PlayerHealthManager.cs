using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    [SerializeField] int startHealth = 100;
    public float currentHealth;
    public GameObject health;
    public GameObject explosion;

    private void Start()
    {
        currentHealth = startHealth;
    }

    private void Update()
    {
        health.GetComponent<Image>().fillAmount = currentHealth * 0.01f;
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
