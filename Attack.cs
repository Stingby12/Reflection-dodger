using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool isWhite = true;
    public Enemy targetSpt;
    public Spawner refSpt;

    float timer = 0;
    bool spawn = false;

    void Update()
    {
        if (refSpt.colorChose >= 1)
        {
            spawn = true;
        }

        if (spawn)
        {
            if (timer < 0.1)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {                
                if (spawn)
                {
                    if (refSpt.colorChose == 1 & isWhite == true)
                    {
                        targetSpt = GameObject.FindGameObjectWithTag("NewEnemy").GetComponent<Enemy>();
                        targetSpt.newEnemy = false;
                    }
                    if (refSpt.colorChose == 2 & isWhite == false)
                    {
                        targetSpt = GameObject.FindGameObjectWithTag("NewEnemy").GetComponent<Enemy>();
                        targetSpt.newEnemy = false;
                    }
                }

                timer = 0;
                spawn = false;
            }
        }
    }

    void OnTriggerStay2D (Collider2D col)
    {
        if (isWhite)
        {
            if (col.gameObject.tag == "WhiteEn")
            {
                targetSpt.isDestroyed = true;
            }
            if (col.gameObject.tag == "BlackEn")
            {
                Destroy(gameObject);
            }
        }
        else
        {
            if (col.gameObject.tag == "BlackEn")
            {
                targetSpt.isDestroyed = true;
            }
            if (col.gameObject.tag == "WhiteEn")
            {
                Destroy(gameObject);
            }
        }
    }

    void OnCollisionEnter2D (Collision2D defeat)
    {
        if (defeat.gameObject.layer == 3)
        {
            Destroy(gameObject);
        }
    }
}
