using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{

    [SerializeField] float speed;

    private Vector2 mousePos;
    private Vector2 objectPos;
    private Vector2 finalPos;
    private Vector2 normalPos;

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

        mousePos = Input.mousePosition;
        objectPos = Camera.main.WorldToScreenPoint(transform.position);
        finalPos = mousePos - objectPos;
        normalPos = finalPos.normalized;
        float angle = Mathf.Atan2(normalPos.y, normalPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
    }
    void MovePlayer ()
    {
        rb.velocity = normalPos * speed;
    }
    
}
