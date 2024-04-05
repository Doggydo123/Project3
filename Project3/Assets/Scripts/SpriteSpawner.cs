using UnityEngine;

public class SpriteSpawner : MonoBehaviour
{
    public GameObject spritePrefab; // Reference to the sprite prefab to spawn
    public int numberOfSprites = 10; // Number of sprites to spawn
    public float spawnRangeXMin = -3.4f; // Minimum value for X-axis spawn range
    public float spawnRangeXMax = 3.4f; // Maximum value for X-axis spawn range
    public float spawnRangeYMin = 10f; // Minimum value for Y-axis spawn range
    public float spawnRangeYMax = 16f; // Maximum value for Y-axis spawn range

    void Start()
    {
        // Spawn multiple sprites
        for (int i = 0; i < numberOfSprites; i++)
        {
            SpawnSprite();
        }
    }

    void SpawnSprite()
    {
        // Generate random position within the spawn range
        float randomX = Random.Range(spawnRangeXMin, spawnRangeXMax);
        float randomY = Random.Range(spawnRangeYMin, spawnRangeYMax);
        Vector3 spawnPosition = new Vector3(randomX, randomY, -3.9f);

        // Instantiate the sprite at the random position
        GameObject spriteInstance = Instantiate(spritePrefab, spawnPosition, Quaternion.identity);

        // Optionally, you can do further customization or initialization of the spawned sprite here
    }
}
