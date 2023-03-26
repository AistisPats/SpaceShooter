using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying : MonoBehaviour
{
    public float acceleration, maxSpeed, deceleration, rotationSpeed;
    public Rigidbody2D rb;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            if(Mathf.Sqrt(Mathf.Pow(rb.velocity.y, 2) + Mathf.Pow(rb.velocity.x, 2)) < maxSpeed) 
            {
                rb.AddRelativeForce(Vector2.up * acceleration*Time.deltaTime);
            }


        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.transform.Rotate(new Vector3(0, 0, rotationSpeed)*Time.deltaTime);
            rb.rotation = transform.rotation.z;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.transform.Rotate(new Vector3(0, 0, -rotationSpeed)*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector2.down * deceleration * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("topBarrier"))
        {
            transform.position = new Vector2(transform.position.x, -transform.position.y);
            rb.angularVelocity = 0;
        }
        if (collision.gameObject.tag.Equals("sideBarrier"))
        {
            transform.position = new Vector2(-transform.position.x, transform.position.y);
            rb.angularVelocity = 0;
        }
    }
}
