using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool isDestroyed;

    SpriteRenderer colorChange;
    public Spawner refSpt;
    
    public bool newEnemy = true;
    bool setX = false;

    void Start()
    {
        refSpt = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();

        colorChange = GetComponent<SpriteRenderer>();

        if (refSpt.colorChose == 1)
        {
            colorChange.color = Color.white;
        }
    }

    void Update()
    {
        if (newEnemy == false & setX == false)
        {
            if (refSpt.colorChose == 1)
            {
                gameObject.tag = "WhiteEn";
            }
            if (refSpt.colorChose == 2)
            {
                gameObject.tag = "BlackEn";
            }

            refSpt.colorChose = 0;
            setX = true;
        }

        if (isDestroyed)
        {
            Destroy(gameObject);
        }
    }
}
