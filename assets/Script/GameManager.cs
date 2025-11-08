using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject[] stage;
    public GameObject[] stage1;
    Vector3 nextSpawnpoint;
    public GameObject lifeber;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

        Time.timeScale = 1;
        
        for (int i = 0; i < stage.Length; i++)
        {
            spawnRoad();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnRoad( )
    {
        if (PlayerPrefs.GetInt("level_count") == 1)
        {
            GameObject temp = Instantiate(stage[0], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }
        if (PlayerPrefs.GetInt("level_count") == 2)
        {
            GameObject temp = Instantiate(stage[1], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }
        if (PlayerPrefs.GetInt("level_count") == 3)
        {
            GameObject temp = Instantiate(stage[2], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }
        if (PlayerPrefs.GetInt("level_count") == 4)
        {
            GameObject temp = Instantiate(stage[3], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }
    }
    public void spawnRoad_aftercollision()
    {
        if (PlayerPrefs.GetInt("level_count") == 1)
        {
            GameObject temp = Instantiate(stage1[0], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }
        if (PlayerPrefs.GetInt("level_count") == 2)
        {
            GameObject temp = Instantiate(stage1[1], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }
        if (PlayerPrefs.GetInt("level_count") == 3)
        {
            GameObject temp = Instantiate(stage1[2], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }
        if (PlayerPrefs.GetInt("level_count") == 4)
        {
            GameObject temp = Instantiate(stage1[3], new Vector3(2.15f, nextSpawnpoint.y, nextSpawnpoint.z), Quaternion.identity);
            nextSpawnpoint = temp.transform.GetChild(1).transform.position;
        }

    }

    public void spawn_life()
    {
        if (GameObject.Find("Road1"))
        {
            Vector3 spawnpoint = GameObject.Find("Road1").transform.GetChild(1).transform.position;
            //Instantiate(lifeber,spawnpoint,Quaternion.Euler)
        }
    }
   
}
