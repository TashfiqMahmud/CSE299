using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coinsCollected = 0;
    public GameObject[] chunkPrefabs;
    private GameObject lastChunk;
    public float chunkLength = 50f;
    
    public float spawnOffset = 0f; 

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        GameObject initialChunk = GameObject.Find("Chunk_Straight"); 
        
        if (initialChunk != null)
        {
            lastChunk = initialChunk;
        }
    }

    public void AddCoin(int amount = 1)
    {
        coinsCollected += amount;
        Debug.Log("Coins: " + coinsCollected);
    }
    
    public void spawnRoad_aftercollision()
    {
        if (chunkPrefabs.Length == 0)
        {
            Debug.LogError("Chunk Prefabs array is empty on GameManager! Cannot spawn road.");
            return;
        }
        int randomIndex = Random.Range(0, chunkPrefabs.Length);
        GameObject chunkToSpawn = chunkPrefabs[randomIndex];
        Vector3 spawnPosition = Vector3.zero;
        Quaternion spawnRotation = Quaternion.identity;

        if (lastChunk != null)
        {
  
            Vector3 offset = lastChunk.transform.forward * (chunkLength + spawnOffset);
            spawnPosition = lastChunk.transform.position + offset;


            spawnRotation = lastChunk.transform.rotation;
            
       
            Debug.Log($"Spawning chunk. Last Pos: {lastChunk.transform.position}, Next Pos: {spawnPosition}, Rotation: {spawnRotation.eulerAngles}");
        }
        
 
        GameObject newChunk = Instantiate(chunkToSpawn, spawnPosition, spawnRotation);
        lastChunk = newChunk;
    }

}
