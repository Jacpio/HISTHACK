using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
 
    Rigidbody2D rb;
    public float degreeOffset;
    public GameObject explosionObject;
    public float bulletSpeed;
    public int damage;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float rotation = transform.eulerAngles.z + degreeOffset;
        Vector2 direction = new Vector2(Mathf.Cos(rotation * Mathf.Deg2Rad), Mathf.Sin(rotation * Mathf.Deg2Rad));
        rb.AddForce(direction*bulletSpeed,ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerHealthManager>() != null)
        {
            collision.gameObject.GetComponent<PlayerHealthManager>().currentHealth -= damage;
            FindObjectOfType<AudioController>().Play("hurt01");
        }
        
        Instantiate(explosionObject, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    
}
