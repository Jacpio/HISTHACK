using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlaneAnimation : MonoBehaviour
    {
    public Vector2 endPos;
    private Vector2 startPos;
    private float x,y;
    public float moveSpeed;
    private Rigidbody2D rb;
    private void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if(endPos.x > 0) { 
            if (gameObject.transform.position.x < endPos.x)
            {
                x = Mathf.Lerp(endPos.x, gameObject.transform.position.x, Time.fixedDeltaTime * moveSpeed);
                y = Mathf.Lerp(endPos.y, gameObject.transform.position.y, Time.fixedDeltaTime * moveSpeed);
                rb.velocity = new Vector2(x, y);
            }
            else
            {
                gameObject.transform.position = startPos;

            }
        }
        else
        {
            if (gameObject.transform.position.x > endPos.x)
            {
                x = Mathf.Lerp(endPos.x, gameObject.transform.position.x, Time.fixedDeltaTime * moveSpeed);
                y = Mathf.Lerp(endPos.y, gameObject.transform.position.y, Time.fixedDeltaTime * moveSpeed);
                rb.velocity = new Vector2(x, y);
            }
            else
            {
                gameObject.transform.position = startPos;

            }
        }
    }
}