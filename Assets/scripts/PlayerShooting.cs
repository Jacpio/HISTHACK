using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
    
{
    public GameObject bullet;
    public Transform bulletpos;

    public float fireRate;
    private float _fireRateTimer;


    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            _fireRateTimer += Time.deltaTime;
            if (_fireRateTimer > fireRate )
            {
                GameObject bulletE = Instantiate(bullet, bulletpos.position, transform.rotation);
                _fireRateTimer = 0;
            }
        }
    }
}
