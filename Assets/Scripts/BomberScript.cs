using System;
using System.Xml.Linq;
using UnityEngine;

public class BomberScript : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet;
   
    Vector2 finalPos, normalPos;
    float angle;
    private Rigidbody2D rb;
    private float timer = 120f,shoottimer=0f, shootTime=2f;


    private void Start()
    {
        player = FindObjectOfType<PlayerShooting>().gameObject;
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        finalPos = player.transform.position - gameObject.transform.position;
        normalPos = finalPos.normalized;
        angle = Mathf.Atan2(normalPos.y, normalPos.x) * Mathf.Rad2Deg;

        timer -= Time.deltaTime;
        shoottimer += Time.deltaTime;
        
        if (shoottimer >= shootTime)
        {
            shoottimer = 0;

            Instantiate(bullet, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.Euler(0, 0, angle));
        }
    }
}