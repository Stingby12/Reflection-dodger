using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAI : MonoBehaviour
{
    public float maxSpeed = 4;

    float speedHor;
    float speedVer;
    int turn;

    void Start()
    {
        speedHor = Random.Range(-maxSpeed, maxSpeed+1);
        if (speedHor < 0)
        {
            speedVer = maxSpeed + speedHor;
        }
        if (speedHor > 0)
        {
            speedVer = -maxSpeed + speedHor;
        }
        if (speedHor == 0)
        {
            speedVer = maxSpeed;
        }

        turn = Random.Range(0,2);
        if (turn == 1)
        {
            speedVer = speedVer * -1;
        }
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * speedHor) * Time.deltaTime;
        transform.position = transform.position + (Vector3.up * speedVer) * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "WallHor")
        {
            speedHor = speedHor * -1;
        }
        if (col.gameObject.tag == "WallVer")
        {
            speedVer = speedVer * -1;
        }
    }
}
