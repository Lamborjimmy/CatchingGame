using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingScript : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Destroy();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
    private void Destroy()
    {
        if(gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
