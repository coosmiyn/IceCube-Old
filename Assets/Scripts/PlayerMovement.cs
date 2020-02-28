using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variables
    public float horizontalSpeed = 15f;
    public float verticalSpeed = 250f;

    public bool hasJumped = false;

    Vector2 iVector = new Vector2(1, 0);
    Vector2 jVector = new Vector2(0, 1);



    //The player's rigid body
    public Rigidbody2D rb2d;

    //The player's transform object
    public Transform player;

    // Camera script
    public CameraMovement cameraMovement;



    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
        if (Input.GetKey("d"))
        {
            rb2d.AddForce(iVector * horizontalSpeed);
            //rb2d.velocity += iVector * horizontalSpeed;
        }

        if (Input.GetKey("a"))
        {
            rb2d.AddForce(-iVector * horizontalSpeed);
            //rb2d.velocity -= iVector * horizontalSpeed;
        }

        if (Input.GetKey("w"))
        {
            if (hasJumped == false)
            {
                hasJumped = true;
                rb2d.AddForce(jVector * verticalSpeed);
                //rb2d.velocity += jVector * verticalSpeed;
            }
        }
    }
}
