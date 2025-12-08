using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donates : MonoBehaviour
{
  
    void Start()
    {
        
    }

    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameControll.instance.score += 1;
            AudioManager.instance.Play("Donate");
            Destroy(this.gameObject, 0.2f);
        }
    }

}
