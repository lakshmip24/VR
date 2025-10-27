using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject eggPrefab;       // Drag the Egg prefab here in Inspector
    public float xRange = 8f;          // Range along the X axis
    public float spawnHeight = 10f;    // Height from which eggs fall
    public float spawnInterval = 2f;   // Time gap between spawns

    void Start()
    {
        // Call the SpawnEgg function repeatedly
        InvokeRepeating("SpawnEgg", 1f, spawnInterval);
    }

    void SpawnEgg()
    {
        // Choose a random X position
        float randomX = Random.Range(-xRange, xRange);

        // Spawn position
        Vector3 spawnPos = new Vector3(randomX, spawnHeight, 0f);

        // Create egg
        Instantiate(eggPrefab, spawnPos, Quaternion.identity);
    }
   
}