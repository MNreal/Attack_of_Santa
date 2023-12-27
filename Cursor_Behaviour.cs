using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairPosition : MonoBehaviour
{
    //Get Cam
    public Camera cam;

    //Get Rigidbody2D
    public Rigidbody2D rb;

    //Get mousePos Vector
    Vector2 mousePos;

    void Start()
    {
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        rb.position = mousePos;
    }
}
