using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{

    [SerializeField] float speed;
    private Vector2 mousePos;
    
    private Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MovePlayer();
    }
    void RotatePlayer ()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition).normalized;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.up = mousePos;
    }
    void MovePlayer ()
    {
        rb.AddForce(mousePos * speed, ForceMode2D.Force);
    }
    void SpeedControl ()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }
}
