using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donates : MonoBehaviour
{
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameControll.instance.score += 1;
            AudioManager.instance.Play("Donate");
           // AudioManager.instance.Play("Diamond");
            Destroy(this.gameObject, 0.2f);
        }
    }

}
