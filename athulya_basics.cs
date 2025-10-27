using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float xRange = 8f;
    public float zRange = 8f;
    public Transform ground;  // Drag your plane here in Inspector
    public float offset = 1f; // Small gap above ground

    void Start()
    {
        InvokeRepeating("SpawnCoin", 1f, 2f);
    }

    void SpawnCoin()
    {
        float randomX = Random.Range(-xRange, xRange);
        float randomZ = Random.Range(-zRange, zRange);

        float yPos = ground.position.y + offset;

        Vector3 spawnPos = new Vector3(randomX, yPos, randomZ);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }
}