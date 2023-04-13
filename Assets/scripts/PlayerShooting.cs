using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject player;
    public float bulletSpeed;
    Rigidbody2D rb;

    private void Start()
    {
        gameObject.transform.rotation = player.transform.rotation;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * bulletSpeed);
    }
    void FixedUpdate()
    {
        
    }
}
