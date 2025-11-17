using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        GameManager.instance.spawnRoad_aftercollision();
        Destroy(gameObject, 2);
    }

}
