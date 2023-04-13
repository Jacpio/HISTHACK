using System;
using UnityEngine;

public class FighterAirCraft : MonoBehaviour, Enemy
{
    public Transform player;
    public float moveSpeed, degreeOffset;
    private float playerX, playerY;
    private Vector2 finalPos, normalPos;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Shoot()
    {

    }

    public void Move()
    {
        finalPos = player.position - gameObject.transform.position;
        normalPos = finalPos.normalized;
        float angle = Mathf.Atan2(normalPos.y, normalPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + degreeOffset));
        
        rb.velocity = normalPos * moveSpeed;
    }

    private void FixedUpdate()
    {
       
        Move();
        Shoot();
    }
}
