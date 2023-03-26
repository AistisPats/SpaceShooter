using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public GameObject smaller;
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
            int split = Random.Range(1, 4);
            for (int i = 0; i < split; i++) Instantiate(smaller, transform.position+new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0), transform.rotation);
            Destroy(gameObject);
        }
    }
}
