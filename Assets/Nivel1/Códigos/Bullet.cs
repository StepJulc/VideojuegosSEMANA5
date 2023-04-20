using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private Rigidbody2D MyRb;
    public float Speed;
    
    void Start()
    {
        MyRb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //*Time.deltaTime para el mundo real es por el speed
        MyRb.velocity = transform.right * Speed;
        Destroy(gameObject,5f);
    }
}
