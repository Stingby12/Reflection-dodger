using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAI : MonoBehaviour
{
    public float maxSpeed = 4;
    public GameObject target;

    void Start()
    {
        if (gameObject.tag == "WhiteEn")
        {
            target = GameObject.FindGameObjectWithTag("BlackPl");
        }
        else
        {
            target = GameObject.FindGameObjectWithTag("WhitePl");
        }
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, maxSpeed * Time.deltaTime);

        // Remix of Indie Nuggest's "Look at mouse 2D"
        var dir = target.transform.position - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle + 29, Vector3.forward);
    }
}
