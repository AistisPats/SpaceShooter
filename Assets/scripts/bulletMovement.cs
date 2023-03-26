using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    void Start()
    {
        rb.AddRelativeForce( Vector2.up * speed);
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("sideBarrier") ||  collision.gameObject.tag.Equals("topBarrier") || collision.gameObject.tag.Equals("meteorite")) Destroy(gameObject);
    }
}
