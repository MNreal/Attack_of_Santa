using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Get Rigidbody2D
    public Rigidbody2D rb;

    //Set Speed
    public float speed = 6f;

    //Get Movement Vectoor
    Vector2 movement;

    //Referance cam
    public Camera cam;

    //Get mousePos Vector
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
         movement.x = Input.GetAxisRaw("Horizontal");
         movement.y = Input.GetAxisRaw("Vertical");

         mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg -90f;

        rb.rotation = angle;
    }
}
