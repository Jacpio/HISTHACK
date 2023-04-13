using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestroy : MonoBehaviour
{
    public float lifeTime;
    private float _timer;
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > lifeTime )
        {
            Destroy(gameObject);
        }
    }
}
