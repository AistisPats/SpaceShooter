using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class smallMeteorite : MonoBehaviour
{
    public Rigidbody2D rb;


    void Start()
    {
        rb.AddForce(new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("bullet"))
        {
            Destroy(gameObject);
        }
    }
}
