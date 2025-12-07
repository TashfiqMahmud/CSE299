using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coinsCollected = 0;
    public GameObject[] chunkPrefabs;
    private GameObject lastChunk;
    public float chunkLength = 50f;
    
    // NEW: Fine-tuning offset for road piece connection. 
    // This value is added to the chunkLength in the spawn calculation.
    // Use this in the Inspector to close small gaps or overlaps.
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
        // FIX: Look for the main road object in the Hierarchy, which is currently "Chunk_Straight"
        // This initial chunk needs to be manually set in the Inspector on the GameManager object,
        // or ensure its name is exactly "Chunk_Straight"
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
            // 1. Calculate the spawn position using the current chunk's forward direction and the combined length/offset.
            Vector3 offset = lastChunk.transform.forward * (chunkLength + spawnOffset);
            spawnPosition = lastChunk.transform.position + offset;

            // 2. Inherit the last chunk's rotation to ensure the new chunk is aligned.
            spawnRotation = lastChunk.transform.rotation;
            
            // Temporary Debugging Output
            Debug.Log($"Spawning chunk. Last Pos: {lastChunk.transform.position}, Next Pos: {spawnPosition}, Rotation: {spawnRotation.eulerAngles}");
        }
        
        // Instantiate the new chunk with the correct position and rotation
        GameObject newChunk = Instantiate(chunkToSpawn, spawnPosition, spawnRotation);
        lastChunk = newChunk;
    }
}