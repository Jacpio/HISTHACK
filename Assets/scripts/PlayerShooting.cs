using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletpos;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bulletE = Instantiate(bullet,bulletpos.position,transform.rotation);
        }
    }
}
