using System;
using UnityEngine;

public class FighterAirCraft : MonoBehaviour, Enemy
{
    public Transform player;
    public float moveSpeed, degreeOffset;
    private float playerX, playerY;
    private float timer = 0;
    public float shootTime = 5;
    private Vector2 finalPos, normalPos;
    private Rigidbody2D rb;
    private Transform shootPoint;
    public GameObject bullet;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        shootPoint = gameObject.transform.GetChild(0);
    }

    public void Shoot()
    {
        if (timer >= shootTime)
        {
            timer = 0;
            Instantiate(bullet, new Vector3(shootPoint.position.x, shootPoint.position.y), Quaternion.identity);
        }
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
        timer += Time.fixedDeltaTime;
        Move();
        Shoot();
    }
}
