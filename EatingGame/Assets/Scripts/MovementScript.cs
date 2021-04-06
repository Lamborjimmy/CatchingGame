using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity = 100f;
    private float dirX;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    /*private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * velocity;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * velocity;
        }
    }*/
    /*(public void moveRight()
    {
        rb.velocity = Vector2.right * velocity;
    }
    public void moveLeft()
    {
        rb.velocity = Vector2.left * velocity;
    }*/
    private void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * velocity;
        rb.velocity = new Vector2(dirX, 0f);
    }

}
