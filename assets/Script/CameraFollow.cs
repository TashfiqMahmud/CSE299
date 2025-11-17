using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    public Vector3 follow;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
       // transform.position = Vector3.Lerp(this.transform.position, Player.transform.position + follow, Time.deltaTime*10);
       transform.position = new Vector3(0, 3.5f, Player.transform.position.z+5f);
    }
}
