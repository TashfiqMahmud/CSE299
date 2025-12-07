using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public GameObject life_heart;

    void Start()
    {
        InvokeRepeating("spawn_life", 5, 10);
    }

    // Update is called once per frame
    void Update()
    {
      
    }


    public void spawn_life()
    {
        float x = Random.Range(-3, -1.5f);
        float y = Random.Range(-5, -4f);


        Instantiate(life_heart, new Vector3(x, 2, y), Quaternion.Euler(-90,0,0));
    }
}
