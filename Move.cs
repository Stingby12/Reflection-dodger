using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;

    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode up = KeyCode.UpArrow;
    public KeyCode down = KeyCode.DownArrow;

    float speedHor;
    float speedVer;
    public float acc = 3;

    void Update()
    {
        if (Input.GetKey(left))
        {
            speedHor = acc;
        }
        else if (Input.GetKey(right))
        {
            speedHor = -acc;
        }
        else
        {
            speedHor = 0;
        }

        if (Input.GetKey(up))
        {
            speedVer = acc;
        }
        else if (Input.GetKey(down))
        {
            speedVer = -acc;
        }
        else
        {
            speedVer = 0;
        }
        
        rb.velocity = Vector2.left * speedHor;
        rb.velocity += Vector2.up * speedVer;
    }
}