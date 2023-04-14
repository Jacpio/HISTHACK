using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float degreeOffset;
    private bool boost;
    public float startBoostTime = 6f;
    private float _boostTime;

    private Vector2 mousePos;
    private Vector2 objectPos;
    private Vector2 finalPos;
    private Vector2 normalPos;

    private Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        boost = false;
        _boostTime = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        MovePlayer();
        if(Input.GetKeyDown(KeyCode.Space) && boost==false && _boostTime <= -startBoostTime) 
        {
            boost = true;
            _boostTime = 3f;
        }
        if (_boostTime <= -startBoostTime) boost = false;
        _boostTime -= Time.deltaTime;
    }
    void RotatePlayer ()
    {

        mousePos = Input.mousePosition;
        objectPos = Camera.main.WorldToScreenPoint(transform.position);
        finalPos = mousePos - objectPos;
        normalPos = finalPos.normalized;
        float angle = Mathf.Atan2(normalPos.y, normalPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + degreeOffset));
    }
    void MovePlayer ()
    {
        if (boost == true) rb.velocity = normalPos * speed * 2;

        else rb.velocity = normalPos * speed;
    }
    
}
