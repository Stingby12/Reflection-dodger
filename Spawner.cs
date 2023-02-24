using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject spawn0;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;

    public float spawnRate = 5;
    float timer = 0;
    public int colorChose = 0;

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            string num = Random.Range(0,4).ToString();
            GameObject spawnTo = GameObject.Find("Spawn"+num);

            colorChose = Random.Range(1,3);
            Instantiate(spawn0, spawnTo.transform.position, transform.rotation);

            timer = 0;
        }
    }
}
