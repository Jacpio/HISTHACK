using System;
using System.Xml.Linq;
using UnityEngine;

public class FighterAirCraft : MonoBehaviour, Enemy
{
    public Transform player;
    public float moveSpeed, finalspeed, degreeOffset;
    private float playerX, playerY;
    private float timer = 0;
    float angle;
    bool isRetreating;
    private float bulletOffset = 180;
    public float shootTime = 5;
    private Vector2 finalPos, normalPos;
    private Rigidbody2D rb;
    private Transform shootPoint;
    public GameObject bullet;
    private float _retreatTimer;

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
            FindObjectOfType<AudioController>().Play("shoot02");
            Instantiate(bullet, new Vector3(shootPoint.position.x, shootPoint.position.y), Quaternion.Euler(0,0, angle - bulletOffset));
        }
    }

    public void MoveTowardPlayer()
    {
        finalPos = player.position - gameObject.transform.position;
        normalPos = finalPos.normalized;
        angle = Mathf.Atan2(normalPos.y, normalPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + degreeOffset));
        float distance = Vector3.Distance(gameObject.transform.position, player.position);
        finalspeed = moveSpeed * (distance - 4) / 4;
        if (finalspeed > 0) rb.velocity = normalPos * finalspeed;
        else if (finalspeed > 2) rb.velocity = normalPos * 2;
        else rb.velocity = normalPos * 0;
    }
    private void AttackLogic ()
    {
        
        /*Vector3 difference = new Vector3(
          player.position.x - transform.position.x,
          player.position.y - transform.position.y,
          player.position.z - transform.position.z);
        
        float distance = (float)Math.Sqrt(
          Math.Pow(difference.x, 2f) +
          Math.Pow(difference.y, 2f) +
          Math.Pow(difference.z, 2f));
        */
        
        MoveTowardPlayer();
        
        
    }
    
    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        _retreatTimer += Time.deltaTime;
        Shoot();
        AttackLogic();
        
    }
}
